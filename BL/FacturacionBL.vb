Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class FacturacionBL

    Public Class SG_FA_TB_PAGO_CONGE_C
        Inherits ClsBD


        Public Function get_Articulos_Cogelacion(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PAGO_CONGE_C_01", empresa_).Tables(0)
        End Function

        Public Function get_Congelaciones(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PAGO_CONGE_C", empresa_).Tables(0)
        End Function

        Public Function get_Congelaciones_xID(idcongelacion_ As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PAGO_CONGE_XID", idcongelacion_)
        End Function

        Public Sub Insert(e As BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_C, lista As List(Of BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_D))


            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

            Try

                e.PG_ID = SqlHelper.ExecuteScalar(tr, "SG_FA_SP_I_PAGO_CONGE_C", e.PG_FEC_CONGE, e.PG_IDCOMPROBANTE, e.PG_IDCLIENTE, e.PG_IDCONGELACION, e.PG_IDMEDICO, e.PG_COMENTARIOS, e.PG_IMPORTE, e.PG_ESTADO, e.PG_USUARIO, e.PG_TERMINAL, e.PG_FECREG, e.PG_IDEMPRESA, e.PG_REF, e.PG_IDMONEDA, e.PG_TIPCAM)


                For Each a As BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_D In lista
                    SqlHelper.ExecuteNonQuery(tr, "SG_FA_SP_I_PAGO_CONGE_D", e.PG_ID, a.PD_ANHO, a.PD_MES, a.PD_FECPAGO, a.PD_IMPORTE, a.PD_IDCOMPROBANTE, a.PD_EST_CUOTA, a.PD_COMENTARIOS, a.PD_IDMONEDA, a.PD_TIPCAM, a.PD_REF)
                Next

                tr.Commit()

            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
            

        End Sub


        Public Sub Update(e As BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_C, lista As List(Of BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_D))
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

            Try

                SqlHelper.ExecuteNonQuery(tr, "SG_FA_SP_U_PAGO_CONGE_C", e.PG_ID, e.PG_FEC_CONGE, e.PG_IDCOMPROBANTE, e.PG_IDCLIENTE, e.PG_IDCONGELACION, e.PG_IDMEDICO, e.PG_COMENTARIOS, e.PG_IMPORTE, e.PG_ESTADO, e.PG_USUARIO, e.PG_TERMINAL, e.PG_FECREG, e.PG_IDEMPRESA, e.PG_REF, e.PG_IDMONEDA, e.PG_TIPCAM)

                SqlHelper.ExecuteNonQuery(tr, "SG_FA_SP_D_PAGO_CONGE_D", e.PG_ID)

                For Each a As BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_D In lista
                    SqlHelper.ExecuteNonQuery(tr, "SG_FA_SP_I_PAGO_CONGE_D", e.PG_ID, a.PD_ANHO, a.PD_MES, a.PD_FECPAGO, a.PD_IMPORTE, a.PD_IDCOMPROBANTE, a.PD_EST_CUOTA, a.PD_COMENTARIOS, a.PD_IDMONEDA, a.PD_TIPCAM, a.PD_REF)
                Next

                tr.Commit()

            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub


    End Class

    Public Class SG_FA_TB_TIPO_CONGELA
        Inherits ClsBD

        Public Sub Insert(entidad As BE.FacturacionBE.SG_FA_TB_TIPO_CONGELA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_TIPO_CONGELA", entidad.TC_ID, entidad.TC_DESCRIPCION, entidad.TC_IDEMPRESA)
        End Sub

        Public Sub Update(entidad As BE.FacturacionBE.SG_FA_TB_TIPO_CONGELA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_TIPO_CONGELA", entidad.TC_ID, entidad.TC_DESCRIPCION, entidad.TC_IDEMPRESA)
        End Sub

        Public Sub Delete(entidad As BE.FacturacionBE.SG_FA_TB_TIPO_CONGELA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_TIPO_CONGELA", entidad.TC_ID, entidad.TC_IDEMPRESA)
        End Sub

        Public Function get_tipos_cmb(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TIPO_CONGELA_CMB", empresa_).Tables(0)
        End Function

        Public Function get_tipos(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TIPO_CONGELA", empresa_).Tables(0)
        End Function

    End Class


    Public Class SG_FA_TB_PRE_FACTURA_DETALLE
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_PRE_FACTURA_DETALLE", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.PFD_IDCAB_CUENTA _
            , obe.PFD_ITEM _
            , obe.PFD_IDARTICULO _
            , obe.PFD_CANT _
            , obe.PFD_TOTAL _
            , obe.PFD_PRECIO _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_PRE_FACTURA_DETALLE", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.PFD_IDCAB_CUENTA _
            , obe.PFD_ITEM _
            , obe.PFD_IDARTICULO _
            , obe.PFD_CANT _
            , obe.PFD_TOTAL _
            , obe.PFD_PRECIO _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_PRE_FACTURA_DETALLE", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.PFD_ITEM _
            , obe.PFD_IDARTICULO _
             , obe.PFD_IDCAB_CUENTA _
            )
            Return N
        End Function
        Public Function Delete2(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_PRE_FACTURA_DETALLE_2", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.PFD_IDCAB_CUENTA _
            )
            Return N
        End Function

        'Public Function SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE) As SqlDataReader
        '    Return SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_PRE_FACTURA_DETALLE_1", obe.PFD_IDCAB_CUENTA)
        'End Function

        Public Function SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal IGV As Decimal) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PRE_FACTURA_DETALLE_1", oIdUsuarioActivo, oIdEstacionActiva, obe.PFD_IDCAB_CUENTA, obe.PFD_ITEM, IGV).Tables(0)
        End Function

        'Public Function SEL03(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE) As DataSet
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PRE_FACTURA_DETALLE_3", obe.PFD_IDCAB_CUENTA)
        'End Function

    End Class

    Public Class SG_FA_TB_PAQUETE_CAB

        Inherits ClsBD
        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_PAQUETE_CAB", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.PC_DESCRIPCION _
             , obe.PC_USUARIO _
             , obe.PC_TERMINAL _
             , obe.PC_IDEMPRESA _
             , obe.PC_CuentaCont _
             , obe.PC_IDARTICULO _
             , obe.PC_ESTADO _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_PAQUETE_CAB", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.PC_ID _
             , obe.PC_DESCRIPCION _
             , obe.PC_IDEMPRESA _
             , obe.PC_CuentaCont _
             , obe.PC_IDARTICULO _
             , obe.PC_ESTADO _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_PAQUETE_CAB", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.PC_ID _
             , obe.PC_IDEMPRESA _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_PAQUETE_CAB", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@PC_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.PC_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub


        Public Sub SEL03(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S3_PAQUETE_CAB", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@PC_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.PC_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S2_PAQUETE_CAB", obe.PC_ID)
            If drr.HasRows Then
                drr.Read()
                With obe
                    .HasRow = True
                    .PC_ID = drr("PC_ID")
                    .PC_DESCRIPCION = drr("PC_DESCRIPCION").ToString
                    .PC_ESTADO = drr("PC_ESTADO").ToString
                    .PC_IDEMPRESA = drr("PC_IDEMPRESA")
                    .PC_CuentaCont = drr("PC_CuentaCont").ToString
                End With
            End If

            drr.Close()

        End Sub

    End Class

    Public Class SG_FA_TB_PAQUETE_DET

        Inherits ClsBD
        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_PAQUETE_DET", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.PD_IDCAB _
             , obe.PD_IDARTICULO _
             , obe.PD_IDEMPRESA _
             , obe.PD_CANTIDAD _
             )
            Return N
        End Function

        'Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_PAQUETE_DET", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.PD_IDCAB _
        '     , obe.PD_IDARTICULO _
        '     , obe.PD_IDEMPRESA _
        '     )
        '    Return N
        'End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_PAQUETE_DET", oIdUsuarioActivo, oIdEstacionActiva _
                , obe.PD_IDCAB _
                , obe.PD_IDEMPRESA _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_PAQUETE_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@PD_IDCAB", System.Data.SqlDbType.Int).Value = obe.PD_IDCAB
            cmd.Parameters.Add("@PD_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.PD_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByVal Seguro As String, ByVal tipo As Integer, ByVal igv As Decimal, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S2_PAQUETE_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@PD_IDCAB", System.Data.SqlDbType.Int).Value = obe.PD_IDCAB
            cmd.Parameters.Add("@P_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.PD_IDEMPRESA
            cmd.Parameters.Add("@P_IDSEGURO", System.Data.SqlDbType.VarChar).Value = Seguro
            cmd.Parameters.Add("@P_TIPO", System.Data.SqlDbType.Int).Value = tipo
            cmd.Parameters.Add("@P_IGV", System.Data.SqlDbType.Decimal).Value = igv
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL03(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S3_PAQUETE_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@PD_IDCAB", System.Data.SqlDbType.Int).Value = obe.PD_IDCAB
            cmd.Parameters.Add("@PD_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.PD_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL03_Pre(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByVal Seguro As String, ByVal tipo As Integer, ByVal igv As Decimal, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S_PAQUETE_DET_3", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pIdUsuarioActivo", System.Data.SqlDbType.VarChar).Value = oIdUsuarioActivo
            cmd.Parameters.Add("@pIdEstacionActiva", System.Data.SqlDbType.VarChar).Value = oIdEstacionActiva
            cmd.Parameters.Add("@PD_IDCAB", System.Data.SqlDbType.Int).Value = obe.PD_IDCAB
            cmd.Parameters.Add("@P_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.PD_IDEMPRESA
            cmd.Parameters.Add("@P_IDSEGURO", System.Data.SqlDbType.VarChar).Value = Seguro
            cmd.Parameters.Add("@P_TIPO", System.Data.SqlDbType.Int).Value = tipo
            cmd.Parameters.Add("@P_IGV", System.Data.SqlDbType.Decimal).Value = igv
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub
        'Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S2_PAQUETE_DET", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_FA_TB_PRESUPUESTO_DET

        Inherits ClsBD

        'Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_PRESUPUESTO_DET", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.DP_ID _
        '     , obe.DP_ITEMS _
        '     , obe.DP_IDARTICULO _
        '     , obe.DP_CANT _
        '     , obe.DP_PRECIO _
        '     , obe.DP_DSCTO_SEG _
        '     , obe.DP_DSCTO_OTRO _
        '     , obe.DP_SUB_TOTAL _
        '     , obe.DP_IGV _
        '     , obe.DP_TOTAL _
        '     , obe.DP_SEG_CUBRE _
        '     , obe.DP_DEDUCIBLE _
        '     )
        '    Return N
        'End Function

        ''Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        ''    Dim N As Integer = -1
        ''    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_PRESUPUESTO_DET", oIdUsuarioActivo, oIdEstacionActiva _
        ''     , obe.DP_ID _
        ''     , obe.DP_ITEMS _
        ''     , obe.DP_IDARTICULO _
        ''     , obe.DP_CANT _
        ''     , obe.DP_PRECIO _
        ''     , obe.DP_DSCTO_SEG _
        ''     , obe.DP_DSCTO_OTRO _
        ''     , obe.DP_SUB_TOTAL _
        ''     , obe.DP_IGV _
        ''     , obe.DP_TOTAL _
        ''     , obe.DP_SEG_CUBRE _
        ''     , obe.DP_DEDUCIBLE _
        ''     )
        ''    Return N
        ''End Function

        ''Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        ''    Dim N As Integer = -1
        ''    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_PRESUPUESTO_DET", oIdUsuarioActivo, oIdEstacionActiva _
        ''     )
        ''    Return N
        ''End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_PRESUPUESTO_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DP_ID", System.Data.SqlDbType.Int).Value = obe.DP_ID
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub


    End Class

    Public Class SG_FA_TB_PRESUPUESTO_CAB
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_PRESUPUESTO_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                 , IIf(obe.PR_IDSEGURO = String.Empty, DBNull.Value, obe.PR_IDSEGURO) _
                 , obe.PR_IDNUMHIST _
                 , obe.PR_IDCLIENTE _
                 , obe.PR_IDMEDICO _
                 , obe.PR_IDPAQUETE _
                 , obe.PR_COPG_FIJO _
                 , obe.PR_COPG_VARI _
                 , obe.PR_FECHA _
                 , obe.PR_IDEMPRESA _
                 )

                obe.PR_ID = N

                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_PRESUPUESTO_DET", oIdUsuarioActivo, oIdEstacionActiva, obe.PR_ID)

                For Each deta_compro In obe.Detalles
                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_PRESUPUESTO_DET" _
                                                   , obe.PR_ID _
                                                   , .DP_ITEMS _
                                                   , .DP_IDARTICULO _
                                                   , .DP_CANT _
                                                   , .DP_PRECIO _
                                                   , .DP_DSCTO_SEG _
                                                   , .DP_DSCTO_OTRO _
                                                   , .DP_SUB_TOTAL _
                                                   , .DP_IGV _
                                                   , .DP_TOTAL _
                                                   , .DP_SEG_CUBRE _
                                                   , .DP_DEDUCIBLE _
                                                   )
                    End With

                Next

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try

                N = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_U_PRESUPUESTO_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                 , obe.PR_ID _
                 , IIf(obe.PR_IDSEGURO = String.Empty, DBNull.Value, obe.PR_IDSEGURO) _
                 , obe.PR_IDNUMHIST _
                 , obe.PR_IDCLIENTE _
                 , obe.PR_IDMEDICO _
                 , obe.PR_IDPAQUETE _
                 , obe.PR_COPG_FIJO _
                 , obe.PR_COPG_VARI _
                 )

                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_PRESUPUESTO_DET", oIdUsuarioActivo, oIdEstacionActiva, obe.PR_ID)

                For Each deta_compro In obe.Detalles
                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_PRESUPUESTO_DET" _
                                                   , obe.PR_ID _
                                                   , .DP_ITEMS _
                                                   , .DP_IDARTICULO _
                                                   , .DP_CANT _
                                                   , .DP_PRECIO _
                                                   , .DP_DSCTO_SEG _
                                                   , .DP_DSCTO_OTRO _
                                                   , .DP_SUB_TOTAL _
                                                   , .DP_IGV _
                                                   , .DP_TOTAL _
                                                   , .DP_SEG_CUBRE _
                                                   , .DP_DEDUCIBLE _
                                                   )
                    End With

                Next

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_PRESUPUESTO_CAB", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.PR_ID _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_PRESUPUESTO_CAB", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@PR_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.PR_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S2_PRESUPUESTO_CAB", Entidad.PR_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .PR_IDSEGURO = drr("PR_IDSEGURO")
                    .PR_IDNUMHIST = drr("PR_IDNUMHIST")
                    .PR_IDCLIENTE = drr("PR_IDCLIENTE")
                    .PR_IDMEDICO = drr("PR_IDMEDICO")
                    .PR_IDPAQUETE = drr("PR_IDPAQUETE")
                    .PR_COPG_FIJO = drr("PR_COPG_FIJO")
                    .PR_COPG_VARI = drr("PR_COPG_VARI")
                    .PR_ESTADO_PRE = drr("PR_ESTADO_PRE")
                    .PR_FECHA = drr("PR_FECHA")
                    .PR_IDpreFac = drr("PF_ID")
                End With
            End If

            drr.Close()

        End Sub


        Public Sub SEL03(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB, ByVal COLUMNA As String, ByVal VALOR As String, ByVal tipo As Boolean, ByVal FechaI As String, ByVal FechaF As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Dim VAlFecha As String = ""
            If tipo = True Then VAlFecha = " AND CONVERT(DATE,PR_FECHA) BETWEEN '" & FechaI & "' AND '" & FechaF & "'"

            Scrip = "SELECT top 300 PR_ID " & _
                         ",case when PR_IDSEGURO IS null then '' else PR_IDSEGURO end[PR_IDSEGURO] " & _
                         ",case when PR_IDNUMHIST IS null then 0 else PR_IDNUMHIST end [PR_IDNUMHIST] " & _
                         ",PR_IDCLIENTE " & _
                         ",CL_NDOC  " & _
                         ",CL_NOMBRE " & _
                         ",PR_IDMEDICO " & _
                         ",PR_IDPAQUETE " & _
                         ",case when PC_DESCRIPCION is null then 'OTRO' else PC_DESCRIPCION end [PC_DESCRIPCION] " & _
                         ",PR_COPG_FIJO " & _
                         ",PR_COPG_VARI " & _
                         ",PR_FECHA " & _
                         ",case PR_ESTADO_PRE when 1 then 'PENDIENTE' else 'PRE-FACTURADO' end[PR_ESTADO_PRE] " & _
                         ",CASE WHEN PF_ID IS NULL THEN 0 ELSE PF_ID END[PF_ID] " & _
                    "FROM SG_FA_TB_PRESUPUESTO_CAB  " & _
                        "left join SG_FA_TB_PAQUETE_CAB on PC_ID=PR_IDPAQUETE and PC_IDEMPRESA =PR_IDEMPRESA " & _
                        "INNER JOIN SG_FA_TB_CLIENTE ON CL_ID =PR_IDCLIENTE " & _
                        "LEFT JOIN SG_FA_TB_PRE_FACTURA_CAB ON PR_ID =PF_IDPRESUPUESTO  " & _
                    "where PR_IDEMPRESA=" & obe.PR_IDEMPRESA & " and " & COLUMNA & " like '" & VALOR & "%' " & VAlFecha & " order by PR_ID desc"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S2_PRESUPUESTO_CAB", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@PR_ID", System.Data.SqlDbType.Int).Value = obe.PR_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_FA_TB_PRE_FACTURA_CAB

        Inherits ClsBD

        Public Function Insert_Presup(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal id_ar As Integer, ByVal igv As Integer) As Integer
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try

                N = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_PRE_FACTURA_CAB_Presu", oIdUsuarioActivo, oIdEstacionActiva _
                         , obe.PF_IDTIPO_ATENC _
                         , obe.PF_IDNUMHIST _
                         , obe.PF_IDCLIENTE _
                         , obe.PF_IDMEDICO _
                         , obe.PF_USUARIO _
                         , obe.PF_TERMINAL _
                         , obe.PF_IDEMPRESA _
                         , obe.PF_FECHA _
                         , obe.PF_Tratamiento _
                         , id_ar _
                         , igv _
                 )

                TRvar.Commit()
                TRvar.Dispose()
            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try
            Return N
        End Function

        Public Function Update_Presup(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal id_ar As Integer, ByVal igv As Integer) As Integer

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_U_PRE_FACTURA_CAB_Presu", oIdUsuarioActivo, oIdEstacionActiva _
                         , obe.PF_ID _
                         , obe.PF_IDCUENTA _
                         , obe.PF_IDTIPO_ATENC _
                         , obe.PF_IDNUMHIST _
                         , obe.PF_IDCLIENTE _
                         , obe.PF_IDMEDICO _
                         , obe.PF_IDEMPRESA _
                         , obe.PF_FECHA _
                         , obe.PF_Tratamiento _
                         , id_ar _
                         , igv _
                 )

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try

            Return N

        End Function

        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal TipoCuenta As Integer, ByVal tipFecha As Integer, ByVal tipFechaA As Integer) As Integer
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try
                If obe.PF_IDPRESUPUESTO = 0 And obeC.CC_IDTIPO_ORI <> 1 Then
                    '--------------------------
                    N = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_PRESUPUESTO_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                   , IIf(obe.PF_IDSEGURO = String.Empty, DBNull.Value, obe.PF_IDSEGURO) _
                   , obe.PF_IDNUMHIST _
                   , obe.PF_IDCLIENTE _
                   , obe.PF_IDMEDICO _
                   , obe.PF_IDPaquete _
                   , obeC.CC_SIT_COPG_FIJO _
                   , obeC.CC_SIT_COPG_VARI _
                   , obe.PF_FECHA _
                   , obe.PF_IDEMPRESA _
                   )

                    obe.PF_IDPRESUPUESTO = N

                    SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_PRESUPUESTO_DET", oIdUsuarioActivo, oIdEstacionActiva, obe.PF_IDPRESUPUESTO)

                    For Each deta_compro In obe.Detalles
                        With deta_compro
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_PRESUPUESTO_DET" _
                                                       , obe.PF_IDPRESUPUESTO _
                                                       , .DP_ITEMS _
                                                       , .DP_IDARTICULO _
                                                       , .DP_CANT _
                                                       , .DP_PRECIO _
                                                       , .DP_DSCTO_SEG _
                                                       , .DP_DSCTO_OTRO _
                                                       , .DP_SUB_TOTAL _
                                                       , .DP_IGV _
                                                       , .DP_TOTAL _
                                                       , .DP_SEG_CUBRE _
                                                       , .DP_DEDUCIBLE _
                                                       )
                        End With

                    Next

                    '------------------------
                End If

                'MsgBox(obe.PF_FECHAIngreso)
                '' MsgBox(IIf(obe.PF_FECHAIngreso = "", DBNull.Value, obe.PF_FECHAIngreso))
                'If obe.PF_FECHAIngreso = "" Then
                '    DBNull()
                'End If
                ' obe.PF_FECHAIngreso = IIf(obe.PF_FECHAIngreso = "", DBNull.Value, CDate(obe.PF_FECHAIngreso))
                N = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_PRE_FACTURA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                         , obe.PF_IDCUENTA _
                         , obe.PF_IDTIPO_ATENC _
                         , obe.PF_IDSEGURO _
                         , obe.PF_IDNUMHIST _
                         , obe.PF_IDCLIENTE _
                         , obe.PF_IDMEDICO _
                         , obe.PF_SUBTOTAL _
                         , obe.PF_IGV _
                         , obe.PF_TOTAL _
                         , obe.PF_USUARIO _
                         , obe.PF_TERMINAL _
                         , obe.PF_IDEMPRESA _
                         , obe.PF_FECHA _
                         , obe.PF_IDCIE10 _
                         , obe.PF_IDPRESUPUESTO _
                         , obe.PF_FECHAIngreso _
                         , obe.PF_FECHAAlta _
                         , tipFecha _
                         , tipFechaA _
                         , obe.PF_Tratamiento
                 )

                If N >= 0 Then
                    obeC.CC_IDPREFAC = N
                    obeC.CC_IDCITA = 0
                    If TipoCuenta = 0 Then

                        N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_I_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                        , obeC.CC_IDTIPO_ORI _
                        , obeC.CC_IDNUM_HIST _
                        , obeC.CC_IDCLIENTE _
                        , obeC.CC_IDTIPO_ATENC _
                        , obeC.CC_IDSEGURO _
                        , obeC.CC_FECHA _
                        , obeC.CC_USUARIO _
                        , obeC.CC_TERMINAL _
                        , obeC.CC_IDEMPRESA _
                        , obeC.CC_IDCITA _
                        , obeC.CC_IDPREFAC _
                        , obeC.CC_SIT_COD_EPS _
                        , obeC.CC_SIT_COD_ASEG _
                        , obeC.CC_SIT_FEC_AUTORI _
                        , obeC.CC_SIT_COD_COBER _
                        , obeC.CC_SIT_COPG_FIJO _
                        , obeC.CC_SIT_COPG_VARI _
                        , obeC.CC_SIT_COD_GENE _
                        , obeC.CC_INGRESO_MANUAL _
                        , obeC.CC_TIPOAFILIACION _
                        , obeC.CC_SIT_MONTO_IMP _
                        )
                    ElseIf TipoCuenta = 1 Then
                        N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_U_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                       , obeC.CC_ID _
                       , obeC.CC_IDTIPO_ORI _
                       , obeC.CC_FECHA _
                       , obeC.CC_IDEMPRESA _
                       , obeC.CC_IDCITA _
                       , obeC.CC_IDPREFAC _
                       , obeC.CC_SIT_COD_EPS _
                       , obeC.CC_SIT_COD_ASEG _
                       , obeC.CC_SIT_FEC_AUTORI _
                       , obeC.CC_SIT_COD_COBER _
                       , obeC.CC_SIT_COPG_FIJO _
                       , obeC.CC_SIT_COPG_VARI _
                       , obeC.CC_SIT_COD_GENE _
                       , obeC.CC_INGRESO_MANUAL _
                        , obeC.CC_TIPOAFILIACION _
                        , obeC.CC_IDSEGURO _
                        , obeC.CC_SIT_MONTO_IMP _
                       )

                        SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_AD_TB_CUENTA_CAB set CC_ESTADO_PROC=1,CC_FECHA_PROC='" & obeC.CC_FECHA_PROC.Date & "' where CC_ID =" & obeC.CC_ID & " and " & obeC.CC_ESTADO_PROC & "=1")
                    End If
                End If
                SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_FA_TB_PRE_FACTURA_CAB set PF_FacTramite=" & obe.PF_FacTramite & " where PF_IDCUENTA =" & N)

                SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_FA_TB_PRE_FACTURA_DETALLE set PFD_IDCAB_CUENTA='" & N & "' where PFD_USUARIO='" & oIdUsuarioActivo & "' and PFD_ESTACION ='" & oIdEstacionActiva & "' and PFD_IDCAB_CUENTA =0")
                TRvar.Commit()
                TRvar.Dispose()
            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try
            Return N
        End Function

        Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal TipoCuenta As Integer, ByVal tipFecha As Integer, ByVal tipFechaA As Integer) As Integer

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_U_PRE_FACTURA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                         , obe.PF_ID _
                         , obe.PF_IDCUENTA _
                         , obe.PF_IDTIPO_ATENC _
                         , obe.PF_IDSEGURO _
                         , obe.PF_IDNUMHIST _
                         , obe.PF_IDCLIENTE _
                         , obe.PF_IDMEDICO _
                         , obe.PF_SUBTOTAL _
                         , obe.PF_IGV _
                         , obe.PF_TOTAL _
                         , obe.PF_IDEMPRESA _
                         , obe.PF_FECHA _
                         , obe.PF_IDCIE10 _
                         , obe.PF_IDPRESUPUESTO _
                         , obe.PF_FECHAIngreso _
                         , obe.PF_FECHAAlta _
                         , tipFecha _
                         , tipFechaA _
                         , obe.PF_Tratamiento
                 )
                SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_FA_TB_PRE_FACTURA_CAB set PF_FacTramite=" & obe.PF_FacTramite & " where PF_IDCUENTA =" & obe.PF_IDCUENTA)
                If N >= 0 Then
                    obeC.CC_IDCITA = 0
                    obeC.CC_IDPREFAC = obe.PF_ID

                    N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_U_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
                   , obeC.CC_ID _
                   , obeC.CC_IDTIPO_ORI _
                   , obeC.CC_FECHA _
                   , obeC.CC_IDEMPRESA _
                   , obeC.CC_IDCITA _
                   , obeC.CC_IDPREFAC _
                   , obeC.CC_SIT_COD_EPS _
                    , obeC.CC_SIT_COD_ASEG _
                    , obeC.CC_SIT_FEC_AUTORI _
                    , obeC.CC_SIT_COD_COBER _
                    , obeC.CC_SIT_COPG_FIJO _
                    , obeC.CC_SIT_COPG_VARI _
                    , obeC.CC_SIT_COD_GENE _
                    , obeC.CC_INGRESO_MANUAL _
                     , obeC.CC_TIPOAFILIACION _
                    , obeC.CC_IDSEGURO _
                    , obeC.CC_SIT_MONTO_IMP _
                   )

                    SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_AD_TB_CUENTA_CAB set CC_ESTADO_PROC=1,CC_FECHA_PROC='" & obeC.CC_FECHA_PROC.Date & "' where CC_ID =" & obeC.CC_ID & " and " & obeC.CC_ESTADO_PROC & "=1")
                End If

                SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_FA_TB_PRE_FACTURA_DETALLE set PFD_IDCAB_CUENTA='" & obeC.CC_ID & "' where PFD_USUARIO='" & oIdUsuarioActivo & "' and PFD_ESTACION ='" & oIdEstacionActiva & "' and PFD_IDCAB_CUENTA =0")

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try

            Return N

        End Function

        Public Function UpdatePreFactura_Farmacia(ByVal Copago As Double, ByVal Cuenta As Integer, ByVal IGVTasa As Double) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_PRE_FACTURA_FarAmb", Copago, Cuenta ,IGVTasa)
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_PRE_FACTURA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.PF_ID _
            , obe.PF_IDCUENTA _
            , obe.PF_IDPRESUPUESTO _
             )
            Return N
        End Function

        Public Function Update_Farmacia_Det(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_PRE_FACTURA_DET_FARM", obe.PF_IDCUENTA, obe.PF_IDSEGURO, obe.PF_IGV _
             )
            Return N
        End Function

        Public Sub SEL01(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S1_PRE_FACTURA_CAB", Entidad.PF_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .PF_ID = drr("PF_ID")
                    .PF_IDCUENTA = drr("PF_IDCUENTA")
                    .PF_IDTIPO_ATENC = drr("PF_IDTIPO_ATENC")
                    .PF_IDSEGURO = drr("PF_IDSEGURO")
                    .PF_IDNUMHIST = drr("PF_IDNUMHIST")
                    .PF_IDCLIENTE = drr("PF_IDCLIENTE")
                    .PF_IDMEDICO = drr("PF_IDMEDICO")
                    .PF_SUBTOTAL = drr("PF_SUBTOTAL")
                    .PF_IGV = drr("PF_IGV")
                    .PF_TOTAL = drr("PF_TOTAL")
                    .PF_ESTADO_PRE_F = drr("PF_ESTADO_PRE_F")
                    .PF_IDEMPRESA = drr("PF_IDEMPRESA")
                    .PF_FECHA = drr("PF_FECHA")
                    .PF_IDCIE10 = drr("PF_IDCIE10")
                    .PF_IDPRESUPUESTO = drr("PF_IDPRESUPUESTO")
                    .PF_FECHAIngreso = IIf(drr("PF_FECHAIngreso").ToString = "", Nothing, drr("PF_FECHAIngreso").ToString)
                    .PF_FECHAAlta = IIf(drr("PF_FECHAAlta").ToString = "", Nothing, drr("PF_FECHAAlta").ToString)
                    .PF_Tratamiento = drr("PF_Tratamiento").ToString
                    .PF_FacTramite = drr("PF_FacTramite").ToString
                End With
            End If

            drr.Close()

        End Sub

        Public Sub SEL02(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S2_PRE_FACTURA_CAB", Entidad.PF_IDCUENTA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .PF_ID = drr("PF_ID")
                    .PF_IDCUENTA = drr("PF_IDCUENTA")
                    .PF_IDTIPO_ATENC = drr("PF_IDTIPO_ATENC")
                    .PF_IDSEGURO = drr("PF_IDSEGURO").ToString
                    .PF_IDNUMHIST = drr("PF_IDNUMHIST")
                    .PF_IDCLIENTE = drr("PF_IDCLIENTE")
                    .PF_IDMEDICO = drr("PF_IDMEDICO")
                    .PF_SUBTOTAL = drr("PF_SUBTOTAL")
                    .PF_IGV = drr("PF_IGV")
                    .PF_TOTAL = drr("PF_TOTAL")
                    .PF_ESTADO_PRE_F = drr("PF_ESTADO_PRE_F")
                    .PF_IDEMPRESA = drr("PF_IDEMPRESA")
                    .PF_FECHA = drr("PF_FECHA")
                    .PF_IDCIE10 = drr("PF_IDCIE10")
                    .PF_IDPRESUPUESTO = drr("PF_IDPRESUPUESTO")
                    .PF_Tratamiento = drr("PF_Tratamiento").ToString
                End With
            End If

            drr.Close()

        End Sub

        Public Sub SEL03(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByVal COLUMNA As String, ByVal VALOR As String, ByVal tipo As Boolean, ByVal FechaI As String, ByVal FechaF As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Dim VAlFecha As String = ""
            If tipo = True Then VAlFecha = " AND CONVERT(DATE,PR_FECHA) BETWEEN '" & FechaI & "' AND '" & FechaF & "'"

            Scrip = "SELECT top 300 PR_ID " & _
                         ",case when PR_IDSEGURO IS null then '' else PR_IDSEGURO end[PR_IDSEGURO] " & _
                         ",case when PR_IDNUMHIST IS null then 0 else PR_IDNUMHIST end [PR_IDNUMHIST] " & _
                         ",PR_IDCLIENTE " & _
                         ",CL_NDOC  " & _
                         ",CL_NOMBRE " & _
                         ",PR_IDMEDICO " & _
                         ",PR_IDPAQUETE " & _
                         ",case when PC_DESCRIPCION is null then 'OTRO' else PC_DESCRIPCION end [PC_DESCRIPCION] " & _
                         ",PR_COPG_FIJO " & _
                         ",PR_COPG_VARI " & _
                         ",PR_FECHA " & _
                         ",case PR_ESTADO_PRE when 1 then 'PENDIENTE' else 'PRE-FACTURADO' end[PR_ESTADO_PRE] " & _
                         ",CASE WHEN PF_ID IS NULL THEN 0 ELSE PF_ID END[PF_ID] " & _
                    "FROM SG_FA_TB_PRESUPUESTO_CAB  " & _
                        "left join SG_FA_TB_PAQUETE_CAB on PC_ID=PR_IDPAQUETE and PC_IDEMPRESA =PR_IDEMPRESA " & _
                        "INNER JOIN SG_FA_TB_CLIENTE ON CL_ID =PR_IDCLIENTE " & _
                        "LEFT JOIN SG_FA_TB_PRE_FACTURA_CAB ON PR_ID =PF_IDPRESUPUESTO  " & _
                    "where PR_IDEMPRESA=" & obe.PF_IDEMPRESA & " and " & COLUMNA & " like '" & VALOR & "%' " & tipo & " order by PR_ID desc"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S1_PRE_FACTURA_CAB", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@PF_ID", System.Data.SqlDbType.Int).Value = obe.PF_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

        'Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S2_PRE_FACTURA_CAB", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@PF_ID", System.Data.SqlDbType.Int).Value = obe.PF_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_FA_TB_CIE10
        Inherits ClsBD

        Public Function getOrigen() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S1_CIE10").Tables(0)
        End Function

        Public Function getOrigenBus(ByVal dato As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S2_CIE10", dato)
        End Function

    End Class

    Public Class SG_FA_TB_TARIFA_MEDICA
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_TARIFA_MEDICA, ByVal IGV As Integer, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_TARIFA_MEDICA", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.TM_IDARTICULO _
             , obe.TM_IDMEDICO _
             , obe.TM_IDEMPRESA _
             , obe.TM_PRECIO _
             , IGV _
             )
            Return N
        End Function

        'Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_TARIFA_MEDICA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_TARIFA_MEDICA", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.TM_IDARTICULO _
        '     , obe.TM_IDMEDICO _
        '     , obe.TM_IDEMPRESA _
        '     , obe.TM_PRECIO _
        '     )
        '    Return N
        'End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_TARIFA_MEDICA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_TARIFA_MEDICA", oIdUsuarioActivo, oIdEstacionActiva _
                , obe.TM_IDARTICULO _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_TARIFA_MEDICA, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_TARIFA_MEDICA", Cn)
            cmd.Parameters.Add("@TM_IDARTICULO", System.Data.SqlDbType.Int).Value = obe.TM_IDARTICULO
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE_SG_FA_TB_TARIFA_MEDICA, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S2_TARIFA_MEDICA", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_FA_TB_TURNO
        Inherits ClsBD

        Public Function get_Turnos(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_TURNO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TURNO", Entidad.TU_IDEMPRESA).Tables(0)
        End Function

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_TURNO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_TURNO", .TU_ID, .TU_DESCRIPCION, .TU_IDEMPRESA)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_TURNO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_TURNO", .TU_ID, .TU_DESCRIPCION, .TU_IDEMPRESA)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_TURNO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_TURNO", .TU_ID, .TU_DESCRIPCION, .TU_IDEMPRESA)
            End With
        End Sub

    End Class

    Public Class SG_FA_TB_CAJA_CAB
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CAJA_CAB)
            With Entidad
                Entidad.CA_ID = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_CAJA_CAB", .CA_APE_SOL, .CA_APE_DOL, .CA_CIE_SOL, .CA_CIE_DOL, .CA_IDUSUARIO, .CA_IDTURNO, .CA_FECHA, .CA_ESTADO, .CA_USUARIO, .CA_TERMINAL, .CA_FECREG, .CA_IDEMPRESA)
            End With
        End Sub
        Public Sub Insert2(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CAJA_CAB)
            With Entidad
                Entidad.CA_ID = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_CAJA_CAB2", .CA_APE_SOL, .CA_APE_DOL, .CA_CIE_SOL, .CA_CIE_DOL, .CA_IDUSUARIO, .CA_IDTURNO, .CA_FECHA, .CA_ESTADO, .CA_USUARIO, .CA_TERMINAL, .CA_FECREG, .CA_IDEMPRESA)
            End With
        End Sub
        Public Sub Insert_Comp(ByVal Idcaja As Integer, ByVal Idcompro As Integer)
            SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_CAJA_CAB_2", Idcaja, Idcompro)
        End Sub
        Public Sub Delete_Comp(ByVal Idcompro As Integer)
            SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_CAJA_CAB_2", Idcompro)
        End Sub
        Public Sub Update(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CAJA_CAB)
            With Entidad
                Entidad.CA_ID = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_CAJA_CAB", .CA_ID, .CA_CIE_SOL, .CA_CIE_DOL, .CA_USUARIO_CIE, .CA_TERMINAL_CIE, .CA_FECREG_CIE, .CA_NUM_VOU_CONTA, .CA_IDVOUCHER, .CA_IDEMPRESA)
            End With
        End Sub

        Public Function get_Comprobantes_x_Usuario(ByVal idUsuario As Integer, ByVal IDCAja_ As Integer, ByVal empresa_ As Integer) As DataTable
            'Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPRO_X_IDUSU", idUsuario, fecha_, empresa_).Tables(0)
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPRO_X_IDUSU_02", idUsuario, IDCAja_, empresa_).Tables(0)
        End Function

        Public Function get_Data_Caja(ByVal idUsuario As Integer, ByVal fecha_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJA_USU", idUsuario, fecha_, empresa_).Tables(0)
        End Function

        Public Function get_Data_Caja2(ByVal idUsuario As Integer, ByVal fecha_ As String, ByVal empresa_ As Integer, ByVal tURNO_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJA_USU2", idUsuario, fecha_, empresa_, tURNO_).Tables(0)
        End Function

        Public Function get_Data_Caja3(ByVal fecha_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJA_USU3", fecha_, empresa_).Tables(0)
        End Function
        Public Function get_comprobantesLibres(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBANTE_L", empresa_).Tables(0)
        End Function
    End Class

    Public Class SG_FA_TB_COMPRO_DOCPAGO
        Inherits ClsBD

        Public Sub Insert(ByVal lista As List(Of BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO))

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                If lista.Count > 0 Then
                    SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "DELETE FROM SG_FA_TB_COMPRO_DOCPAGO WHERE CD_IDCOMPROBANTE = " & lista(0).CD_IDCOMPROBANTE.ToString)
                End If

                For Each e As BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO In lista
                    With e
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPRO_DOCPAGO", .CD_IDCOMPROBANTE, .CD_IDDOCPAGO, .CD_IMPORTE, .CD_IMPORTED, .CD_USUARIO, .CD_PC, .CD_FECREG)
                    End With
                Next
                TRvar.Commit()

            Catch ex As Exception
                TRvar.Rollback()
            End Try

        End Sub

        Public Function get_Cuentas_por_IdComprobante(ByVal idComprobante_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DET_X_IDCOMPRO", idComprobante_, empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_CLIENTE_COMUNI
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_CLIENTE_COMUNI", Entidad.CC_IDCLIENTE, Entidad.CC_IDCOMUNICA, Entidad.CC_DESCRIPCION)
        End Sub

        Public Sub Delete_all_xId(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CLIENTE_COMUNI", Entidad.CC_IDCLIENTE)
        End Sub

        Public Function get_Comuninicaciones_xId(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CLIENTE_COMUNI", Entidad.CC_IDCLIENTE).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_TIPO_COMUNICACION
        Inherits ClsBD

        Public Function getTipos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TIPO_COMUN", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_ARTI_SEGU
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_ARTI_SEGU", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.AS_IDARTICULO _
             , obe.AS_IDSEGURO _
             , obe.AS_IMPORTE _
             , obe.AS_IDEMPRESA _
             )
            Return N
        End Function

        'Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_ARTI_SEGU", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.AS_IDARTICULO _
        '     , obe.AS_IDSEGURO _
        '     , obe.AS_IMPORTE _
        '     , obe.AS_IDEMPRESA _
        '     , obe.AS_USUARIO _
        '     , obe.AS_TERMINAL _
        '     )
        '    Return N
        'End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_ARTI_SEGU", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.AS_IDARTICULO _
             , obe.AS_IDEMPRESA _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_ARTI_SEGU", Cn)
            cmd.Parameters.Add("@AS_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.AS_IDEMPRESA
            cmd.Parameters.Add("@AS_IDArticulo", System.Data.SqlDbType.Int).Value = obe.AS_IDARTICULO
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU, ByVal tIPO As Integer, ByVal igv As Decimal, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S2_ARTI_SEGU", Cn)
        '    cmd.Parameters.Add("@AS_IDSEGURO", System.Data.SqlDbType.VarChar).Value = obe.AS_IDSEGURO
        '    cmd.Parameters.Add("@AS_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.AS_IDEMPRESA
        '    cmd.Parameters.Add("@as_Tipo", System.Data.SqlDbType.Int).Value = tIPO
        '    cmd.Parameters.Add("@AS_IGV", System.Data.SqlDbType.Float).Value = igv
        '    cmd.CommandType = CommandType.StoredProcedure
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

        'Public Sub SEL03(ByVal obe As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S3_ARTI_SEGU", Cn)
        '    cmd.Parameters.Add("@AS_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.AS_IDEMPRESA
        '    cmd.CommandType = CommandType.StoredProcedure
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_FA_TB_CIA_ASEG
        Inherits ClsBD

        Public Function getAseguradoras(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CIA_ASEG_01", empresa_).Tables(0)
        End Function

        Public Sub get_Aseguradora_x_id(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CIA_ASEG)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_CIA_ASEG_02", Entidad.CA_ID, Entidad.CA_IDEMPRESA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .CA_IDASEGU_SITED = drr("CA_IDASEGU_SITED").ToString
                    .CA_NUM_DOC = drr("CA_NUM_DOC").ToString
                End With
            End If

            drr.Close()

        End Sub

        Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_CIA_ASEG, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_CIA_ASEG", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CA_IDTIPO_CIA_ASEG _
             , obe.CA_DESCRIPCION _
             , obe.CA_DIRECCION _
             , obe.CA_IDTIPO_DOC _
             , obe.CA_NUM_DOC _
             , obe.CA_TELEFONO _
             , obe.CA_PAG_WEB _
             , obe.CA_REPRE _
             , obe.CA_IDEMPRESA _
             , obe.CA_IDASEGU_SITED _
             , obe.CA_IDSUNASA _
             , obe.CA_FactorHonorario _
             , obe.CA_FactorServicio _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_CIA_ASEG, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_CIA_ASEG", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CA_ID _
             , obe.CA_IDTIPO_CIA_ASEG _
             , obe.CA_DESCRIPCION _
             , obe.CA_DIRECCION _
             , obe.CA_IDTIPO_DOC _
             , obe.CA_NUM_DOC _
             , obe.CA_TELEFONO _
             , obe.CA_PAG_WEB _
             , obe.CA_REPRE _
             , obe.CA_IDEMPRESA _
             , obe.CA_IDASEGU_SITED _
             , obe.CA_IDSUNASA _
             , obe.CA_FactorHonorario _
             , obe.CA_FactorServicio _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_CIA_ASEG, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_CIA_ASEG", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CA_ID _
             , obe.CA_IDEMPRESA _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_CIA_ASEG, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_CIA_ASEG", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CA_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.CA_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_CIA_ASEG, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S2_CIA_ASEG", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@CA_ID", System.Data.SqlDbType.VarChar).Value = obe.CA_ID
        '    cmd.Parameters.Add("@CA_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.CA_IDEMPRESA
        '    cmd.Parameters.Add("@CA_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.CA_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub
    End Class

    Public Class SG_FA_TB_TIPO_CIA_ASEG
        Inherits ClsBD

        'Public Function Insert(ByVal obe As BE.FacturacionBE.SG_FA_TB_TIPO_CIA_ASEG, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_TIPO_CIA_ASEG", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.TA_ID _
        '     , obe.TA_DESCRIPCION _
        '     , obe.TA_IDEMPRESA _
        '     )
        '    Return N
        'End Function

        'Public Function Update(ByVal obe As BE.FacturacionBE.SG_FA_TB_TIPO_CIA_ASEG, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_TIPO_CIA_ASEG", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.TA_ID _
        '     , obe.TA_DESCRIPCION _
        '     , obe.TA_IDEMPRESA _
        '     )
        '    Return N
        'End Function

        'Public Function Delete(ByVal obe As BE.FacturacionBE.SG_FA_TB_TIPO_CIA_ASEG, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_D_TIPO_CIA_ASEG", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.TA_ID _
        '     , obe.TA_IDEMPRESA _
        '     )
        '    Return N
        'End Function

        Public Sub SEL01(ByVal obe As BE.FacturacionBE.SG_FA_TB_TIPO_CIA_ASEG, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_FA_SP_S1_TIPO_CIA_ASEG", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TA_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.TA_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.FacturacionBE.SG_FA_TB_TIPO_CIA_ASEG, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_FA_SP_S2_TIPO_CIA_ASEG", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@TA_ID", System.Data.SqlDbType.VarChar).Value = obe.TA_ID
        '    cmd.Parameters.Add("@TA_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.TA_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_FA_TB_TIPO_ARTICULO
        Inherits ClsBD

        Public Function getTipos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TIPO_ARTICULO", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_DOCU_PAGO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_DOCU_PAGO", .DP_CODIGO, .DP_DESCRIPCION, .DP_ABREVIATURA, .DP_CTA_CONTA.PC_NUM_CUENTA, .DP_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_DOCU_PAGO", .DP_CODIGO, .DP_DESCRIPCION, .DP_ABREVIATURA, .DP_CTA_CONTA.PC_NUM_CUENTA, .DP_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_DOCU_PAGO", .DP_CODIGO, .DP_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_DocuPagos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DOCU_PAGO", empresa_).Tables(0)
        End Function

        Public Function get_DocuPagos_x_Id(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DOCU_PAGO", Entidad.DP_CODIGO, Entidad.DP_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_PARIDAD
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PARIDAD", .PA_FECHA, .PA_IDMONEDA.MO_ID, .PA_COMPRA, .PA_VENTA, .PA_IDEMPRESA.EM_ID, .PA_USUARIO, .PA_TERMINAL, .PA_FECREG)
            End With
        End Sub

        Public Sub Insert_AllEmpresas_desdeConta(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD)
            With Entidad
                For i As Integer = 2 To 6

                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_O_PARIDAD", .PA_FECHA, .PA_IDMONEDA.MO_ID, .PA_COMPRA, .PA_VENTA, i, .PA_USUARIO, .PA_TERMINAL, .PA_FECREG)
                Next

            End With
        End Sub

        Public Sub Insert_AllEmpresas(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD)
            With Entidad
                For i As Integer = 2 To 6
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PARIDAD", .PA_FECHA, .PA_IDMONEDA.MO_ID, .PA_COMPRA, .PA_VENTA, i, .PA_USUARIO, .PA_TERMINAL, .PA_FECREG)
                Next
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_PARIDAD", .PA_FECHA, .PA_IDMONEDA.MO_ID, .PA_COMPRA, .PA_VENTA, .PA_IDEMPRESA.EM_ID, .PA_USUARIO, .PA_TERMINAL, .PA_FECREG)
            End With
        End Sub

        Public Sub Update_AllEmpresas(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD)
            With Entidad
                For i As Integer = 2 To 6
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_PARIDAD", .PA_FECHA, .PA_IDMONEDA.MO_ID, .PA_COMPRA, .PA_VENTA, i, .PA_USUARIO, .PA_TERMINAL, .PA_FECREG)
                Next
            End With
        End Sub

        Public Function get_Pariedad_x_Ayo(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARIDAD", CDate(Entidad.PA_FECHA).Year, Entidad.PA_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Pariedad_x_Fecha(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARIDAD_X_FEC", Entidad.PA_FECHA, Entidad.PA_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Pariedad_x_Ultimo(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARIDAD_UlTIMO", Entidad.PA_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Pariedad_x_UltimoXFecha(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_PARIDAD) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARIDAD_UlTIMAXFecha", Entidad.PA_FECHA, Entidad.PA_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_MONEDA
        Inherits ClsBD

        Public Function get_Monedas(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_MONEDA", empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Moneda(ByVal IDMONEDA As String, ByVal IDEMPRESA As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_MONEDA_X_ID", IDMONEDA, IDEMPRESA)
        End Function

        'Public Function get_Moneda(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_MONEDA_X_ID", Entidad.MO_ID, Entidad.MO_IDEMPRESA.EM_ID).Tables(0)
        'End Function

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA)
            Dim cod_mon_cod As Integer = 0

            If Not Entidad.MO_IDMON_CONTA Is Nothing Then
                cod_mon_cod = Entidad.MO_IDMON_CONTA.MO_CODIGO
            End If

            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_MONEDA", .MO_ID, .MO_DESCRIPCION, .MO_ABREVIATURA, .MO_SIMBOLO, _
                                          IIf(cod_mon_cod = 0, DBNull.Value, cod_mon_cod), _
                                          .MO_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA)

            Dim cod_mon_cod As Integer = 0

            If Not Entidad.MO_IDMON_CONTA Is Nothing Then
                cod_mon_cod = Entidad.MO_IDMON_CONTA.MO_CODIGO
            End If

            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_MONEDA", .MO_ID, .MO_DESCRIPCION, .MO_ABREVIATURA, .MO_SIMBOLO, _
                                          IIf(cod_mon_cod = 0, DBNull.Value, cod_mon_cod), _
                                          .MO_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_MONEDA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_MONEDA", .MO_ID, .MO_IDEMPRESA)
            End With
        End Sub

    End Class

    Public Class SG_FA_TB_CAJERO
        Inherits ClsBD

        Public Function get_Cajeros(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJERO", empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Cajero(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJERO_X_ID", Entidad.CA_ID, Entidad.CA_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_CAJERO", .CA_ID, .CA_NOMBRES, .CA_IDUSUARIO.US_ID, .CA_IDEMPRESA.EM_ID, .CA_USUARIO, .CA_TERMINAL, .CA_FECREG, .CA_ESTADO)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_CAJERO", .CA_ID, .CA_NOMBRES, .CA_IDUSUARIO.US_ID, .CA_IDEMPRESA.EM_ID, .CA_USUARIO, .CA_TERMINAL, .CA_FECREG, .CA_ESTADO)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CAJERO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CAJERO", .CA_ID, .CA_IDEMPRESA.EM_ID)
            End With
        End Sub

    End Class

    Public Class SG_FA_TB_DOCUMENTO
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_DOCUMENTO", .DO_CODIGO, .DO_DESCRIPCION, .DO_ABREVIATURA, .DO_ES_RESTA, .DO_ISTATUS, .DO_CODIGO_SUNAT, .DO_USUARIO, .DO_TERMINAL, .DO_FECREG, .DO_IDEMPRESA.EM_ID, .DO_COD_CONTA)
            End With
        End Sub

        Public Sub Update(ByVal entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_DOCUMENTO", .DO_CODIGO, .DO_DESCRIPCION, .DO_ABREVIATURA, .DO_ES_RESTA, .DO_ISTATUS, .DO_CODIGO_SUNAT, .DO_USUARIO, .DO_TERMINAL, .DO_FECREG, .DO_IDEMPRESA.EM_ID, .DO_COD_CONTA)
            End With
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_DOCUMENTO", .DO_CODIGO, .DO_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Documentos(ByVal entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DOCUMENTO", entidad.DO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub get_Documentos_x_Cod(ByRef entidad As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DOCUMENTO_X_ID", entidad.DO_CODIGO, entidad.DO_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With entidad
                    .DO_DESCRIPCION = drr("DO_DESCRIPCION").ToString
                    .DO_ABREVIATURA = drr("DO_ABREVIATURA").ToString
                    .DO_ES_RESTA = drr("DO_ES_RESTA")
                    .DO_ISTATUS = drr("DO_ISTATUS")
                    .DO_CODIGO_SUNAT = drr("DO_CODIGO_SUNAT").ToString
                    .DO_COD_CONTA = drr("DO_COD_CONTA")
                    '.DO_CODIGO = drr("DO_CODIGO")
                    '.DO_IDEMPRESA = drr("DO_CODIGO")
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub

    End Class

    Public Class SG_FA_TB_PARAMETROS
        Inherits ClsBD

        Public Function get_Valor(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_VAL_PARA", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_IDEMPRESA.EM_ID)
        End Function

        Public Function get_Lista_Parametros(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PARAMETROS", empresa.EM_ID).Tables(0)
        End Function

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_VALOR, entidad.AD_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_VALOR, entidad.AD_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_IDEMPRESA.EM_ID)
        End Sub

    End Class

    Public Class SG_FA_TB_USU_PTOVTA
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_USU_PTOVTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_USU_PTOVTA", entidad.UP_IDUSARIO.US_ID, entidad.UP_IDPTO_VTA.PV_ID, entidad.UP_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_USU_PTOVTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_USU_PTOVTA", entidad.UP_IDUSARIO.US_ID, entidad.UP_IDPTO_VTA.PV_ID, entidad.UP_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_PtosVtas_x_Usuario(ByVal entidad As BE.FacturacionBE.SG_FA_TB_USU_PTOVTA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_USU_PTOVTA", entidad.UP_IDUSARIO.US_ID, entidad.UP_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_FORMA_PAGO
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_FORMA_PAGO", entidad.FP_ID, entidad.FP_DESCRIPCION, entidad.FP_ES_CREDITO, entidad.FP_DIAS_CREDITO, entidad.FP_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal entidad As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_FORMA_PAGO", entidad.FP_ID, entidad.FP_DESCRIPCION, entidad.FP_ES_CREDITO, entidad.FP_DIAS_CREDITO, entidad.FP_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_FORMA_PAGO", entidad.FP_ID, entidad.FP_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_FP(ByVal empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_FORMA_PAGO", empresa_.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_PTO_VTA_SERIE
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PTO_VTA_SERIE", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PS_SERIE, entidad.PC_IDEMPRESA.EM_ID, entidad.PS_TD.DO_CODIGO)
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_PTO_VTA_SERIE", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PS_SERIE, entidad.PC_IDEMPRESA.EM_ID, entidad.PS_TD.DO_CODIGO)
        End Sub

        Public Function get_Lista_Series(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PTO_VTA_SERIE", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_TD_X_PtoVta(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_TD_X_PTO_VTA", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Serie_x_TipDoc_x_PtoVta(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_SERIE_X_TD_X_PV", entidad.PS_IDPUNTOVTA.PV_ID, entidad.PS_TD.DO_CODIGO, entidad.PC_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_PUNTO_VENTA
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_PUNTO_VENTA", entidad.PV_ID, entidad.PV_DESCRIPCION, entidad.PV_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_PUNTO_VENTA", entidad.PV_ID, entidad.PV_DESCRIPCION, entidad.PV_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_PUNTO_VENTA", entidad.PV_ID, entidad.PV_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_PuntaVentas(ByVal empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PUNTO_VENTA", empresa_.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_NUM_COMPRO
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_NUM_COMPRO", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_NUMERO, entidad.NC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_NUM_COMPRO", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_NUMERO, entidad.NC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_NUM_COMPRO", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_Lista_Numeracion(ByVal empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_NUM_COMPRO", empresa_.EM_ID).Tables(0)
        End Function

        Public Function get_Series_xTD(ByVal entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_SERIES_XTD", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_NumCompro_xTD_SD(ByVal entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO) As String
            Dim ult_num As String = String.Empty
            ult_num = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUMCOMPRO_XTD_SD", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_IDEMPRESA.EM_ID)

            ult_num = (CInt(ult_num) + 1).ToString.PadLeft(7, "0")

            Return ult_num

        End Function
        Public Function get_NumCompro_xTD_SD2(ByVal entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO) As String
            Dim ult_num As String = String.Empty
            ult_num = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUMCOMPRO_XTD_SD", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_IDEMPRESA.EM_ID)

            ult_num = (CInt(ult_num) + 1).ToString.PadLeft(10, "0")

            Return ult_num

        End Function

        Public Function get_NumCompro_xTD_SD3(ByVal entidad As BE.FacturacionBE.SG_FA_TB_NUM_COMPRO) As String
            Dim ult_num As String = String.Empty
            ult_num = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUMCOMPRO_XTD_SD", entidad.NC_IDTIPO.DO_CODIGO, entidad.NC_SERIE, entidad.NC_IDEMPRESA.EM_ID)

            ult_num = (CInt(ult_num) + 1).ToString.PadLeft(11, "0")

            Return ult_num

        End Function
    End Class

    Public Class SG_FA_TB_FAMILIA_ARTI
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_FAMILIA_ARTI", Entidad.FA_CODIGO, Entidad.FA_DESCRIPCION, Entidad.FA_IDEMPRESA)
        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_FAMILIA_ARTI", Entidad.FA_CODIGO, Entidad.FA_DESCRIPCION, Entidad.FA_IDEMPRESA)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_FAMILIA_ARTI", Entidad.FA_CODIGO, Entidad.FA_IDEMPRESA)
        End Sub

        Public Function get_Familias(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_FAMILIA_ARTI", empresa_).Tables(0)
        End Function

        Public Function get_Familias_Combo(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_FAMILIA_ARTI_COMBO", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_CATEGORIA_ARTI
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_CATEGORIA_ARTI", Entidad.CA_CODIGO, Entidad.CA_DESCRIPCION, Entidad.CA_IDFAMILIA, Entidad.CA_IDEMPRESA)
        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_CATEGORIA_ARTI", Entidad.CA_CODIGO, Entidad.CA_DESCRIPCION, Entidad.CA_IDFAMILIA, Entidad.CA_IDEMPRESA)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CATEGORIA_ARTI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CATEGORIA_ARTI", Entidad.CA_CODIGO, Entidad.CA_IDEMPRESA)
        End Sub

        Public Function get_Categorias(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CATEGORIA_ARTI", empresa_).Tables(0)
        End Function

        Public Function get_Categorias_x_Familia(ByVal entidad As BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CATEGORIA_ARTI_X_FAMI", entidad.FA_IDEMPRESA, entidad.FA_CODIGO).Tables(0)
        End Function

    End Class

    Public Class SG_FA_TB_ARTICULO
        Inherits ClsBD

        Public Function Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO) As Integer
            Dim N As Integer = -1
            With Entidad
                N = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_ARTICULO_F", .AR_CODIGO, .AR_CODIGO_ALT, .AR_DESCRIPCION, .AR_PRECIO_VENTA, .AR_IDFAMILIA, .AR_IDCATEGORIA, .AR_NUM_CTA_CONTA, .AR_ESTADO, .AR_IDEMPRESA, .AR_USUARIO, .AR_TERMINAL, .AR_FECREG, .AR_TIPO_ARTI, .AR_INCLUYE_IGV, .AR_ING_RAP, .AR_MON_VTA, .AR_CTRL_STOCK, .AR_ORIGEN, .AR_FACTOR, .AR_UNIDAD)
            End With
            Return N
        End Function

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_ARTICULO_F", .AR_ID, .AR_CODIGO, .AR_CODIGO_ALT, .AR_DESCRIPCION, .AR_PRECIO_VENTA, .AR_IDFAMILIA, .AR_IDCATEGORIA, .AR_NUM_CTA_CONTA, .AR_ESTADO, .AR_IDEMPRESA, .AR_USUARIO, .AR_TERMINAL, .AR_FECREG, .AR_TIPO_ARTI, .AR_INCLUYE_IGV, .AR_ING_RAP, .AR_MON_VTA, .AR_CTRL_STOCK, .AR_ORIGEN, .AR_FACTOR, .AR_UNIDAD)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_ARTICULO", .AR_ID, .AR_IDEMPRESA)
            End With
        End Sub

        Public Function get_Articulos_FA(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_01_F", empresa_).Tables(0)
        End Function

        'Public Function get_Articulo(ByVal entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_X_ID", entidad.AR_CODIGO, entidad.AR_IDEMPRESA).Tables(0)
        'End Function

        Public Sub get_Articulo_x_Cod(ByRef entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_X_ID", entidad.AR_ID, entidad.AR_IDEMPRESA).Tables(0)

            If dt_tmp.Rows.Count > 0 Then
                With entidad
                    .AR_CODIGO = dt_tmp.Rows(0)("AR_CODIGO").ToString
                    .AR_CODIGO_ALT = dt_tmp(0)("AR_CODIGO_ALT").ToString
                    .AR_DESCRIPCION = dt_tmp(0)("AR_DESCRIPCION").ToString
                    .AR_PRECIO_VENTA = dt_tmp(0)("AR_PRECIO_VENTA")
                    .AR_IDFAMILIA = dt_tmp(0)("AR_IDFAMILIA").ToString
                    .AR_IDCATEGORIA = dt_tmp(0)("AR_IDCATEGORIA").ToString
                    .AR_NUM_CTA_CONTA = dt_tmp(0)("AR_NUM_CTA_CONTA").ToString
                    .AR_ESTADO = dt_tmp(0)("AR_ESTADO")
                    '.AR_IDEMPRESA = dt_tmp(0)("AR_IDEMPRESA")
                    .AR_TIPO_ARTI = dt_tmp(0)("AR_TIPO_ARTI").ToString
                    .AR_INCLUYE_IGV = dt_tmp(0)("AR_INCLUYE_IGV")
                    .AR_ING_RAP = dt_tmp(0)("AR_ING_RAP")
                End With
            End If

            dt_tmp.Dispose()

        End Sub

        Public Sub get_Articulo_IngRapido(ByRef entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_INGRAP", entidad.AR_IDEMPRESA).Tables(0)

            If dt_tmp.Rows.Count > 0 Then
                With entidad
                    .AR_ID = dt_tmp.Rows(0)("AR_ID").ToString
                    .AR_CODIGO = dt_tmp.Rows(0)("AR_CODIGO").ToString
                    .AR_CODIGO_ALT = dt_tmp(0)("AR_CODIGO_ALT").ToString
                    .AR_DESCRIPCION = dt_tmp(0)("AR_DESCRIPCION").ToString
                    .AR_PRECIO_VENTA = dt_tmp(0)("AR_PRECIO_VENTA")
                    .AR_IDFAMILIA = dt_tmp(0)("AR_IDFAMILIA").ToString
                    .AR_IDCATEGORIA = dt_tmp(0)("AR_IDCATEGORIA").ToString
                    .AR_NUM_CTA_CONTA = dt_tmp(0)("AR_NUM_CTA_CONTA").ToString
                    .AR_ESTADO = dt_tmp(0)("AR_ESTADO")
                    '.AR_IDEMPRESA = dt_tmp(0)("AR_IDEMPRESA")
                    .AR_TIPO_ARTI = dt_tmp(0)("AR_TIPO_ARTI").ToString
                    .AR_INCLUYE_IGV = dt_tmp(0)("AR_INCLUYE_IGV")
                    .AR_ING_RAP = dt_tmp(0)("AR_ING_RAP")
                End With
            End If

            dt_tmp.Dispose()

        End Sub

        Public Function get_Articulos_Ayuda(ByVal empresa_ As Integer, ByVal igv As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_01", empresa_, igv).Tables(0)
        End Function

        Public Function get_Articulos_Ayuda02(ByVal empresa_ As Integer, ByVal seguro As String, ByVal tipo As Integer, ByVal IGV As Double, ByVal Medico As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_02", empresa_, seguro, tipo, IGV, Medico).Tables(0)
        End Function

        Public Function get_Articulos_Ayuda03(ByVal empresa_ As Integer, ByVal seguro As String, ByVal tipo As Integer, ByVal IGV As Double, ByVal familia As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_03", empresa_, seguro, tipo, IGV, familia).Tables(0)
        End Function

        Public Function get_Articulos_Ayuda04(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_04", empresa_).Tables(0)
        End Function

        'x area'
        Public Function get_Articulos_Ayuda05(ByVal empresa_ As Integer, ByVal Almacen As String, ByVal Origen As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_05", empresa_, Almacen, Origen).Tables(0)
        End Function


        Public Sub get_Articulos_Ayuda03_XID(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO, ByVal seguro As String, ByVal tipo As Integer, ByVal IGV As Double)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_ARTICULO_X_ID_03", Entidad.AR_IDEMPRESA, seguro, tipo, IGV, Entidad.AR_IDFAMILIA, Entidad.AR_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .AR_CODIGO = drr("AR_CODIGO")
                    .AR_DESCRIPCION = drr("AR_DESCRIPCION")
                    .AR_PRECIO_VENTA = drr("AR_PRECIO_VENTA")
                End With
            End If

            drr.Close()

        End Sub

        Public Function get_Articulos_Cuent(ByVal empresa_ As Integer, ByVal Cliente As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO_CUENTA", empresa_, Cliente).Tables(0)
        End Function

        'Public Function Existe_Arti_Ingreso_Rap(ByVal entidad As BE.FacturacionBE.SG_FA_TB_ARTICULO) As Boolean
        '    Dim rpta As Boolean = False
        '    Dim num As Integer = 0

        '    num = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUM_ART_ING_RAP", entidad.AR_CODIGO, entidad.AR_IDEMPRESA)

        '    If num > 0 Then
        '        rpta = True
        '    End If

        '    Return rpta

        'End Function

        Public Function get_Codigo_Articulo_Nuevo(ByVal empresa_ As Integer, ByVal tipo_ As String) As String
            Dim respuesta As String = String.Empty

            Dim query As String = "SELECT MAX( CAST(SUBSTRING(AR_CODIGO,2,4) AS INT)) FROM SG_FA_TB_ARTICULO WHERE AR_TIPO_ARTI = '" & tipo_ & "' and AR_IDEMPRESA = " & empresa_.ToString
            Dim ult_codigo As String = SqlHelper.ExecuteScalar(Cn, CommandType.Text, query).ToString

            If ult_codigo.Length > 0 Then
                Dim ult_num As Integer = ult_codigo 'ult_codigo.Remove(0, 1)
                Dim letra_articulo As String = tipo_.ToUpper
                respuesta = letra_articulo & (ult_num + 1).ToString.PadLeft(4, "0")
            Else
                respuesta = tipo_ & "0001"
            End If

            Return respuesta

        End Function
        'Public Function get_ayuda_articulos_logistica(ByVal empresa As Integer) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ARTICULO3", empresa).Tables(0)
        'End Function
    End Class

    Public Class SG_FA_TB_CLIENTE
        Inherits ClsBD
        Public Function vERIcLI(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE) As Integer
            With Entidad
                If SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_CLIENTE_X_DOC", .CL_NDOC, .CL_IDEMPRESA.EM_ID) > 0 Then
                    Return 1
                Else
                    Return 0
                End If
            End With
        End Function
        Public Function InsertbOT(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE) As Integer

            With Entidad

                Dim IdCliente As Integer = 0

                IdCliente = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_CLIENTE", .CL_NOMBRE, .CL_TDOC.DI_CODIGO, .CL_NDOC, _
                                          .CL_DIRECCION, .CL_ES_RELACIONADO, .CL_USUARIO, _
                                          .CL_TERMINAL, .CL_FECREG, .CL_IDEMPRESA.EM_ID, .CL_ESTADO, .CL_FICHA_TEC, .CL_UBIGEO)

                'si tiene numero de documento lo registramos en contabilidad
                If .CL_NDOC.Length > 0 Then

                    Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                    anexoBE.AN_IDANEXO = 0
                    anexoBE.AN_DESCRIPCION = .CL_NOMBRE
                    anexoBE.AN_ES_RELACIONADO = .CL_ES_RELACIONADO
                    anexoBE.AN_IDEMPRESA = .CL_IDEMPRESA
                    anexoBE.AN_NUM_DOC = .CL_NDOC
                    anexoBE.AN_PC_FECREG = .CL_FECREG
                    anexoBE.AN_PC_TERMINAL = .CL_TERMINAL
                    anexoBE.AN_PC_USUARIO = .CL_USUARIO
                    anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    anexoBE.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = Entidad.CL_TDOC.DI_CODIGO}
                    anexoBE.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = BE.ContabilidadBE.TipoEmpresa.Natural}

                    anexoBL.Insert_x_Facturacion(anexoBE, IdCliente)

                    anexoBE = Nothing
                    anexoBL = Nothing

                End If
                Return IdCliente
            End With

        End Function

        Public Sub Insert(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE, ByVal ls_comunica As List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI))

            With Entidad
                If SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_CLIENTE_X_DOC", .CL_NDOC, .CL_IDEMPRESA.EM_ID) > 0 Then
                    Throw New Exception("El Cliente con numero de documento " & .CL_NDOC & " ya se encuentra registrado.")
                    Exit Sub
                End If

                Dim IdCliente As Integer = 0

                IdCliente = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_I_CLIENTE", .CL_NOMBRE, .CL_TDOC.DI_CODIGO, .CL_NDOC, _
                                          .CL_DIRECCION, .CL_ES_RELACIONADO, .CL_USUARIO, _
                                          .CL_TERMINAL, .CL_FECREG, .CL_IDEMPRESA.EM_ID, .CL_ESTADO, .CL_FICHA_TEC, .CL_UBIGEO)

                If Not ls_comunica Is Nothing Then
                    If ls_comunica.Count > 0 Then
                        Dim x As New SG_FA_TB_CLIENTE_COMUNI

                        'Borramos todo del cliente
                        x.Delete_all_xId(ls_comunica(0))

                        'Grabamos los telefonos,movil's, correos,etc
                        For Each item As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI In ls_comunica
                            item.CC_IDCLIENTE = IdCliente
                            x.Insert(item)
                        Next

                        x = Nothing
                    End If
                End If

                'si tiene numero de documento lo registramos en contabilidad
                If .CL_NDOC.Length > 0 Then

                    Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                    anexoBE.AN_IDANEXO = 0
                    anexoBE.AN_DESCRIPCION = .CL_NOMBRE
                    anexoBE.AN_ES_RELACIONADO = .CL_ES_RELACIONADO
                    anexoBE.AN_IDEMPRESA = .CL_IDEMPRESA
                    anexoBE.AN_NUM_DOC = .CL_NDOC
                    anexoBE.AN_PC_FECREG = .CL_FECREG
                    anexoBE.AN_PC_TERMINAL = .CL_TERMINAL
                    anexoBE.AN_PC_USUARIO = .CL_USUARIO
                    anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    anexoBE.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = Entidad.CL_TDOC.DI_CODIGO}
                    anexoBE.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = BE.ContabilidadBE.TipoEmpresa.Natural}

                    anexoBL.Insert_x_Facturacion(anexoBE, IdCliente)

                    anexoBE = Nothing
                    anexoBL = Nothing

                End If

            End With

        End Sub

        Public Sub Update(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE, ByVal ls_comunica As List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI))
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_CLIENTE", .CL_ID, .CL_NOMBRE, .CL_TDOC.DI_CODIGO, _
                                          .CL_NDOC, .CL_DIRECCION, .CL_ES_RELACIONADO, .CL_USUARIO, .CL_TERMINAL, _
                                          .CL_FECREG, .CL_IDEMPRESA.EM_ID, .CL_ESTADO, .CL_FICHA_TEC, .CL_UBIGEO)


                If ls_comunica.Count > 0 Then
                    Dim x As New SG_FA_TB_CLIENTE_COMUNI

                    'Borramos todo del cliente
                    x.Delete_all_xId(ls_comunica(0))

                    'Grabamos los telefonos,movil's, correos,etc
                    For Each item As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI In ls_comunica
                        x.Insert(item)
                    Next

                    x = Nothing
                End If


            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CLIENTE", .CL_ID, .CL_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Clientes(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CLIENTE", empresa_).Tables(0)
        End Function

        Public Sub get_Cliente_x_Id(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_CLIENTE_X_ID", Entidad.CL_ID, Entidad.CL_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CL_ID = drr("CL_ID")
                    .CL_NOMBRE = drr("CL_NOMBRE").ToString
                    .CL_TDOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = drr("CL_TDOC")}
                    .CL_NDOC = drr("CL_NDOC").ToString
                    .CL_DIRECCION = drr("CL_DIRECCION").ToString
                    .CL_ES_RELACIONADO = drr("CL_ES_RELACIONADO")
                    .CL_UBIGEO = drr("CL_UBIGEO")
                    .CL_FICHA_TEC = drr("CL_FICHA_TEC")
                    .CL_ESTADO = drr("CL_ESTADO")
                    .CL_IDANEX_CONTA = drr("CL_IDANEX_CONTA")
                End With
            End If

            drr.Close()

        End Sub

        Public Sub get_Cliente_x_Ruc(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_CLIENTE)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_CLIENTE_X_RUC", Entidad.CL_NDOC, Entidad.CL_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CL_ID = drr("CL_ID")
                    .CL_NOMBRE = drr("CL_NOMBRE").ToString
                    .CL_TDOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = drr("CL_TDOC")}
                    .CL_NDOC = drr("CL_NDOC").ToString
                    .CL_DIRECCION = drr("CL_DIRECCION").ToString
                    .CL_ES_RELACIONADO = drr("CL_ES_RELACIONADO")
                    .CL_UBIGEO = drr("CL_UBIGEO")
                    .CL_FICHA_TEC = drr("CL_FICHA_TEC")
                    .CL_ESTADO = drr("CL_ESTADO")
                End With
            End If

            drr.Close()

        End Sub


        Public Function get_Clientes_Ayuda(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CLI_AYUDA", empresa_).Tables(0)
        End Function

        Public Function get_Anexo_Boleta(ByVal empresa As Integer) As List(Of String)
            Dim query As String = "select CL_ID,CL_NDOC,CL_NOMBRE from SG_FA_TB_CLIENTE where CL_NDOC = '00000000001' and CL_IDEMPRESA = " & empresa.ToString
            Dim lista As New List(Of String)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, query)

            If drr.HasRows Then
                drr.Read()
                lista.Add(drr("CL_ID"))
                lista.Add(drr("CL_NDOC"))
                lista.Add(drr("CL_NOMBRE"))
            End If

            drr.Close()

            Return lista

        End Function

    End Class

    Public Class SG_FA_TB_COMPROBANTE_C
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByRef numVoucherConta As String, NC_ As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                Dim idCabecera As Integer = 0
                Dim cod_Doc_ref As String = String.Empty

                If Not Entidad.CO_TDOC_REF Is Nothing Then
                    cod_Doc_ref = Entidad.CO_TDOC_REF.DO_CODIGO
                End If

                With Entidad
                    idCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_COMPROBANTE_C", .CO_TDOC.DO_CODIGO, _
                                                  .CO_SDOC, .CO_NDOC, CDate(.CO_FEC_EMI).ToShortDateString, CDate(.CO_FEC_VEN).ToShortDateString, .CO_SUBTOTAL, _
                                                  .CO_SUBTOTAL_NA, .CO_IGV, .CO_TOTAL, .CO_IDMONEDA.MO_ID, _
                                                  .CO_TCAM, _
                                                  IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref), _
                                                  .CO_SDOC_REF, .CO_NDOC_REF, _
                                                  IIf(.CO_FEC_EMI_REF = String.Empty, DBNull.Value, .CO_FEC_EMI_REF), _
                                                  IIf(.CO_FEC_VEN_REF = String.Empty, DBNull.Value, .CO_FEC_VEN_REF), _
                                                  .CO_IDEMPRESA.EM_ID, .CO_USUARIO, _
                                                  .CO_TERMINAL, .CO_FECREG, .CO_IDCLIENTE.CL_ID, .CO_NOTAS, .CO_ESTADO, _
                                                  .CO_IDPTOVTA.PV_ID, .CO_IDFORMA_PAGO.FP_ID, .CO_ES_CONTA_PROVI, .CO_ES_CONTA_CANCE, _
                                                  .CO_IDUSUARIO.US_ID, .CO_IDDOCU_PAGO.DP_CODIGO, .CO_REF_PAGO, .CO_ES_REEMPLA, .CO_DNI, .CO_TASA_IGV, NC_)
                End With

                Entidad.CO_ID = idCabecera


                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_COMPROBANTE_D", Entidad.CO_ID)

                For Each deta_compro In Entidad.Detalles

                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPROBANTE_D", Entidad.CO_ID, .CD_ITEM, _
                                                  .CD_IDARTICULO.AR_ID, .CD_CANT, .CD_PRECIO, .CD_DSCTO, _
                                                  .CD_SUBTOTAL, .CD_INAFECTO, .CD_IDEMPRESA.EM_ID, .CD_IGV, .CD_TOTAL, .CD_INC_IGV)


                        '9694 - PROCEDIMIENTO DE OBTENCION,PREPARACION Y CULTIVO DE CELULAS MADRES DE TEJIDO ADIPOSO
                        'Grabamos la congelacion de celular en la tabla en el caso de Stencell
                        If .CD_IDARTICULO.AR_ID = 9694 Then
                            Dim idcongelacion As Integer = 0
                            Dim referencia As String = Entidad.CO_TDOC.DO_CODIGO + "-" + Entidad.CO_SDOC + "-" + Entidad.CO_NDOC
                            Dim mes1 As Integer = CDate(Entidad.CO_FEC_EMI).Month
                            Dim mes2 As Integer = IIf(mes1 = 12, 1, mes1 + 1)



                            'CABECERA***
                            idcongelacion = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_PAGO_CONGE_C", CDate(Entidad.CO_FEC_EMI).ToShortDateString, Entidad.CO_ID, _
                                                             Entidad.CO_IDCLIENTE.CL_ID, 9694, "030", Entidad.CO_NOTAS, _
                                                              Entidad.CO_TOTAL, 1, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, _
                                                             Entidad.CO_IDEMPRESA.EM_ID, referencia, Entidad.CO_IDMONEDA.MO_ID, Entidad.CO_TCAM)

                            'DETALLE***
                            '1er mante
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_PAGO_CONGE_D", idcongelacion, CDate(Entidad.CO_FEC_EMI).Year, mes1, _
                                                      CDate(Entidad.CO_FEC_EMI), 0, Entidad.CO_ID, 1, "1er MANTENIMIENTO CUBIERTO POR PAGO DE CONGELACION", _
                                                     Entidad.CO_IDMONEDA.MO_ID, Entidad.CO_TCAM, referencia)

                            '2do mante
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_PAGO_CONGE_D", idcongelacion, CDate(Entidad.CO_FEC_EMI).Year, mes2, _
                                                      CDate(Entidad.CO_FEC_EMI), 0, Entidad.CO_ID, 1, "2do MANTENIMIENTO CUBIERTO POR PAGO DE CONGELACION", _
                                                     Entidad.CO_IDMONEDA.MO_ID, Entidad.CO_TCAM, referencia)

                        End If


                    End With

                Next


                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = Entidad.CO_NDOC
                Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
                Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = Entidad.CO_TDOC
                numeracionBE.NC_SERIE = Entidad.CO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = Entidad.CO_IDEMPRESA
                numeracionBL.Update(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing




                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try



            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = Entidad.CO_IDEMPRESA
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "INTER"

            rpta = paraetrosBL.get_Valor(paraetrosBE)


            '_______________________________________________________________________________________________________
            '1 = grabar en conta
            '0 = no grabar en conta

            If rpta = "1" Then


                Dim cuenta12 As String = String.Empty
                Dim cuenta13 As String = String.Empty
                Dim cuenta40 As String = String.Empty

                'buscamos la cuentas contables para el asiento
                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "CTA12"
                cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

                paraetrosBE.AD_NOMBRE = "CTA13"
                cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

                If cuenta12 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                    Exit Sub
                End If

                paraetrosBE.AD_NOMBRE = "CTA40"
                cuenta40 = paraetrosBL.get_Valor(paraetrosBE)
                If cuenta40 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Impuesto' ")
                    Exit Sub
                End If



                '________________________________________________________________________'CuentasContales


                'Buscamos el codigo de Subdiario
                Dim idsubdiario As String = ""

                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "IDSUB"
                idsubdiario = paraetrosBL.get_Valor(paraetrosBE)

                If idsubdiario = String.Empty Then
                    MsgBox("No esta establecido el codigo de subdiario para el asiento contable")
                    Exit Sub
                End If

                '________________________________________________________________________subdiarios

                paraetrosBE = Nothing
                paraetrosBL = Nothing

                '______________________________________________Buscamos el tipo de cambio de conta para las operaciones en dolares

                '                Dim tipocambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
                '                Dim tipocambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO


                '                tipocambioBE.TC_FECHA = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                '                tipocambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "2"}
                '                tipocambioBE.TC_IDEMPRESA = Entidad.CO_IDEMPRESA

                'inicioTC:

                '                tipocambioBL.getTipoCambio(tipocambioBE)

                '                If tipocambioBE.TC_VENTA = 0 Then
                '                    tipocambioBE.TC_FECHA = CDate(tipocambioBE.TC_FECHA).AddDays(-1).ToShortDateString
                '                    GoTo inicioTC
                '                End If


                '                Entidad.CO_TCAM = tipocambioBE.TC_VENTA

                '                tipocambioBE = Nothing
                '                tipocambioBL = Nothing



                Dim IdAnexoCliente As Integer = 0
                Dim Descrp_Anexo_Cliente As String = String.Empty
                Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim E_Ventas As New BE.ContabilidadBE.SG_CO_TB_VENTAS
                Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
                Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


                'Buscamos el codigo de anexo(ID) 
                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                Entidad.CO_IDCLIENTE.CL_IDEMPRESA = Entidad.CO_IDEMPRESA
                clienteBL.get_Cliente_x_Id(Entidad.CO_IDCLIENTE)

                anexoBE.AN_IDEMPRESA = Entidad.CO_IDEMPRESA
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = Entidad.CO_IDCLIENTE.CL_NDOC
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexoCliente = anexoBE.AN_IDANEXO
                Descrp_Anexo_Cliente = anexoBE.AN_DESCRIPCION.ToString

                With E_Ventas
                    .VE_IDCAB = Nothing
                    .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .VE_ANEXO_ID = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .VE_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .VE_SER_DOC = Entidad.CO_SDOC
                    .VE_NUM_DOC = Entidad.CO_NDOC
                    .VE_INDICADOR_DESTINO = "01"
                    .VE_FEC_EMI = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .VE_FEC_VEN = CDate(Entidad.CO_FEC_VEN).ToShortDateString
                    .VE_FEC_VOU = CDate(Entidad.CO_FEC_EMI).ToShortDateString

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .VE_TIP_DOC_REF = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC_REF.DO_CODIGO_SUNAT}
                        .VE_SER_DOC_REF = Entidad.CO_SDOC_REF
                        .VE_NUM_DOC_REF = Entidad.CO_NDOC_REF
                        .VE_FEC_EMI_REF = Entidad.CO_FEC_EMI_REF
                    Else
                        .VE_TIP_DOC_REF = Nothing
                        .VE_SER_DOC_REF = String.Empty
                        .VE_NUM_DOC_REF = String.Empty
                        .VE_FEC_EMI_REF = String.Empty
                    End If

                    .VE_TASA_IGV = Entidad.CO_TASA_IGV
                    .VE_MONTO_IGV = Entidad.CO_IGV
                    .VE_VALOR_VENTA = Entidad.CO_SUBTOTAL
                    .VE_PRECIO_VENTA = Entidad.CO_TOTAL

                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .VE_MONTO_IGV = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        .VE_VALOR_VENTA = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                        .VE_PRECIO_VENTA = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                    End If


                    .VE_MONTO_EXONERADO = 0
                    .VE_TASA_ISC = 0
                    .VE_MONTO_ISC = 0
                    .VE_OTROS_TRIBUTOS = 0
                    .VE_VALOR_INAFECTO = 0
                    .VE_DESCUENTO = 0
                    .VE_VALOR_BRUTO = 0
                    .VE_ISTATUS = 1
                    .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}
                End With

                With E_Cabecera
                    .AC_ID = Entidad.CO_ID
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = idsubdiario}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = CDate(Entidad.CO_FEC_EMI).Year
                    .AC_MES = CDate(Entidad.CO_FEC_EMI).Month
                    .AC_FEC_VOUCHER = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_HABER = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_TC_OPE = Entidad.CO_TCAM
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1

                    If Entidad.CO_TDOC.DO_CODIGO = "01" Then
                        .AC_GLOSA_VOU = Descrp_Anexo_Cliente
                    Else
                        .AC_GLOSA_VOU = Entidad.CO_NOTAS
                    End If

                    .AC_ES_INTERFACE = 0
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = Entidad.CO_USUARIO
                    .AC_TERMINAL = Entidad.CO_TERMINAL
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = Entidad.CO_IDEMPRESA
                End With



                'comenzamos con los detalles

                Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 1

                    If anexoBE.AN_ES_RELACIONADO = 1 Then
                        .AD_CUENTA = cuenta13
                    Else
                        .AD_CUENTA = cuenta12
                    End If


                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .AD_SDOC = Entidad.CO_SDOC
                    .AD_NDOC = Entidad.CO_NDOC
                    .AD_FDOC = Entidad.CO_FEC_EMI
                    .AD_VDOC = Entidad.CO_FEC_VEN
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_HABER = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_DEBE = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_TOTAL

                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now

                End With
                Detalles.Add(E_Detalle)

                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 2
                    .AD_CUENTA = cuenta40
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_DEBE = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_HABER = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_IGV
                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now
                End With
                Detalles.Add(E_Detalle)


                'Aqui hay que darle vuelta al detalle para grabar los detalles de la 70


                Dim drr_Det As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DET_COMPROBAN", Entidad.CO_ID)
                Dim cta70 As String = String.Empty

                If drr_Det.HasRows Then

                    While drr_Det.Read
                        'Buscamos la cuenta 70 por el codigo del articulo

                        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                        Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

                        articuloBE.AR_ID = drr_Det("CD_IDARTICULO")
                        articuloBE.AR_IDEMPRESA = Entidad.CO_IDEMPRESA.EM_ID
                        articuloBL.get_Articulo_x_Cod(articuloBE)

                        cta70 = articuloBE.AR_NUM_CTA_CONTA
                        If cta70 = String.Empty Then
                            MsgBox("La cuenta 70 del articulo " & articuloBE.AR_ID & "-" & articuloBE.AR_DESCRIPCION & " no esta establecida.")
                            cta70 = "701001"
                        End If


                        articuloBE = Nothing
                        articuloBL = Nothing


                        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                        With E_Detalle
                            .AD_IDCAB = E_Cabecera
                            .AD_SECUENCIA = Detalles.Count + 1
                            .AD_CUENTA = cta70
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing
                            .AD_TDOC = Nothing
                            .AD_SDOC = String.Empty
                            .AD_NDOC = String.Empty
                            .AD_FDOC = String.Empty
                            .AD_VDOC = String.Empty
                            .AD_HABER = 0
                            .AD_DEBE = 0


                            If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                                .AD_DEBE = drr_Det("CD_SUBTOTAL")
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_DEBE = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                End If
                            Else
                                .AD_HABER = drr_Det("CD_SUBTOTAL")
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_HABER = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                End If
                            End If


                            .AD_MONTO_ORI = Math.Abs(drr_Det("CD_SUBTOTAL"))
                            .AD_TCAM = 0
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_TCAM = Entidad.CO_TCAM
                            End If

                            .AD_PORCE_DESTINO = 0
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = Entidad.CO_NOTAS
                            .AD_IDCC = Nothing
                            .AD_ES_DESTINO = 0
                            .AD_USUARIO = Entidad.CO_USUARIO
                            .AD_TERMINAL = Entidad.CO_TERMINAL
                            .AD_FECREG = Date.Now
                        End With
                        Detalles.Add(E_Detalle)

                    End While
                End If



                drr_Det.Close()
                drr_Det = Nothing

                Dim StrVoucher As String = String.Empty
                Try
                    AsientoBL.Insert_Ventas(E_Cabecera, E_Ventas, Detalles, StrVoucher, False, False)
                    numVoucherConta = StrVoucher
                    'actualizamos la cabecera del comprobante
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_EST_CAB_COMPRO", E_Cabecera.AC_ID, StrVoucher, 1, Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
                Catch ex As Exception
                    Throw New Exception("Error al intentar grabar en contabilidad.")
                End Try
            End If
        End Sub

        Public Sub Insert_Caja(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByRef numVoucherConta As String, ByVal NC As Integer, ByVal idCuentaFer As Integer, ByVal idComprobanteRef As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                Dim idCabecera As Integer = 0
                Dim cod_Doc_ref As String = String.Empty

                If Not Entidad.CO_TDOC_REF Is Nothing Then
                    cod_Doc_ref = Entidad.CO_TDOC_REF.DO_CODIGO
                End If

                With Entidad
                    idCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_COMPROBANTE_C_Caja", .CO_TDOC.DO_CODIGO, .CO_SDOC, .CO_NDOC, _
                                                  CDate(.CO_FEC_EMI).ToShortDateString, CDate(.CO_FEC_VEN).ToShortDateString, .CO_SUBTOTAL, _
                                                  .CO_SUBTOTAL_NA, .CO_IGV, .CO_TOTAL, .CO_IDMONEDA.MO_ID, .CO_TCAM, _
                                                  IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref), .CO_SDOC_REF, .CO_NDOC_REF, _
                                                  IIf(.CO_FEC_EMI_REF = String.Empty, DBNull.Value, .CO_FEC_EMI_REF), _
                                                  IIf(.CO_FEC_VEN_REF = String.Empty, DBNull.Value, .CO_FEC_VEN_REF), _
                                                  .CO_IDEMPRESA.EM_ID, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_IDCLIENTE.CL_ID, .CO_NOTAS, .CO_ESTADO, _
                                                  .CO_IDPTOVTA.PV_ID, .CO_IDFORMA_PAGO.FP_ID, .CO_ES_CONTA_PROVI, .CO_ES_CONTA_CANCE, .CO_IDUSUARIO.US_ID, _
                                                  .CO_IDDOCU_PAGO.DP_CODIGO, .CO_REF_PAGO, .CO_ES_REEMPLA, .CO_DNI, .CO_TASA_IGV, .CO_NUM_HIST, .CO_MEDICO, _
                                                  .CO_DESTINO, .CO_IDTIPO_ORI, .CO_SERIET, .CO_NUMEROT, NC, .CO_GLOSA_D)
                End With

                Entidad.CO_ID = idCabecera


                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_COMPROBANTE_D", Entidad.CO_ID)


                For Each deta_compro In Entidad.Detalles

                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPROBANTE_D_Caja", Entidad.CO_ID, .CD_ITEM, _
                                                  .CD_IDARTICULO.AR_ID, .CD_CANT, .CD_PRECIO, .CD_DSCTO, _
                                                  .CD_SUBTOTAL, .CD_INAFECTO, .CD_IDEMPRESA.EM_ID, .CD_IGV, .CD_TOTAL, .CD_INC_IGV, .CD_IDCUENTA, .CD_CUENTA_ITEM, .CD_DSCTO_OTRO)

                        SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_LO_TB_CONSUMO_C set CM_ESTADO_DOC=3 where CM_ESTADO =1 and CM_IDCUENTA =" & .CD_IDCUENTA)

                        'grabar mantenimientos a Fertilidad y nota de credito eliminar referencia
                        If .CD_IDARTICULO.AR_ID = "392" Or .CD_IDARTICULO.AR_ID = "394" Or .CD_IDARTICULO.AR_ID = "399" Then
                            If Entidad.CO_TDOC.DO_CODIGO = "07" Then
                                SqlHelper.ExecuteNonQuery(TRvar, "Fertilidad_EliminarPagoNC", idComprobanteRef, .CD_CANT, Entidad.CO_ID)
                            Else
                                If idCuentaFer > 0 Then
                                    SqlHelper.ExecuteNonQuery(TRvar, "Fertilidad_GRABAR_DETALLECUENTA", idCuentaFer, .CD_CANT, .CD_IDARTICULO.AR_ID, .CD_TOTAL, Entidad.CO_SDOC + "-" + Entidad.CO_NDOC, Entidad.CO_ID)
                                End If
                            End If
                        End If


                    End With


                Next


                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = Entidad.CO_NDOC
                Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
                Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = Entidad.CO_TDOC
                numeracionBE.NC_SERIE = Entidad.CO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = Entidad.CO_IDEMPRESA
                numeracionBL.Update(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing


                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try





            'aqui preguntamos si es una venta a StemCell para hacer el asiento de compras automatico.
            If (Entidad.CO_TDOC.DO_CODIGO = "01" Or Entidad.CO_TDOC.DO_CODIGO = "07") And Entidad.CO_IDCLIENTE.CL_NDOC = "20600107365" Then

                Dim TRvarConta As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

                Try



                    Dim bol_nc As Boolean = IIf(Entidad.CO_TDOC.DO_CODIGO = "01", False, True)
                    Dim Str_NumVoucher_compra As String = String.Empty
                    Dim IDCompra As Integer = 0

                    Dim idsubdiario_compra As String = "01" 'compras
                    Dim empresa As Integer = 8
                    Dim ayo As Integer = CDate(Entidad.CO_FEC_EMI).Year
                    Dim mes As Integer = CDate(Entidad.CO_FEC_EMI).Month
                    Dim glosa As String = Entidad.CO_NOTAS
                    Dim moneda As String = IIf(Entidad.CO_IDMONEDA.MO_ID = "01", "1", "2")
                    Dim Int_TipoAnex As Integer = 1 'CLIENTE
                    Dim Int_CodAnex As Integer = 0 'codigo de anexo
                    Dim Str_DesAnex As String = "" 'Descripcion de anexo
                    Dim Int_es_relacionado As Integer = 1 'si es relacionado


                    Dim Str_TDoc As String = String.Empty 'tipo de doc
                    Dim Str_TDocRef As String = String.Empty 'tipo de doc ref
                    'buscamos el cod. conta del doc. del comprobante
                    Str_TDoc = SqlHelper.ExecuteScalar(TRvarConta, CommandType.Text, "SELECT ISNULL(DO_CODIGO_SUNAT,0) FROM SG_FA_TB_DOCUMENTO WHERE DO_IDEMPRESA = 8 AND DO_CODIGO = '" & Entidad.CO_TDOC.DO_CODIGO & "'")
                    If Entidad.CO_TDOC.DO_CODIGO = "07" Then
                        Str_TDocRef = SqlHelper.ExecuteScalar(TRvarConta, CommandType.Text, "SELECT ISNULL(DO_CODIGO_SUNAT,0) FROM SG_FA_TB_DOCUMENTO WHERE DO_IDEMPRESA = 8 AND DO_CODIGO = '" & Entidad.CO_TDOC_REF.DO_CODIGO & "'")
                    End If





                    'Obtenemos ultimo numero de voucher de compras
                    Str_NumVoucher_compra = SqlHelper.ExecuteScalar(TRvarConta, "SG_CO_SP_C_ULT_NUM_VOU", ayo, mes, idsubdiario_compra, empresa)

                    'grabamos la cabecera del asiento contable
                    IDCompra = SqlHelper.ExecuteScalar(TRvarConta, "SG_CO_SP_I_ASIENTO_CAB", idsubdiario_compra, Str_NumVoucher_compra, ayo, mes, CDate(Entidad.CO_FEC_EMI).ToShortDateString, 1, Entidad.CO_TOTAL, Entidad.CO_TOTAL, Entidad.CO_TCAM, 0, 1, glosa, 1, 2, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Now, empresa)


                    Dim Int_TAnex As Integer = 2 'tipo de anexo - 2=proveedor 
                    Dim Int_CAnex As Integer = 39793 'codigo de anexo, debe ser el del proveedor clinica
                    Dim indicador As String = "01"
                    Entidad.CO_NDOC = Right("0000000000" & Entidad.CO_NDOC, 10)


                    Dim dbl_subtotal As Double = Math.Round(IIf(moneda = "1", Entidad.CO_SUBTOTAL, Entidad.CO_SUBTOTAL * Entidad.CO_TCAM), 2)
                    Dim dbl_igv As Double = Math.Round(IIf(moneda = "1", Entidad.CO_IGV, Entidad.CO_IGV * Entidad.CO_TCAM), 2)
                    Dim dbl_total As Double = Math.Round(IIf(moneda = "1", Entidad.CO_TOTAL, Entidad.CO_TOTAL * Entidad.CO_TCAM), 2)
                    Dim dbl_tc As Double = IIf(moneda = "1", 0, Entidad.CO_TCAM)
                    Dim bol_sol As Boolean = IIf(moneda = "1", True, False)

                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_COMPRAS", IDCompra, Int_TAnex, Int_CAnex, Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, indicador, _
                                            Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_FEC_EMI, DBNull.Value, "", "", DBNull.Value, Entidad.CO_TASA_IGV, _
                                            dbl_igv, 0, 0, 0, 0, dbl_subtotal, dbl_total, 0, 0, 0, 0, String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, 0, 0, 1, dbl_total, 0, 0, 0, 0)


                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, 1, "632101", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                DBNull.Value, DBNull.Value, IIf(bol_nc, 0, dbl_subtotal), IIf(bol_nc, dbl_subtotal, 0), dbl_tc, 0, glosa, _
                                                DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, IIf(bol_sol, dbl_subtotal, Entidad.CO_SUBTOTAL), 0, 0)


                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, 2, "913012", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                DBNull.Value, DBNull.Value, IIf(bol_nc, 0, dbl_subtotal), IIf(bol_nc, dbl_subtotal, 0), dbl_tc, 1, glosa, _
                                                DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, IIf(bol_sol, dbl_subtotal, Entidad.CO_SUBTOTAL), 100, 0)

                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, 3, "791101", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                DBNull.Value, DBNull.Value, IIf(bol_nc, dbl_subtotal, 0), IIf(bol_nc, 0, dbl_subtotal), dbl_tc, 1, glosa, _
                                                DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, IIf(bol_sol, dbl_subtotal, Entidad.CO_SUBTOTAL), 100, 0)

                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, 4, "401111", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                DBNull.Value, DBNull.Value, IIf(bol_nc, 0, dbl_igv), IIf(bol_nc, dbl_igv, 0), dbl_tc, 0, glosa, _
                                                DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, IIf(bol_sol, dbl_igv, Entidad.CO_IGV), 0, 0)

                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, 5, "431251", Int_TAnex, Int_CAnex, Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, _
                                               Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, IIf(bol_nc, dbl_total, 0), IIf(bol_nc, 0, dbl_total), dbl_tc, 0, glosa, _
                                               DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, IIf(bol_sol, dbl_total, Entidad.CO_TOTAL), 0, 0)


                    'actualizamos el correlativo del numero de voucher en su tabla
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_U_ACT_NUMVOUCHER", ayo, mes, idsubdiario_compra, Str_NumVoucher_compra, empresa)

                    'actualizamos el id voucher de conta en la tabla de comprobantes
                    'queryyy = "UPDATE SG_LO_TB_COMPROBANTES_CAB SET CO_IDVOUCHER = " & IDCompra & ", ' WHERE CO_ID = " & idCabecera
                    'SqlHelper.ExecuteNonQuery(TRvarConta, CommandType.Text, queryyy) '    ayo, mes, idsubdiario, numVoucherConta, empresa)

                    'MARCAMOS EL REGISTRO DE VENTA COMO PROCESADO          
                    'SqlHelper.ExecuteNonQuery(TRvarConta, CommandType.Text, "UPDATE SG_CO_TB_VENTAS SET VE_ES_CONTA = 1 WHERE  VE_IDCAB = " & IDVenta)

                    TRvarConta.Commit()
                    TRvarConta.Dispose()

                Catch ex As Exception
                    TRvarConta.Rollback()
                    Throw New Exception("Error al grabar asiento de COMPRAS")
                End Try
            End If










            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = Entidad.CO_IDEMPRESA
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "INTER"

            rpta = paraetrosBL.get_Valor(paraetrosBE)


            '_______________________________________________________________________________________________________
            '1 = grabar en conta
            '0 = no grabar en conta

            If rpta = "1" Then


                Dim cuenta12 As String = String.Empty
                Dim cuenta13 As String = String.Empty
                Dim cuenta40 As String = String.Empty

                'buscamos la cuentas contables para el asiento
                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "CTA12"
                cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

                paraetrosBE.AD_NOMBRE = "CTA13"
                cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

                If cuenta12 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                    Exit Sub
                End If

                paraetrosBE.AD_NOMBRE = "CTA40"
                cuenta40 = paraetrosBL.get_Valor(paraetrosBE)
                If cuenta40 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Impuesto' ")
                    Exit Sub
                End If



                '________________________________________________________________________'CuentasContales


                'Buscamos el codigo de Subdiario
                Dim idsubdiario As String = ""

                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "IDSUB"
                idsubdiario = paraetrosBL.get_Valor(paraetrosBE)

                If idsubdiario = String.Empty Then
                    MsgBox("No esta establecido el codigo de subdiario para el asiento contable")
                    Exit Sub
                End If

                '________________________________________________________________________subdiarios

                paraetrosBE = Nothing
                paraetrosBL = Nothing


                '______________________________________________Buscamos el tipo de cambio de conta para las operaciones en dolares

                '                Dim tipocambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
                '                Dim tipocambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO


                '                tipocambioBE.TC_FECHA = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                '                tipocambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "2"}
                '                tipocambioBE.TC_IDEMPRESA = Entidad.CO_IDEMPRESA

                'inicioTC:

                '                tipocambioBL.getTipoCambio(tipocambioBE)

                '                If tipocambioBE.TC_VENTA = 0 Then
                '                    tipocambioBE.TC_FECHA = CDate(tipocambioBE.TC_FECHA).AddDays(-1).ToShortDateString
                '                    GoTo inicioTC
                '                End If


                '                Entidad.CO_TCAM = tipocambioBE.TC_VENTA

                '                tipocambioBE = Nothing
                '                tipocambioBL = Nothing



                Dim IdAnexoCliente As Integer = 0
                Dim Descrp_Anexo_Cliente As String = String.Empty
                Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim E_Ventas As New BE.ContabilidadBE.SG_CO_TB_VENTAS
                Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
                Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


                'Buscamos el codigo de anexo(ID) 
                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                Entidad.CO_IDCLIENTE.CL_IDEMPRESA = Entidad.CO_IDEMPRESA
                clienteBL.get_Cliente_x_Id(Entidad.CO_IDCLIENTE)

                anexoBE.AN_IDEMPRESA = Entidad.CO_IDEMPRESA
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = Entidad.CO_IDCLIENTE.CL_NDOC
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexoCliente = anexoBE.AN_IDANEXO
                Descrp_Anexo_Cliente = anexoBE.AN_DESCRIPCION.ToString

                With E_Ventas
                    .VE_IDCAB = Nothing
                    .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .VE_ANEXO_ID = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .VE_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .VE_SER_DOC = Entidad.CO_SDOC
                    .VE_NUM_DOC = Entidad.CO_NDOC
                    .VE_INDICADOR_DESTINO = "01"
                    .VE_FEC_EMI = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .VE_FEC_VEN = CDate(Entidad.CO_FEC_VEN).ToShortDateString
                    .VE_FEC_VOU = CDate(Entidad.CO_FEC_EMI).ToShortDateString

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .VE_TIP_DOC_REF = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC_REF.DO_CODIGO_SUNAT}
                        .VE_SER_DOC_REF = Entidad.CO_SDOC_REF
                        .VE_NUM_DOC_REF = Entidad.CO_NDOC_REF
                        .VE_FEC_EMI_REF = Entidad.CO_FEC_EMI_REF
                    Else
                        .VE_TIP_DOC_REF = Nothing
                        .VE_SER_DOC_REF = String.Empty
                        .VE_NUM_DOC_REF = String.Empty
                        .VE_FEC_EMI_REF = String.Empty
                    End If

                    .VE_TASA_IGV = Entidad.CO_TASA_IGV
                    .VE_MONTO_IGV = Entidad.CO_IGV
                    .VE_VALOR_VENTA = Entidad.CO_SUBTOTAL
                    .VE_PRECIO_VENTA = Entidad.CO_TOTAL

                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .VE_MONTO_IGV = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        .VE_VALOR_VENTA = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                        .VE_PRECIO_VENTA = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                    End If


                    .VE_MONTO_EXONERADO = 0
                    .VE_TASA_ISC = 0
                    .VE_MONTO_ISC = 0
                    .VE_OTROS_TRIBUTOS = 0
                    .VE_VALOR_INAFECTO = 0
                    .VE_DESCUENTO = 0
                    .VE_VALOR_BRUTO = 0
                    .VE_ISTATUS = 1
                    .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}
                End With

                With E_Cabecera
                    .AC_ID = Entidad.CO_ID
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = idsubdiario}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = CDate(Entidad.CO_FEC_EMI).Year
                    .AC_MES = CDate(Entidad.CO_FEC_EMI).Month
                    .AC_FEC_VOUCHER = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_HABER = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_TC_OPE = Entidad.CO_TCAM
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1

                    If Entidad.CO_TDOC.DO_CODIGO = "01" Then
                        .AC_GLOSA_VOU = Descrp_Anexo_Cliente
                    Else
                        .AC_GLOSA_VOU = Entidad.CO_NOTAS
                    End If

                    .AC_ES_INTERFACE = 0
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = Entidad.CO_USUARIO
                    .AC_TERMINAL = Entidad.CO_TERMINAL
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = Entidad.CO_IDEMPRESA
                End With



                'comenzamos con los detalles

                Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 1

                    If anexoBE.AN_ES_RELACIONADO = 1 Then
                        .AD_CUENTA = cuenta13
                    Else
                        .AD_CUENTA = cuenta12
                    End If


                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .AD_SDOC = Entidad.CO_SDOC
                    .AD_NDOC = Entidad.CO_NDOC
                    .AD_FDOC = Entidad.CO_FEC_EMI
                    .AD_VDOC = Entidad.CO_FEC_VEN
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_HABER = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_DEBE = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_TOTAL

                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now

                End With
                Detalles.Add(E_Detalle)

                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 2
                    .AD_CUENTA = cuenta40
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_DEBE = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_HABER = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_IGV
                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now
                End With
                Detalles.Add(E_Detalle)


                'Aqui hay que darle vuelta al detalle para grabar los detalles de la 70

                Dim drr_Det As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DET_COMPROBAN", Entidad.CO_ID)
                Dim cta70 As String = String.Empty

                If drr_Det.HasRows Then
                    While drr_Det.Read
                        'Buscamos la cuenta 70 por el codigo del articulo

                        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                        Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

                        articuloBE.AR_ID = drr_Det("CD_IDARTICULO")
                        articuloBE.AR_IDEMPRESA = Entidad.CO_IDEMPRESA.EM_ID
                        articuloBL.get_Articulo_x_Cod(articuloBE)

                        cta70 = articuloBE.AR_NUM_CTA_CONTA

                        If cta70 = String.Empty Then
                            MsgBox("La cuenta 70 del articulo " & articuloBE.AR_ID & "-" & articuloBE.AR_DESCRIPCION & " no esta establecida.")
                            cta70 = "701001"
                        End If

                        articuloBE = Nothing
                        articuloBL = Nothing


                        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                        With E_Detalle
                            .AD_IDCAB = E_Cabecera
                            .AD_SECUENCIA = Detalles.Count + 1
                            .AD_CUENTA = cta70
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing
                            .AD_TDOC = Nothing
                            .AD_SDOC = String.Empty
                            .AD_NDOC = String.Empty
                            .AD_FDOC = String.Empty
                            .AD_VDOC = String.Empty
                            .AD_HABER = 0
                            .AD_DEBE = 0



                            If drr_Det("CD_IDARTICULO") = 214 Or drr_Det("CD_IDARTICULO") = 215 Then

                                If drr_Det("CD_IDARTICULO") = 214 Then
                                    'Ganancia
                                    .AD_HABER = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_HABER = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                    End If
                                Else
                                    'Perdida
                                    .AD_DEBE = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_DEBE = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                    End If
                                End If

                            Else

                                If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                                    .AD_DEBE = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_DEBE = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                Else
                                    .AD_HABER = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_HABER = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                End If
                            End If

                            .AD_MONTO_ORI = Math.Abs(drr_Det("CD_SUBTOTAL"))
                            .AD_TCAM = 0
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_TCAM = Entidad.CO_TCAM
                            End If

                            .AD_PORCE_DESTINO = 0
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = Entidad.CO_NOTAS
                            .AD_IDCC = Nothing
                            .AD_ES_DESTINO = 0
                            .AD_USUARIO = Entidad.CO_USUARIO
                            .AD_TERMINAL = Entidad.CO_TERMINAL
                            .AD_FECREG = Date.Now
                        End With
                        Detalles.Add(E_Detalle)


                        'asiento destino de la perdida cuenta 659909
                        If drr_Det("CD_IDARTICULO") = 215 Then

                            'cuenta 955022
                            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                            With E_Detalle
                                .AD_IDCAB = E_Cabecera
                                .AD_SECUENCIA = Detalles.Count + 1
                                .AD_CUENTA = "985022"
                                .AD_TANEXO = Nothing
                                .AD_IDANEXO = Nothing
                                .AD_TDOC = Nothing
                                .AD_SDOC = String.Empty
                                .AD_NDOC = String.Empty
                                .AD_FDOC = String.Empty
                                .AD_VDOC = String.Empty
                                .AD_DEBE = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_DEBE = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                End If
                                .AD_HABER = 0
                                .AD_MONTO_ORI = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                .AD_TCAM = 0
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_TCAM = Entidad.CO_TCAM
                                End If
                                .AD_PORCE_DESTINO = 0
                                .AD_SEC_ORI_DESTINO = 0
                                .AD_GLOSA = Entidad.CO_NOTAS
                                .AD_IDCC = Nothing
                                .AD_ES_DESTINO = 0
                                .AD_USUARIO = Entidad.CO_USUARIO
                                .AD_TERMINAL = Entidad.CO_TERMINAL
                                .AD_FECREG = Now
                            End With
                            Detalles.Add(E_Detalle)

                            'cuenta 791101
                            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                            With E_Detalle
                                .AD_IDCAB = E_Cabecera
                                .AD_SECUENCIA = Detalles.Count + 1
                                .AD_CUENTA = "791101"
                                .AD_TANEXO = Nothing
                                .AD_IDANEXO = Nothing
                                .AD_TDOC = Nothing
                                .AD_SDOC = String.Empty
                                .AD_NDOC = String.Empty
                                .AD_FDOC = String.Empty
                                .AD_VDOC = String.Empty
                                .AD_DEBE = 0
                                .AD_HABER = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_HABER = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                End If
                                .AD_MONTO_ORI = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                .AD_TCAM = 0
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_TCAM = Entidad.CO_TCAM
                                End If
                                .AD_PORCE_DESTINO = 0
                                .AD_SEC_ORI_DESTINO = 0
                                .AD_GLOSA = Entidad.CO_NOTAS
                                .AD_IDCC = Nothing
                                .AD_ES_DESTINO = 0
                                .AD_USUARIO = Entidad.CO_USUARIO
                                .AD_TERMINAL = Entidad.CO_TERMINAL
                                .AD_FECREG = Now
                            End With
                            Detalles.Add(E_Detalle)



                        End If

                    End While
                End If

                drr_Det.Close()
                drr_Det = Nothing

                Dim StrVoucher As String = String.Empty
                Try
                    AsientoBL.Insert_Ventas(E_Cabecera, E_Ventas, Detalles, StrVoucher, False, False)
                    numVoucherConta = StrVoucher
                    'actualizamos la cabecera del comprobante
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_EST_CAB_COMPRO", E_Cabecera.AC_ID, StrVoucher, 1, Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
                Catch ex As Exception
                    Throw New Exception("Error al intentar grabar en contabilidad.")
                End Try



            End If



        End Sub

        Public Sub Insert_Caja_Prestaciones(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByRef numVoucherConta As String, ByVal NC As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                Dim idCabecera As Integer = 0
                Dim cod_Doc_ref As String = String.Empty

                If Not Entidad.CO_TDOC_REF Is Nothing Then
                    cod_Doc_ref = Entidad.CO_TDOC_REF.DO_CODIGO
                End If

                With Entidad
                    idCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_COMPROBANTE_C_CAJAPRE", .CO_TDOC.DO_CODIGO, .CO_SDOC, .CO_NDOC, _
                                                  CDate(.CO_FEC_EMI).ToShortDateString, CDate(.CO_FEC_VEN).ToShortDateString, .CO_SUBTOTAL, _
                                                  .CO_SUBTOTAL_NA, .CO_IGV, .CO_TOTAL, .CO_IDMONEDA.MO_ID, .CO_TCAM, _
                                                  IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref), .CO_SDOC_REF, .CO_NDOC_REF, _
                                                  IIf(.CO_FEC_EMI_REF = String.Empty, DBNull.Value, .CO_FEC_EMI_REF), _
                                                  IIf(.CO_FEC_VEN_REF = String.Empty, DBNull.Value, .CO_FEC_VEN_REF), _
                                                  .CO_IDEMPRESA.EM_ID, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_IDCLIENTE.CL_ID, .CO_NOTAS, .CO_ESTADO, _
                                                  .CO_IDPTOVTA.PV_ID, .CO_IDFORMA_PAGO.FP_ID, .CO_ES_CONTA_PROVI, .CO_ES_CONTA_CANCE, .CO_IDUSUARIO.US_ID, _
                                                  .CO_IDDOCU_PAGO.DP_CODIGO, .CO_REF_PAGO, .CO_ES_REEMPLA, .CO_DNI, .CO_TASA_IGV, .CO_NUM_HIST, .CO_MEDICO, _
                                                  .CO_DESTINO, .CO_IDTIPO_ORI, .CO_SERIET, .CO_NUMEROT, NC)
                End With

                Entidad.CO_ID = idCabecera


                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_COMPROBANTE_D", Entidad.CO_ID)

                For Each deta_compro In Entidad.Detalles

                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPROBANTE_D_Caja", Entidad.CO_ID, .CD_ITEM, _
                                                  .CD_IDARTICULO.AR_ID, .CD_CANT, .CD_PRECIO, .CD_DSCTO, _
                                                  .CD_SUBTOTAL, .CD_INAFECTO, .CD_IDEMPRESA.EM_ID, .CD_IGV, .CD_TOTAL, .CD_INC_IGV, .CD_IDCUENTA, .CD_CUENTA_ITEM, .CD_DSCTO_OTRO)
                        SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_LO_TB_CONSUMO_C set CM_ESTADO_DOC=3 where CM_ESTADO =1 and CM_IDCUENTA =" & .CD_IDCUENTA)
                        If Entidad.CO_TDOC.DO_CODIGO <> "07" Then
                            SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_FA_TB_PRE_FACTURA_CAB set PF_FacTramite=1 where PF_IDCUENTA =" & .CD_IDCUENTA)
                        End If
                    End With

                Next


                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = Entidad.CO_NDOC
                Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
                Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = Entidad.CO_TDOC
                numeracionBE.NC_SERIE = Entidad.CO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = Entidad.CO_IDEMPRESA
                numeracionBL.Update(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing


                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try



            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = Entidad.CO_IDEMPRESA
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "INTER"

            rpta = paraetrosBL.get_Valor(paraetrosBE)


            '_______________________________________________________________________________________________________
            '1 = grabar en conta
            '0 = no grabar en conta

            If rpta = "1" Then


                Dim cuenta12 As String = String.Empty
                Dim cuenta13 As String = String.Empty
                Dim cuenta40 As String = String.Empty

                'buscamos la cuentas contables para el asiento
                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "CTA12"
                cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

                paraetrosBE.AD_NOMBRE = "CTA13"
                cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

                If cuenta12 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                    Exit Sub
                End If

                paraetrosBE.AD_NOMBRE = "CTA40"
                cuenta40 = paraetrosBL.get_Valor(paraetrosBE)
                If cuenta40 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Impuesto' ")
                    Exit Sub
                End If



                '________________________________________________________________________'CuentasContales


                'Buscamos el codigo de Subdiario
                Dim idsubdiario As String = ""

                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "IDSUB"
                idsubdiario = paraetrosBL.get_Valor(paraetrosBE)

                If idsubdiario = String.Empty Then
                    MsgBox("No esta establecido el codigo de subdiario para el asiento contable")
                    Exit Sub
                End If

                '________________________________________________________________________subdiarios

                paraetrosBE = Nothing
                paraetrosBL = Nothing


                '______________________________________________Buscamos el tipo de cambio de conta para las operaciones en dolares

                '                Dim tipocambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
                '                Dim tipocambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO


                '                tipocambioBE.TC_FECHA = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                '                tipocambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "2"}
                '                tipocambioBE.TC_IDEMPRESA = Entidad.CO_IDEMPRESA

                'inicioTC:

                '                tipocambioBL.getTipoCambio(tipocambioBE)

                '                If tipocambioBE.TC_VENTA = 0 Then
                '                    tipocambioBE.TC_FECHA = CDate(tipocambioBE.TC_FECHA).AddDays(-1).ToShortDateString
                '                    GoTo inicioTC
                '                End If


                '                Entidad.CO_TCAM = tipocambioBE.TC_VENTA

                '                tipocambioBE = Nothing
                '                tipocambioBL = Nothing



                Dim IdAnexoCliente As Integer = 0
                Dim Descrp_Anexo_Cliente As String = String.Empty
                Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim E_Ventas As New BE.ContabilidadBE.SG_CO_TB_VENTAS
                Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
                Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


                'Buscamos el codigo de anexo(ID) 
                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                Entidad.CO_IDCLIENTE.CL_IDEMPRESA = Entidad.CO_IDEMPRESA
                clienteBL.get_Cliente_x_Id(Entidad.CO_IDCLIENTE)

                anexoBE.AN_IDEMPRESA = Entidad.CO_IDEMPRESA
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = Entidad.CO_IDCLIENTE.CL_NDOC
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexoCliente = anexoBE.AN_IDANEXO
                Descrp_Anexo_Cliente = anexoBE.AN_DESCRIPCION.ToString

                With E_Ventas
                    .VE_IDCAB = Nothing
                    .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .VE_ANEXO_ID = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .VE_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .VE_SER_DOC = Entidad.CO_SDOC
                    .VE_NUM_DOC = Entidad.CO_NDOC
                    .VE_INDICADOR_DESTINO = "01"
                    .VE_FEC_EMI = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .VE_FEC_VEN = CDate(Entidad.CO_FEC_VEN).ToShortDateString
                    .VE_FEC_VOU = CDate(Entidad.CO_FEC_EMI).ToShortDateString

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .VE_TIP_DOC_REF = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC_REF.DO_CODIGO_SUNAT}
                        .VE_SER_DOC_REF = Entidad.CO_SDOC_REF
                        .VE_NUM_DOC_REF = Entidad.CO_NDOC_REF
                        .VE_FEC_EMI_REF = Entidad.CO_FEC_EMI_REF
                    Else
                        .VE_TIP_DOC_REF = Nothing
                        .VE_SER_DOC_REF = String.Empty
                        .VE_NUM_DOC_REF = String.Empty
                        .VE_FEC_EMI_REF = String.Empty
                    End If

                    .VE_TASA_IGV = Entidad.CO_TASA_IGV
                    .VE_MONTO_IGV = Entidad.CO_IGV
                    .VE_VALOR_VENTA = Entidad.CO_SUBTOTAL
                    .VE_PRECIO_VENTA = Entidad.CO_TOTAL

                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .VE_MONTO_IGV = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        .VE_VALOR_VENTA = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                        .VE_PRECIO_VENTA = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                    End If


                    .VE_MONTO_EXONERADO = 0
                    .VE_TASA_ISC = 0
                    .VE_MONTO_ISC = 0
                    .VE_OTROS_TRIBUTOS = 0
                    .VE_VALOR_INAFECTO = 0
                    .VE_DESCUENTO = 0
                    .VE_VALOR_BRUTO = 0
                    .VE_ISTATUS = 1
                    .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}
                End With

                With E_Cabecera
                    .AC_ID = Entidad.CO_ID
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = idsubdiario}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = CDate(Entidad.CO_FEC_EMI).Year
                    .AC_MES = CDate(Entidad.CO_FEC_EMI).Month
                    .AC_FEC_VOUCHER = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_HABER = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_TC_OPE = Entidad.CO_TCAM
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1

                    If Entidad.CO_TDOC.DO_CODIGO = "01" Then
                        .AC_GLOSA_VOU = Descrp_Anexo_Cliente
                    Else
                        .AC_GLOSA_VOU = Entidad.CO_NOTAS
                    End If

                    .AC_ES_INTERFACE = 0
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = Entidad.CO_USUARIO
                    .AC_TERMINAL = Entidad.CO_TERMINAL
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = Entidad.CO_IDEMPRESA
                End With



                'comenzamos con los detalles

                Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 1

                    If anexoBE.AN_ES_RELACIONADO = 1 Then
                        .AD_CUENTA = cuenta13
                    Else
                        .AD_CUENTA = cuenta12
                    End If


                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .AD_SDOC = Entidad.CO_SDOC
                    .AD_NDOC = Entidad.CO_NDOC
                    .AD_FDOC = Entidad.CO_FEC_EMI
                    .AD_VDOC = Entidad.CO_FEC_VEN
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_HABER = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_DEBE = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_TOTAL

                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now

                End With
                Detalles.Add(E_Detalle)

                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 2
                    .AD_CUENTA = cuenta40
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_DEBE = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_HABER = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_IGV
                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now
                End With
                Detalles.Add(E_Detalle)


                'Aqui hay que darle vuelta al detalle para grabar los detalles de la 70

                Dim drr_Det As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DET_COMPROBAN", Entidad.CO_ID)
                Dim cta70 As String = String.Empty

                If drr_Det.HasRows Then
                    While drr_Det.Read
                        'Buscamos la cuenta 70 por el codigo del articulo

                        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                        Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

                        articuloBE.AR_ID = drr_Det("CD_IDARTICULO")
                        articuloBE.AR_IDEMPRESA = Entidad.CO_IDEMPRESA.EM_ID
                        articuloBL.get_Articulo_x_Cod(articuloBE)

                        cta70 = articuloBE.AR_NUM_CTA_CONTA

                        If cta70 = String.Empty Then
                            MsgBox("La cuenta 70 del articulo " & articuloBE.AR_ID & "-" & articuloBE.AR_DESCRIPCION & " no esta establecida.")
                            cta70 = "701001"
                        End If

                        articuloBE = Nothing
                        articuloBL = Nothing


                        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                        With E_Detalle
                            .AD_IDCAB = E_Cabecera
                            .AD_SECUENCIA = Detalles.Count + 1
                            .AD_CUENTA = cta70
                            .AD_TANEXO = Nothing
                            .AD_IDANEXO = Nothing
                            .AD_TDOC = Nothing
                            .AD_SDOC = String.Empty
                            .AD_NDOC = String.Empty
                            .AD_FDOC = String.Empty
                            .AD_VDOC = String.Empty
                            .AD_HABER = 0
                            .AD_DEBE = 0



                            If drr_Det("CD_IDARTICULO") = 214 Or drr_Det("CD_IDARTICULO") = 215 Then

                                If drr_Det("CD_IDARTICULO") = 214 Then
                                    'Ganancia
                                    .AD_HABER = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_HABER = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                    End If
                                Else
                                    'Perdida
                                    .AD_DEBE = Math.Abs(drr_Det("CD_SUBTOTAL"))
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_DEBE = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                    End If
                                End If

                            Else

                                If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                                    .AD_DEBE = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_DEBE = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                Else
                                    .AD_HABER = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_HABER = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                End If
                            End If

                            .AD_MONTO_ORI = Math.Abs(drr_Det("CD_SUBTOTAL"))
                            .AD_TCAM = 0
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_TCAM = Entidad.CO_TCAM
                            End If

                            .AD_PORCE_DESTINO = 0
                            .AD_SEC_ORI_DESTINO = 0
                            .AD_GLOSA = Entidad.CO_NOTAS
                            .AD_IDCC = Nothing
                            .AD_ES_DESTINO = 0
                            .AD_USUARIO = Entidad.CO_USUARIO
                            .AD_TERMINAL = Entidad.CO_TERMINAL
                            .AD_FECREG = Date.Now
                        End With
                        Detalles.Add(E_Detalle)


                        'asiento destino de la perdida cuenta 659909
                        If drr_Det("CD_IDARTICULO") = 215 Then

                            'cuenta 955022
                            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                            With E_Detalle
                                .AD_IDCAB = E_Cabecera
                                .AD_SECUENCIA = Detalles.Count + 1
                                .AD_CUENTA = "985022"
                                .AD_TANEXO = Nothing
                                .AD_IDANEXO = Nothing
                                .AD_TDOC = Nothing
                                .AD_SDOC = String.Empty
                                .AD_NDOC = String.Empty
                                .AD_FDOC = String.Empty
                                .AD_VDOC = String.Empty
                                .AD_DEBE = drr_Det("CD_SUBTOTAL")
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_DEBE = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                End If
                                .AD_HABER = 0
                                .AD_MONTO_ORI = drr_Det("CD_SUBTOTAL")
                                .AD_TCAM = 0
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_TCAM = Entidad.CO_TCAM
                                End If
                                .AD_PORCE_DESTINO = 0
                                .AD_SEC_ORI_DESTINO = 0
                                .AD_GLOSA = Entidad.CO_NOTAS
                                .AD_IDCC = Nothing
                                .AD_ES_DESTINO = 0
                                .AD_USUARIO = Entidad.CO_USUARIO
                                .AD_TERMINAL = Entidad.CO_TERMINAL
                                .AD_FECREG = Now
                            End With
                            Detalles.Add(E_Detalle)

                            'cuenta 791101
                            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                            With E_Detalle
                                .AD_IDCAB = E_Cabecera
                                .AD_SECUENCIA = Detalles.Count + 1
                                .AD_CUENTA = "791101"
                                .AD_TANEXO = Nothing
                                .AD_IDANEXO = Nothing
                                .AD_TDOC = Nothing
                                .AD_SDOC = String.Empty
                                .AD_NDOC = String.Empty
                                .AD_FDOC = String.Empty
                                .AD_VDOC = String.Empty
                                .AD_DEBE = 0
                                .AD_HABER = drr_Det("CD_SUBTOTAL")
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_HABER = Math.Round(Math.Abs(drr_Det("CD_SUBTOTAL")) * Entidad.CO_TCAM, 2)
                                End If
                                .AD_MONTO_ORI = drr_Det("CD_SUBTOTAL")
                                .AD_TCAM = 0
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_TCAM = Entidad.CO_TCAM
                                End If
                                .AD_PORCE_DESTINO = 0
                                .AD_SEC_ORI_DESTINO = 0
                                .AD_GLOSA = Entidad.CO_NOTAS
                                .AD_IDCC = Nothing
                                .AD_ES_DESTINO = 0
                                .AD_USUARIO = Entidad.CO_USUARIO
                                .AD_TERMINAL = Entidad.CO_TERMINAL
                                .AD_FECREG = Now
                            End With
                            Detalles.Add(E_Detalle)



                        End If

                    End While
                End If

                drr_Det.Close()
                drr_Det = Nothing

                Dim StrVoucher As String = String.Empty
                Try
                    AsientoBL.Insert_Ventas(E_Cabecera, E_Ventas, Detalles, StrVoucher, False, False)
                    numVoucherConta = StrVoucher
                    'actualizamos la cabecera del comprobante
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_EST_CAB_COMPRO", E_Cabecera.AC_ID, StrVoucher, 1, Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
                Catch ex As Exception
                    Throw New Exception("Error al intentar grabar en contabilidad.")
                End Try

            End If

        End Sub

        Public Sub Insert_CajaBot(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByRef numVoucherConta As String, ByVal idCuenta As Integer, ByVal NC As Integer, ByVal IDALMACEN As String, str_cc_ As String)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim idCabecera As Integer = 0

            Try

                Dim cod_Doc_ref As String = String.Empty

                If Not Entidad.CO_TDOC_REF Is Nothing Then
                    cod_Doc_ref = Entidad.CO_TDOC_REF.DO_CODIGO
                End If

                With Entidad
                    idCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_COMPROBANTE_C_Botica", .CO_TDOC.DO_CODIGO, .CO_SDOC, .CO_NDOC, _
                                                  .CO_FEC_EMI, CDate(.CO_FEC_VEN).ToShortDateString, .CO_SUBTOTAL, _
                                                  .CO_SUBTOTAL_NA, .CO_IGV, .CO_TOTAL, .CO_IDMONEDA.MO_ID, .CO_TCAM, _
                                                  IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref), .CO_SDOC_REF, .CO_NDOC_REF, _
                                                  IIf(.CO_FEC_EMI_REF = String.Empty, DBNull.Value, .CO_FEC_EMI_REF), _
                                                  IIf(.CO_FEC_VEN_REF = String.Empty, DBNull.Value, .CO_FEC_VEN_REF), _
                                                  .CO_IDEMPRESA.EM_ID, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_IDCLIENTE.CL_ID, .CO_NOTAS, .CO_ESTADO, _
                                                  .CO_IDPTOVTA.PV_ID, .CO_IDFORMA_PAGO.FP_ID, .CO_ES_CONTA_PROVI, .CO_ES_CONTA_CANCE, .CO_IDUSUARIO.US_ID, _
                                                  .CO_IDDOCU_PAGO.DP_CODIGO, .CO_REF_PAGO, .CO_ES_REEMPLA, .CO_DNI, .CO_TASA_IGV, .CO_NUM_HIST, .CO_MEDICO, _
                                                  .CO_DESTINO, .CO_IDTIPO_ORI, .CO_SERIET, .CO_NUMEROT, NC, idCuenta, IDALMACEN, .CO_CENTCOS)
                End With

                Entidad.CO_ID = idCabecera

                For Each deta_compro In Entidad.Detalles

                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPROBANTE_D_Botica", Entidad.CO_ID, .CD_ITEM, _
                                                  .CD_IDARTICULO.AR_ID, .CD_CANT, .CD_PRECIO, .CD_DSCTO, _
                                                  .CD_SUBTOTAL, .CD_INAFECTO, .CD_IDEMPRESA.EM_ID, .CD_IGV, .CD_TOTAL, .CD_INC_IGV, .CD_IDCUENTA, .CD_CUENTA_ITEM, .CD_DSCTO_OTRO, .CD_LOTE)
                        SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_LO_TB_CONSUMO_C set CM_ESTADO_DOC=3 where CM_ESTADO =1 and CM_IDCUENTA =" & .CD_IDCUENTA)
                    End With

                Next

                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = Entidad.CO_NDOC
                Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
                Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = Entidad.CO_TDOC
                numeracionBE.NC_SERIE = Entidad.CO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = Entidad.CO_IDEMPRESA
                numeracionBL.Update(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try


            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim parametrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim parametrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            parametrosBE.AD_IDEMPRESA = Entidad.CO_IDEMPRESA
            parametrosBE.AD_TIPO = "CONTA"
            parametrosBE.AD_NOMBRE = "INTER"

            rpta = parametrosBL.get_Valor(parametrosBE)

            '_______________________________________________________________________________________________________
            If rpta = "1" Then '1 = grabar en conta             '0 = no grabar en conta

                Dim cuenta12 As String = String.Empty
                Dim cuenta13 As String = String.Empty
                Dim cuenta40 As String = String.Empty
                Dim cuenta70 As String = String.Empty
                Dim cuenta70R As String = String.Empty

                'buscamos la cuentas contables para el asiento
                parametrosBE.AD_TIPO = "CONTA"
                parametrosBE.AD_NOMBRE = "CTA12"
                cuenta12 = parametrosBL.get_Valor(parametrosBE)

                parametrosBE.AD_NOMBRE = "CTA13"
                cuenta13 = parametrosBL.get_Valor(parametrosBE)

                parametrosBE.AD_NOMBRE = "CTA70"
                cuenta70 = parametrosBL.get_Valor(parametrosBE)

                parametrosBE.AD_NOMBRE = "CTA70R"
                cuenta70R = parametrosBL.get_Valor(parametrosBE)

                If cuenta12 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                    Exit Sub
                End If

                parametrosBE.AD_NOMBRE = "CTA40"
                cuenta40 = parametrosBL.get_Valor(parametrosBE)
                If cuenta40 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Impuesto' ")
                    Exit Sub
                End If

                If cuenta70 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Venta 70' ")
                    Exit Sub
                End If

                If cuenta70R = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Venta 70 Relacionada' ")
                    Exit Sub
                End If

                '________________________________________________________________________'CuentasContales
                'Buscamos el codigo de Subdiario
                Dim idsubdiario As String = ""
                parametrosBE.AD_TIPO = "CONTA"
                parametrosBE.AD_NOMBRE = "SUBVE"
                idsubdiario = parametrosBL.get_Valor(parametrosBE)
                If idsubdiario = String.Empty Then
                    MsgBox("No esta establecido el codigo de subdiario para el asiento contable")
                    Exit Sub
                End If
                parametrosBE = Nothing
                parametrosBL = Nothing
                '________________________________________________________________________subdiarios


                Entidad.CO_SUBTOTAL = Math.Round(Entidad.CO_SUBTOTAL - Entidad.CO_SUBTOTAL_NA, 2)
                'grabamos ventas________________________________________________________

                If Cn.State = ConnectionState.Open Then Cn.Close()
                If Cn.State = ConnectionState.Closed Then Cn.Open()

                Dim TRvarConta As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

                Dim IDVenta As Integer = 0
                Dim empresa As Integer = 7
                Dim ayo As Integer = CDate(Entidad.CO_FEC_EMI).Year
                Dim mes As Integer = CDate(Entidad.CO_FEC_EMI).Month
                Dim glosa As String = Entidad.CO_NOTAS
                Dim moneda As String = "1"
                Dim Int_TipoAnex As Integer = 1 'CLIENTE
                Dim Int_CodAnex As Integer = 0 'codigo de anexo
                Dim Str_DesAnex As String = "" 'Descripcion de anexo
                Dim Int_es_relacionado As Integer = 0 'si es relacionado


                'cambiamos fecha corta para grabar en contabilidad
                Entidad.CO_FEC_EMI = CDate(Entidad.CO_FEC_EMI).ToShortDateString


                'buscamos el anexo contable 
                Int_CodAnex = SqlHelper.ExecuteScalar(TRvarConta, CommandType.Text, "SELECT ISNULL(CL_IDANEX_CONTA,0) FROM SG_FA_TB_CLIENTE WHERE CL_ID  =  " & Entidad.CO_IDCLIENTE.CL_ID.ToString)
                Str_DesAnex = SqlHelper.ExecuteScalar(TRvarConta, CommandType.Text, "SELECT ISNULL(CL_NOMBRE,'') FROM SG_FA_TB_CLIENTE WHERE CL_ID  =  " & Entidad.CO_IDCLIENTE.CL_ID.ToString)
                Int_es_relacionado = SqlHelper.ExecuteScalar(TRvarConta, CommandType.Text, "SELECT ISNULL(CL_ES_RELACIONADO,'') FROM SG_FA_TB_CLIENTE WHERE CL_ID  =  " & Entidad.CO_IDCLIENTE.CL_ID.ToString)

                If (Entidad.CO_TDOC.DO_CODIGO = "03" Or Entidad.CO_TDOC.DO_CODIGO = "07") And Entidad.CO_IDCLIENTE.CL_NDOC <> "20339979490" Then 'para boleta o nc q no sea para clinica
                    Int_CodAnex = 6064
                End If


                'Obtenemos ultimo numero de voucher de compras
                numVoucherConta = SqlHelper.ExecuteScalar(TRvarConta, "SG_CO_SP_C_ULT_NUM_VOU", ayo, mes, idsubdiario, empresa)

                'grabamos la cabecera del asiento contable
                IDVenta = SqlHelper.ExecuteScalar(TRvarConta, "SG_CO_SP_I_ASIENTO_CAB", idsubdiario, _
                                                  numVoucherConta, ayo, mes, Entidad.CO_FEC_EMI, _
                                                  moneda, Entidad.CO_TOTAL, Entidad.CO_TOTAL, Entidad.CO_TCAM, _
                                                  0, 1, Str_DesAnex & " " & glosa, 1, 2, Entidad.CO_USUARIO, _
                                                  Entidad.CO_TERMINAL, Now, empresa)


                Dim Str_TDoc As String = String.Empty 'tipo de doc
                Dim Str_TDocRef As String = String.Empty 'tipo de doc ref
                Dim indicador As String = "01"
                ' Dim monto_exone As Double = 0
                Dim tasa_isc As Double = 0
                Dim monto_isc As Double = 0
                Dim otros_tributos As Double = 0
                Dim valor_inafec As Double = 0
                Dim descto As Double = 0
                Dim estado As Integer = 1
                Dim idsubope As Integer = 6

                If Entidad.CO_SUBTOTAL_NA > 0 And Entidad.CO_IGV > 0 Then
                    indicador = "03"
                End If
                If Entidad.CO_SUBTOTAL_NA > 0 And Entidad.CO_IGV = 0 Then
                    indicador = "02"
                End If


                'If Entidad.CO_SUBTOTAL_NA > 0 Then
                '    indicador = "03" 'operaciones mixtas
                'End If


                'buscamos el cod. conta del doc. del comprobante
                Str_TDoc = SqlHelper.ExecuteScalar(TRvarConta, CommandType.Text, "SELECT ISNULL(DO_CODIGO_SUNAT,0) FROM SG_FA_TB_DOCUMENTO WHERE DO_IDEMPRESA = 7 AND DO_CODIGO = '" & Entidad.CO_TDOC.DO_CODIGO & "'")
                If Entidad.CO_TDOC.DO_CODIGO = "07" Then
                    Str_TDocRef = SqlHelper.ExecuteScalar(TRvarConta, CommandType.Text, "SELECT ISNULL(DO_CODIGO_SUNAT,0) FROM SG_FA_TB_DOCUMENTO WHERE DO_IDEMPRESA = 7 AND DO_CODIGO = '" & Entidad.CO_TDOC_REF.DO_CODIGO & "'")
                End If

                'grabamos cabecera de comprobante para "REG. DE VENTAS"
                SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_VENTAS", IDVenta, Int_TipoAnex, Int_CodAnex,
                                          Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, indicador, Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_FEC_EMI, _
                                          IIf(Str_TDocRef.Equals(String.Empty), DBNull.Value, Str_TDocRef), Entidad.CO_SDOC_REF, Entidad.CO_NDOC_REF, _
                                          IIf(Entidad.CO_FEC_EMI_REF.Equals(String.Empty), DBNull.Value, Entidad.CO_FEC_EMI_REF), _
                                          Entidad.CO_TASA_IGV, Entidad.CO_IGV, Entidad.CO_SUBTOTAL_NA, tasa_isc, monto_isc, _
                                          otros_tributos, valor_inafec, descto, IIf(indicador = "02", Entidad.CO_SUBTOTAL_NA, Entidad.CO_SUBTOTAL), Entidad.CO_TOTAL, Entidad.CO_TOTAL, estado, idsubope)


                'grabamos los detalles
                Dim items As Integer = 0
                Dim cuenta_Base As String = IIf(Int_es_relacionado = 1, cuenta70R, cuenta70)
                Dim cuenta_igv As String = cuenta40
                Dim cuenta_tot As String = IIf(Int_es_relacionado = 1, cuenta13, cuenta12)
                Dim tc_det As Double = 0 'Entidad.CO_TC
                Dim debe As Double = 0
                Dim haber As Double = 0

                If Entidad.CO_SUBTOTAL > 0 Then
                    '__1º la cuenta 70 base imponible
                    items += 1
                    debe = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", Entidad.CO_SUBTOTAL, 0)
                    haber = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", 0, Entidad.CO_SUBTOTAL)
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDVenta, _
                                              items, cuenta_Base, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                              debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                              Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL, 0, 0)

                End If


                '__2º la cuenta 40 igv
                items += 1
                debe = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", Entidad.CO_IGV, 0)
                haber = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", 0, Entidad.CO_IGV)
                SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDVenta, _
                                          items, cuenta_igv, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                          debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                          Entidad.CO_TERMINAL, Now, Entidad.CO_IGV, 0, 0)

                If Entidad.CO_SUBTOTAL_NA > 0 Then

                    '__1º la cuenta 70 base imponible no afecto IGV
                    items += 1
                    debe = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", Entidad.CO_SUBTOTAL_NA, 0)
                    haber = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", 0, Entidad.CO_SUBTOTAL_NA)
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDVenta, _
                                              items, cuenta_Base, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                              debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                              Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL_NA, 0, 1)

                End If

                '__3º la cuenta 12 total
                items += 1
                debe = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", 0, Entidad.CO_TOTAL)
                haber = IIf(Entidad.CO_TDOC.DO_CODIGO = "07", Entidad.CO_TOTAL, 0)
                SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDVenta, _
                                        items, cuenta_tot, Int_TipoAnex, Int_CodAnex, Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, _
                                        Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, debe, haber, tc_det, 0, _
                                        Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                        Entidad.CO_TERMINAL, Now, Entidad.CO_TOTAL, 0, 0)

                'actualizamos el correlativo del numero de voucher en su tabla
                SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_U_ACT_NUMVOUCHER", ayo, mes, idsubdiario, numVoucherConta, empresa)


                Dim queryyy As String = "UPDATE SG_FA_TB_COMPROBANTE_C SET CO_IDVOUCHER = " & IDVenta & ", CO_NUMVOUCHER = '" & numVoucherConta & "' WHERE CO_ID = " & idCabecera
                SqlHelper.ExecuteNonQuery(TRvarConta, CommandType.Text, queryyy) '    ayo, mes, idsubdiario, numVoucherConta, empresa)

                'TERMINO DE GRABAR EL ASIENTO DE VENTAS _______________________________________________________






                'aqui preguntamos si es una venta a clinica Miraflores para hacer el asiento de compras automatico.
                Entidad.CO_SDOC = "0" & Entidad.CO_SDOC
                If (Entidad.CO_TDOC.DO_CODIGO = "01" Or Entidad.CO_TDOC.DO_CODIGO = "07") And Entidad.CO_IDCLIENTE.CL_NDOC = "20339979490" Then

                    Dim bol_nc As Boolean = IIf(Entidad.CO_TDOC.DO_CODIGO = "01", False, True)
                    Dim Str_NumVoucher_compra As String
                    Dim IDCompra As Integer = 0
                    'Dim str_cc_ As String = "90" 'aqui va el dato del combo
                    Dim str_cta_cc As String = str_cc_ & "1001"

                    idsubdiario = "01" 'compras
                    empresa = 1 'clinica

                    Select Case str_cc_
                        Case 90
                            glosa = "POR COMPRA SUMINISTROS FERTILIDAD"
                        Case 91
                            glosa = "POR COMPRA SUMINISTROS GINECOLOGIA"
                        Case 92
                            glosa = "POR COMPRA SUMINISTROS OBSTETRICIA"
                        Case 93
                            glosa = "POR COMPRA SUMINISTROS CIRUGIA PLASTICA"
                        Case 94
                            glosa = "POR COMPRA SUMINISTROS CIRUGIA CARDIOVASCULAR"
                        Case 95
                            glosa = "POR COMPRA SUMINISTROS TRAUMATOLOGIA"
                        Case 96
                            glosa = "POR COMPRA SUMINISTROS NEONATOLOGIA"
                        Case 97
                            glosa = "POR COMPRA SUMINISTROS LABORATORIO / OTROS"
                        Case Else
                            glosa = "VARIOS CC"
                    End Select

                    'Obtenemos ultimo numero de voucher de compras
                    Str_NumVoucher_compra = SqlHelper.ExecuteScalar(TRvarConta, "SG_CO_SP_C_ULT_NUM_VOU", ayo, mes, idsubdiario, empresa)

                    'grabamos la cabecera del asiento contable
                    IDCompra = SqlHelper.ExecuteScalar(TRvarConta, "SG_CO_SP_I_ASIENTO_CAB", idsubdiario, _
                                                      Str_NumVoucher_compra, ayo, mes, Entidad.CO_FEC_EMI, _
                                                      moneda, Entidad.CO_TOTAL, Entidad.CO_TOTAL, Entidad.CO_TCAM, _
                                                      0, 1, glosa, 1, 2, "ROBOT-" & Entidad.CO_USUARIO, _
                                                      Entidad.CO_TERMINAL, Now, empresa)

                    Dim itemMas As Integer = 0
                    Dim Int_TAnex As Integer = 2 'tipo de anexo - 2=proveedor 
                    Dim Int_CAnex As Integer = 3216 'codigo de anexo, debe ser el del proveedor botica
                    '--  indicador = "01"
                    Entidad.CO_NDOC = Right(Entidad.CO_NDOC, 10)

                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_COMPRAS", IDCompra, Int_TAnex, Int_CAnex, _
                                                Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, indicador, _
                                                Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_FEC_EMI, _
                                                DBNull.Value, "", "", DBNull.Value, Entidad.CO_TASA_IGV, _
                                                Entidad.CO_IGV, Entidad.CO_SUBTOTAL_NA, 0, 0, 0, IIf(indicador = "02", Entidad.CO_SUBTOTAL_NA, Entidad.CO_SUBTOTAL), _
                                                Entidad.CO_TOTAL, 0, 0, 0, 0, String.Empty, DBNull.Value, _
                                                DBNull.Value, DBNull.Value, 0, 0, 1, Entidad.CO_TOTAL, 0, 0, 0, 0)


                    'Registramos las cuentas de la parte INAFECTA
                    If Entidad.CO_SUBTOTAL_NA > 0 Then

                        itemMas += 1
                        SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, "601101", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                    DBNull.Value, DBNull.Value, IIf(bol_nc, 0, Entidad.CO_SUBTOTAL_NA), IIf(bol_nc, Entidad.CO_SUBTOTAL_NA, 0), 0, 0, glosa, _
                                                    DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_SUBTOTAL_NA, 0, 0)
                        itemMas += 1
                        SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, str_cta_cc, DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                    DBNull.Value, DBNull.Value, IIf(bol_nc, 0, Entidad.CO_SUBTOTAL_NA), IIf(bol_nc, Entidad.CO_SUBTOTAL_NA, 0), 0, 1, glosa, _
                                                    DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_SUBTOTAL_NA, 100, 0)
                        itemMas += 1
                        SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, "791101", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                        DBNull.Value, DBNull.Value, IIf(bol_nc, Entidad.CO_SUBTOTAL_NA, 0), IIf(bol_nc, 0, Entidad.CO_SUBTOTAL_NA), 0, 1, glosa, _
                                                        DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_SUBTOTAL_NA, 100, 0)
                    End If

                    itemMas += 1
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, "601101", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                    DBNull.Value, DBNull.Value, IIf(bol_nc, 0, Entidad.CO_SUBTOTAL), IIf(bol_nc, Entidad.CO_SUBTOTAL, 0), 0, 0, glosa, _
                                                    DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_SUBTOTAL, 0, 0)

                    itemMas += 1
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, str_cta_cc, DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                    DBNull.Value, DBNull.Value, IIf(bol_nc, 0, Entidad.CO_SUBTOTAL), IIf(bol_nc, Entidad.CO_SUBTOTAL, 0), 0, 1, glosa, _
                                                    DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_SUBTOTAL, 100, 0)
                    itemMas += 1
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, "791101", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                    DBNull.Value, DBNull.Value, IIf(bol_nc, Entidad.CO_SUBTOTAL, 0), IIf(bol_nc, 0, Entidad.CO_SUBTOTAL), 0, 1, glosa, _
                                                    DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_SUBTOTAL, 100, 0)
                    itemMas += 1
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, "401112", DBNull.Value, DBNull.Value, DBNull.Value, "", "", _
                                                    DBNull.Value, DBNull.Value, IIf(bol_nc, 0, Entidad.CO_IGV), IIf(bol_nc, Entidad.CO_IGV, 0), 0, 0, glosa, _
                                                    DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_IGV, 0, 0)
                    itemMas += 1
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_I_ASIENTO_DET", IDCompra, itemMas, "431251", Int_TAnex, Int_CAnex, Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, _
                                                   Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, IIf(bol_nc, Entidad.CO_TOTAL, 0), IIf(bol_nc, 0, Entidad.CO_TOTAL), 0, 0, glosa, _
                                                    DBNull.Value, 0, Entidad.CO_USUARIO, Entidad.CO_TERMINAL, Entidad.CO_FECREG, Entidad.CO_TOTAL, 0, 0)


                    'actualizamos el correlativo del numero de voucher en su tabla
                    SqlHelper.ExecuteNonQuery(TRvarConta, "SG_CO_SP_U_ACT_NUMVOUCHER", ayo, mes, idsubdiario, Str_NumVoucher_compra, empresa)

                    'actualizamos el id voucher de conta en la tabla de comprobantes
                    'queryyy = "UPDATE SG_LO_TB_COMPROBANTES_CAB SET CO_IDVOUCHER = " & IDCompra & ", ' WHERE CO_ID = " & idCabecera
                    'SqlHelper.ExecuteNonQuery(TRvarConta, CommandType.Text, queryyy) '    ayo, mes, idsubdiario, numVoucherConta, empresa)

                    'MARCAMOS EL REGISTRO DE VENTA COMO PROCESADO          
                    SqlHelper.ExecuteNonQuery(TRvarConta, CommandType.Text, "UPDATE SG_CO_TB_VENTAS SET VE_ES_CONTA = 1 WHERE  VE_IDCAB = " & IDVenta)

                    Dim queryyyy As String = "UPDATE SG_FA_TB_COMPROBANTE_C SET CO_IDVOUCHERCOM = " & IDCompra & " WHERE CO_ID = " & idCabecera
                    SqlHelper.ExecuteNonQuery(TRvarConta, CommandType.Text, queryyyy) '    ayo, mes, idsubdiario, numVoucherConta, empresa)

                End If

                'SG_CO_SP_O_FTS_BOT_A_CLI


                TRvarConta.Commit()
                TRvarConta.Dispose()

            End If
        End Sub

        Public Sub Insert_CajaPac(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByRef numVoucherConta As String, ByVal tramiento As Integer, ByVal CuentaCont As String, ByVal NC As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                Dim idCabecera As Integer = 0
                Dim cod_Doc_ref As String = String.Empty

                If Not Entidad.CO_TDOC_REF Is Nothing Then
                    cod_Doc_ref = Entidad.CO_TDOC_REF.DO_CODIGO
                End If

                With Entidad
                    idCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_COMPROBANTE_C_CAJAPAC", .CO_TDOC.DO_CODIGO, _
                                                  .CO_SDOC, .CO_NDOC, CDate(.CO_FEC_EMI).ToShortDateString, CDate(.CO_FEC_VEN).ToShortDateString, .CO_SUBTOTAL, _
                                                  .CO_SUBTOTAL_NA, .CO_IGV, .CO_TOTAL, .CO_IDMONEDA.MO_ID, .CO_TCAM, _
                                                  IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref), _
                                                  .CO_SDOC_REF, .CO_NDOC_REF, _
                                                  IIf(.CO_FEC_EMI_REF = String.Empty, DBNull.Value, .CO_FEC_EMI_REF), _
                                                  IIf(.CO_FEC_VEN_REF = String.Empty, DBNull.Value, .CO_FEC_VEN_REF), _
                                                  .CO_IDEMPRESA.EM_ID, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_IDCLIENTE.CL_ID, .CO_NOTAS, .CO_ESTADO, _
                                                  .CO_IDPTOVTA.PV_ID, .CO_IDFORMA_PAGO.FP_ID, .CO_ES_CONTA_PROVI, .CO_ES_CONTA_CANCE, _
                                                  .CO_IDUSUARIO.US_ID, .CO_IDDOCU_PAGO.DP_CODIGO, .CO_REF_PAGO, .CO_ES_REEMPLA, .CO_DNI, _
                                                  .CO_TASA_IGV, .CO_NUM_HIST, .CO_MEDICO, .CO_DESTINO, .CO_IDTIPO_ORI, .CO_SERIET, .CO_NUMEROT, NC, 2)
                End With

                Entidad.CO_ID = idCabecera

                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_COMPROBANTE_D", Entidad.CO_ID)

                For Each deta_compro In Entidad.Detalles

                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPROBANTE_D_CAJAPAC", Entidad.CO_ID, .CD_ITEM, _
                                                  .CD_IDARTICULO.AR_ID, .CD_CANT, .CD_PRECIO, .CD_DSCTO, _
                                                  .CD_SUBTOTAL, .CD_INAFECTO, .CD_IDEMPRESA.EM_ID, .CD_IGV, _
                                                  .CD_TOTAL, .CD_INC_IGV, .CD_IDCUENTA, .CD_CUENTA_ITEM, .CD_DSCTO_OTRO, .CD_IDCOMPRO_ADELA)
                        SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_LO_TB_CONSUMO_C set CM_ESTADO_DOC=3 where CM_ESTADO =1 and CM_IDCUENTA =" & .CD_IDCUENTA)
                        If Entidad.CO_TDOC.DO_CODIGO <> "07" Then
                            SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_FA_TB_PRE_FACTURA_CAB set PF_FacTramite=1 where PF_IDCUENTA =" & .CD_IDCUENTA)
                        End If
                    End With

                Next

                '--  SqlHelper.ExecuteNonQuery(TRvar, "update SG_LO_TB_CONSUMO_C set CM_ESTADO_DOC=3 where CM_ESTADO =1 and CM_IDCUENTA =@CO_IDCuenta")

                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = Entidad.CO_NDOC
                Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
                Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = Entidad.CO_TDOC
                numeracionBE.NC_SERIE = Entidad.CO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = Entidad.CO_IDEMPRESA
                numeracionBL.Update(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing


                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try



            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = Entidad.CO_IDEMPRESA
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "INTER"

            rpta = paraetrosBL.get_Valor(paraetrosBE)


            '_______________________________________________________________________________________________________
            '1 = grabar en conta
            '0 = no grabar en conta

            If rpta = "1" Then


                Dim cuenta12 As String = String.Empty
                Dim cuenta13 As String = String.Empty
                Dim cuenta40 As String = String.Empty

                'buscamos la cuentas contables para el asiento
                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "CTA12"
                cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

                paraetrosBE.AD_NOMBRE = "CTA13"
                cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

                If cuenta12 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                    Exit Sub
                End If

                paraetrosBE.AD_NOMBRE = "CTA40"
                cuenta40 = paraetrosBL.get_Valor(paraetrosBE)
                If cuenta40 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Impuesto' ")
                    Exit Sub
                End If



                '________________________________________________________________________'CuentasContales


                'Buscamos el codigo de Subdiario
                Dim idsubdiario As String = ""

                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "IDSUB"
                idsubdiario = paraetrosBL.get_Valor(paraetrosBE)

                If idsubdiario = String.Empty Then
                    MsgBox("No esta establecido el codigo de subdiario para el asiento contable")
                    Exit Sub
                End If

                '________________________________________________________________________subdiarios

                paraetrosBE = Nothing
                paraetrosBL = Nothing

                '______________________________________________Buscamos el tipo de cambio de conta para las operaciones en dolares

                '                Dim tipocambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
                '                Dim tipocambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO


                '                tipocambioBE.TC_FECHA = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                '                tipocambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "2"}
                '                tipocambioBE.TC_IDEMPRESA = Entidad.CO_IDEMPRESA

                'inicioTC:

                '                tipocambioBL.getTipoCambio(tipocambioBE)

                '                If tipocambioBE.TC_VENTA = 0 Then
                '                    tipocambioBE.TC_FECHA = CDate(tipocambioBE.TC_FECHA).AddDays(-1).ToShortDateString
                '                    GoTo inicioTC
                '                End If


                '                Entidad.CO_TCAM = tipocambioBE.TC_VENTA

                '                tipocambioBE = Nothing
                '                tipocambioBL = Nothing




                Dim IdAnexoCliente As Integer = 0
                Dim Descrp_Anexo_Cliente As String = String.Empty
                Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim E_Ventas As New BE.ContabilidadBE.SG_CO_TB_VENTAS
                Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
                Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


                'Buscamos el codigo de anexo(ID) 
                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                Entidad.CO_IDCLIENTE.CL_IDEMPRESA = Entidad.CO_IDEMPRESA
                clienteBL.get_Cliente_x_Id(Entidad.CO_IDCLIENTE)

                anexoBE.AN_IDEMPRESA = Entidad.CO_IDEMPRESA
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = Entidad.CO_IDCLIENTE.CL_NDOC
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexoCliente = anexoBE.AN_IDANEXO
                Descrp_Anexo_Cliente = anexoBE.AN_DESCRIPCION.ToString

                With E_Ventas
                    .VE_IDCAB = Nothing
                    .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .VE_ANEXO_ID = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .VE_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .VE_SER_DOC = Entidad.CO_SDOC
                    .VE_NUM_DOC = Entidad.CO_NDOC
                    .VE_INDICADOR_DESTINO = "01"
                    .VE_FEC_EMI = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .VE_FEC_VEN = CDate(Entidad.CO_FEC_VEN).ToShortDateString
                    .VE_FEC_VOU = CDate(Entidad.CO_FEC_EMI).ToShortDateString

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .VE_TIP_DOC_REF = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC_REF.DO_CODIGO_SUNAT}
                        .VE_SER_DOC_REF = Entidad.CO_SDOC_REF
                        .VE_NUM_DOC_REF = Entidad.CO_NDOC_REF
                        .VE_FEC_EMI_REF = Entidad.CO_FEC_EMI_REF
                    Else
                        .VE_TIP_DOC_REF = Nothing
                        .VE_SER_DOC_REF = String.Empty
                        .VE_NUM_DOC_REF = String.Empty
                        .VE_FEC_EMI_REF = String.Empty
                    End If

                    .VE_TASA_IGV = Entidad.CO_TASA_IGV
                    .VE_MONTO_IGV = Entidad.CO_IGV
                    .VE_VALOR_VENTA = Entidad.CO_SUBTOTAL
                    .VE_PRECIO_VENTA = Entidad.CO_TOTAL

                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .VE_MONTO_IGV = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        .VE_VALOR_VENTA = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                        .VE_PRECIO_VENTA = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                    End If


                    .VE_MONTO_EXONERADO = 0
                    .VE_TASA_ISC = 0
                    .VE_MONTO_ISC = 0
                    .VE_OTROS_TRIBUTOS = 0
                    .VE_VALOR_INAFECTO = 0
                    .VE_DESCUENTO = 0
                    .VE_VALOR_BRUTO = 0
                    .VE_ISTATUS = 1
                    .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}
                End With

                With E_Cabecera
                    .AC_ID = Entidad.CO_ID
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = idsubdiario}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = CDate(Entidad.CO_FEC_EMI).Year
                    .AC_MES = CDate(Entidad.CO_FEC_EMI).Month
                    .AC_FEC_VOUCHER = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_HABER = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_TC_OPE = Entidad.CO_TCAM
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1

                    If Entidad.CO_TDOC.DO_CODIGO = "01" Then
                        .AC_GLOSA_VOU = Descrp_Anexo_Cliente
                    Else
                        .AC_GLOSA_VOU = Entidad.CO_NOTAS
                    End If

                    .AC_ES_INTERFACE = 1
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = Entidad.CO_USUARIO
                    .AC_TERMINAL = Entidad.CO_TERMINAL
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = Entidad.CO_IDEMPRESA
                End With



                'comenzamos con los detalles

                Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 1

                    If anexoBE.AN_ES_RELACIONADO = 1 Then
                        .AD_CUENTA = cuenta13
                    Else
                        .AD_CUENTA = cuenta12
                    End If


                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .AD_SDOC = Entidad.CO_SDOC
                    .AD_NDOC = Entidad.CO_NDOC
                    .AD_FDOC = Entidad.CO_FEC_EMI
                    .AD_VDOC = Entidad.CO_FEC_VEN
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_HABER = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_DEBE = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_TOTAL

                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now

                End With
                Detalles.Add(E_Detalle)

                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 2
                    .AD_CUENTA = cuenta40
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_DEBE = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_HABER = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_IGV
                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now
                End With
                Detalles.Add(E_Detalle)


                'Aqui hay que darle vuelta al detalle para grabar los detalles de la 70
                If tramiento > 0 Or Entidad.CO_TDOC.DO_CODIGO.Equals("07") Or Entidad.CO_IDTIPO_ORI = 1 Then

                    'si tiene tratamiento y su Cuenta contable es "CuentaCont"
                    If CuentaCont = "" Then
                        'si esta vacio es xq falto migrar la cuenta :D
                        CuentaCont = "709999"
                    End If

                    If Entidad.CO_IDTIPO_ORI = 1 Then
                        CuentaCont = "704131"
                    End If

                    E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                    With E_Detalle
                        .AD_IDCAB = E_Cabecera
                        .AD_SECUENCIA = 3
                        .AD_CUENTA = CuentaCont
                        .AD_TANEXO = Nothing
                        .AD_IDANEXO = Nothing
                        .AD_TDOC = Nothing
                        .AD_SDOC = String.Empty
                        .AD_NDOC = String.Empty
                        .AD_FDOC = String.Empty
                        .AD_VDOC = String.Empty
                        .AD_HABER = 0
                        .AD_DEBE = 0

                        If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                            .AD_DEBE = Entidad.CO_SUBTOTAL
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_DEBE = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                            End If
                        Else
                            .AD_HABER = Entidad.CO_SUBTOTAL
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_HABER = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                            End If
                        End If

                        .AD_MONTO_ORI = Entidad.CO_SUBTOTAL
                        .AD_TCAM = 0
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_TCAM = Entidad.CO_TCAM
                        End If

                        .AD_PORCE_DESTINO = 0
                        .AD_SEC_ORI_DESTINO = 0
                        .AD_GLOSA = Entidad.CO_NOTAS
                        .AD_IDCC = Nothing
                        .AD_ES_DESTINO = 0
                        .AD_USUARIO = Entidad.CO_USUARIO
                        .AD_TERMINAL = Entidad.CO_TERMINAL
                        .AD_FECREG = Date.Now
                    End With
                    Detalles.Add(E_Detalle)

                Else
                    Dim drr_Det As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DET_COMPROBAN", Entidad.CO_ID)
                    Dim cta70 As String = String.Empty

                    If drr_Det.HasRows Then
                        While drr_Det.Read
                            'Buscamos la cuenta 70 por el codigo del articulo

                            Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                            Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

                            articuloBE.AR_ID = drr_Det("CD_IDARTICULO")
                            articuloBE.AR_IDEMPRESA = Entidad.CO_IDEMPRESA.EM_ID
                            articuloBL.get_Articulo_x_Cod(articuloBE)

                            cta70 = articuloBE.AR_NUM_CTA_CONTA

                            If cta70 = String.Empty Then
                                MsgBox("La cuenta 70 del articulo " & articuloBE.AR_ID & "-" & articuloBE.AR_DESCRIPCION & " no esta establecida.")
                                cta70 = 701001
                            End If

                            articuloBE = Nothing
                            articuloBL = Nothing


                            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                            With E_Detalle
                                .AD_IDCAB = E_Cabecera
                                .AD_SECUENCIA = 3
                                .AD_CUENTA = cta70
                                .AD_TANEXO = Nothing
                                .AD_IDANEXO = Nothing
                                .AD_TDOC = Nothing
                                .AD_SDOC = String.Empty
                                .AD_NDOC = String.Empty
                                .AD_FDOC = String.Empty
                                .AD_VDOC = String.Empty
                                .AD_HABER = 0
                                .AD_DEBE = 0


                                If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                                    .AD_DEBE = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_DEBE = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                Else
                                    .AD_HABER = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_HABER = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                End If

                                .AD_MONTO_ORI = drr_Det("CD_SUBTOTAL")
                                .AD_TCAM = 0
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_TCAM = Entidad.CO_TCAM
                                End If

                                .AD_PORCE_DESTINO = 0
                                .AD_SEC_ORI_DESTINO = 0
                                .AD_GLOSA = Entidad.CO_NOTAS
                                .AD_IDCC = Nothing
                                .AD_ES_DESTINO = 0
                                .AD_USUARIO = Entidad.CO_USUARIO
                                .AD_TERMINAL = Entidad.CO_TERMINAL
                                .AD_FECREG = Date.Now
                            End With
                            Detalles.Add(E_Detalle)

                        End While
                    End If

                    drr_Det.Close()
                    drr_Det = Nothing
                End If
                Dim StrVoucher As String = String.Empty
                Try
                    AsientoBL.Insert_Ventas(E_Cabecera, E_Ventas, Detalles, StrVoucher, False, False)
                    numVoucherConta = StrVoucher
                    'actualizamos la cabecera del comprobante
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_EST_CAB_COMPRO", E_Cabecera.AC_ID, StrVoucher, 1, Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
                Catch ex As Exception
                    Throw New Exception("Error al intentar grabar en contabilidad.")
                End Try
            End If
        End Sub


        Public Sub Insert_FacSeg(ByRef Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByVal idFac As Integer, ByRef numVoucherConta As String, ByVal tramiento As Integer, ByVal CuentaCont As String)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                Dim idCabecera As Integer = 0
                Dim cod_Doc_ref As String = String.Empty

                If Not Entidad.CO_TDOC_REF Is Nothing Then
                    cod_Doc_ref = Entidad.CO_TDOC_REF.DO_CODIGO
                End If
                ' MsgBox(IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref))

                With Entidad
                    idCabecera = SqlHelper.ExecuteScalar(TRvar, "SG_FA_SP_I_COMPROBANTE_C_FACASEG", .CO_TDOC.DO_CODIGO, _
                                                  .CO_SDOC, .CO_NDOC, CDate(.CO_FEC_EMI).ToShortDateString, CDate(.CO_FEC_VEN).ToShortDateString, .CO_SUBTOTAL, _
                                                  .CO_SUBTOTAL_NA, .CO_IGV, .CO_TOTAL, .CO_IDMONEDA.MO_ID, _
                                                  .CO_TCAM, _
                                                  IIf(cod_Doc_ref = String.Empty, DBNull.Value, cod_Doc_ref), _
                                                  .CO_SDOC_REF, .CO_NDOC_REF, _
                                                  IIf(.CO_FEC_EMI_REF = String.Empty, DBNull.Value, .CO_FEC_EMI_REF), _
                                                  IIf(.CO_FEC_VEN_REF = String.Empty, DBNull.Value, .CO_FEC_VEN_REF), _
                                                  .CO_IDEMPRESA.EM_ID, .CO_USUARIO, _
                                                  .CO_TERMINAL, .CO_FECREG, .CO_IDCLIENTE.CL_ID, .CO_NOTAS, .CO_ESTADO, _
                                                  .CO_IDPTOVTA.PV_ID, .CO_IDFORMA_PAGO.FP_ID, .CO_ES_CONTA_PROVI, .CO_ES_CONTA_CANCE, _
                                                  .CO_IDUSUARIO.US_ID, .CO_IDDOCU_PAGO.DP_CODIGO, .CO_REF_PAGO, .CO_ES_REEMPLA, .CO_DNI, .CO_TASA_IGV, .CO_NUM_HIST, .CO_MEDICO, .CO_DESTINO, .CO_DEDUCIBLE, .CO_SEGURO, .CO_SEGURO_PORC, idFac, .CO_IDTIPO_ORI)
                End With

                Entidad.CO_ID = idCabecera


                SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_D_COMPROBANTE_D", Entidad.CO_ID)

                For Each deta_compro In Entidad.Detalles

                    With deta_compro
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_FA_SP_I_COMPROBANTE_D_Caja", Entidad.CO_ID, .CD_ITEM, _
                                                  .CD_IDARTICULO.AR_ID, .CD_CANT, .CD_PRECIO, .CD_DSCTO, _
                                                  .CD_SUBTOTAL, .CD_INAFECTO, .CD_IDEMPRESA.EM_ID, .CD_IGV, .CD_TOTAL, .CD_INC_IGV, .CD_IDCUENTA, .CD_CUENTA_ITEM, .CD_DSCTO_OTRO)
                        SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_LO_TB_CONSUMO_C set CM_ESTADO_DOC=3 where CM_ESTADO =1 and CM_IDCUENTA =" & .CD_IDCUENTA)
                        If Entidad.CO_TDOC.DO_CODIGO <> "07" Then
                            SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, "update SG_FA_TB_PRE_FACTURA_CAB set PF_FacTramite=1 where PF_IDCUENTA =" & .CD_IDCUENTA)
                        End If
                    End With

                Next


                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = Entidad.CO_NDOC
                Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
                Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = Entidad.CO_TDOC
                numeracionBE.NC_SERIE = Entidad.CO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = Entidad.CO_IDEMPRESA
                numeracionBL.Update(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing


                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try



            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
            Dim rpta As String = ""
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = Entidad.CO_IDEMPRESA
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "INTER"

            rpta = paraetrosBL.get_Valor(paraetrosBE)


            '_______________________________________________________________________________________________________
            '1 = grabar en conta
            '0 = no grabar en conta

            If rpta = "1" Then


                Dim cuenta12 As String = String.Empty
                Dim cuenta13 As String = String.Empty
                Dim cuenta40 As String = String.Empty

                'buscamos la cuentas contables para el asiento
                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "CTA12"
                cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

                paraetrosBE.AD_NOMBRE = "CTA13"
                cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

                If cuenta12 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                    Exit Sub
                End If

                paraetrosBE.AD_NOMBRE = "CTA40"
                cuenta40 = paraetrosBL.get_Valor(paraetrosBE)
                If cuenta40 = String.Empty Then
                    MsgBox("No esta establecido la cuenta contable de 'Impuesto' ")
                    Exit Sub
                End If



                '________________________________________________________________________'CuentasContales


                'Buscamos el codigo de Subdiario
                Dim idsubdiario As String = ""

                paraetrosBE.AD_TIPO = "CONTA"
                paraetrosBE.AD_NOMBRE = "IDSUB"
                idsubdiario = paraetrosBL.get_Valor(paraetrosBE)

                If idsubdiario = String.Empty Then
                    MsgBox("No esta establecido el codigo de subdiario para el asiento contable")
                    Exit Sub
                End If

                '________________________________________________________________________subdiarios

                paraetrosBE = Nothing
                paraetrosBL = Nothing

                Dim IdAnexoCliente As Integer = 0
                Dim Descrp_Anexo_Cliente As String = String.Empty
                Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim E_Ventas As New BE.ContabilidadBE.SG_CO_TB_VENTAS
                Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
                Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


                'Buscamos el codigo de anexo(ID) 
                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                Entidad.CO_IDCLIENTE.CL_IDEMPRESA = Entidad.CO_IDEMPRESA
                clienteBL.get_Cliente_x_Id(Entidad.CO_IDCLIENTE)

                anexoBE.AN_IDEMPRESA = Entidad.CO_IDEMPRESA
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = Entidad.CO_IDCLIENTE.CL_NDOC
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexoCliente = anexoBE.AN_IDANEXO
                Descrp_Anexo_Cliente = anexoBE.AN_DESCRIPCION.ToString

                With E_Ventas
                    .VE_IDCAB = Nothing
                    .VE_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .VE_ANEXO_ID = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .VE_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .VE_SER_DOC = Entidad.CO_SDOC
                    .VE_NUM_DOC = Entidad.CO_NDOC
                    .VE_INDICADOR_DESTINO = "01"
                    .VE_FEC_EMI = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .VE_FEC_VEN = CDate(Entidad.CO_FEC_VEN).ToShortDateString
                    .VE_FEC_VOU = CDate(Entidad.CO_FEC_EMI).ToShortDateString

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .VE_TIP_DOC_REF = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC_REF.DO_CODIGO_SUNAT}
                        .VE_SER_DOC_REF = Entidad.CO_SDOC_REF
                        .VE_NUM_DOC_REF = Entidad.CO_NDOC_REF
                        .VE_FEC_EMI_REF = Entidad.CO_FEC_EMI_REF
                    Else
                        .VE_TIP_DOC_REF = Nothing
                        .VE_SER_DOC_REF = String.Empty
                        .VE_NUM_DOC_REF = String.Empty
                        .VE_FEC_EMI_REF = String.Empty
                    End If

                    .VE_TASA_IGV = Entidad.CO_TASA_IGV
                    .VE_MONTO_IGV = Entidad.CO_IGV
                    .VE_VALOR_VENTA = Entidad.CO_SUBTOTAL
                    .VE_PRECIO_VENTA = Entidad.CO_TOTAL

                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .VE_MONTO_IGV = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        .VE_VALOR_VENTA = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                        .VE_PRECIO_VENTA = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                    End If


                    .VE_MONTO_EXONERADO = 0
                    .VE_TASA_ISC = 0
                    .VE_MONTO_ISC = 0
                    .VE_OTROS_TRIBUTOS = 0
                    .VE_VALOR_INAFECTO = 0
                    .VE_DESCUENTO = 0
                    .VE_VALOR_BRUTO = 0
                    .VE_ISTATUS = 1
                    .VE_IDSUBOPE = New BE.ContabilidadBE.SG_CO_TB_SUBOPERACION With {.SO_CODIGO = 6}
                End With

                With E_Cabecera
                    .AC_ID = Entidad.CO_ID
                    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = idsubdiario}
                    .AC_NUM_VOUCHER = ""
                    .AC_ANHO = CDate(Entidad.CO_FEC_EMI).Year
                    .AC_MES = CDate(Entidad.CO_FEC_EMI).Month
                    .AC_FEC_VOUCHER = CDate(Entidad.CO_FEC_EMI).ToShortDateString
                    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                    .AC_DEBE = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_HABER = Math.Round(Entidad.CO_TOTAL * IIf(Entidad.CO_IDMONEDA.MO_ID = "01", 1, Entidad.CO_TCAM), 2)
                    .AC_TC_OPE = Entidad.CO_TCAM
                    .AC_TC_ESPECIAL = 0
                    .AC_ESTADO = 1

                    If Entidad.CO_TDOC.DO_CODIGO = "01" Then
                        .AC_GLOSA_VOU = Descrp_Anexo_Cliente
                    Else
                        .AC_GLOSA_VOU = Entidad.CO_NOTAS
                    End If

                    .AC_ES_INTERFACE = 1
                    .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                    .AC_USUARIO = Entidad.CO_USUARIO
                    .AC_TERMINAL = Entidad.CO_TERMINAL
                    .AC_FECREG = Date.Now
                    .AC_IDEMPRESA = Entidad.CO_IDEMPRESA
                End With



                'comenzamos con los detalles

                Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 1

                    If anexoBE.AN_ES_RELACIONADO = 1 Then
                        .AD_CUENTA = cuenta13
                    Else
                        .AD_CUENTA = cuenta12
                    End If


                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexoCliente}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = Entidad.CO_TDOC.DO_CODIGO_SUNAT}
                    .AD_SDOC = Entidad.CO_SDOC
                    .AD_NDOC = Entidad.CO_NDOC
                    .AD_FDOC = Entidad.CO_FEC_EMI
                    .AD_VDOC = Entidad.CO_FEC_VEN
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_HABER = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_DEBE = Entidad.CO_TOTAL
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_TOTAL * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_TOTAL

                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now

                End With
                Detalles.Add(E_Detalle)

                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = 2
                    .AD_CUENTA = cuenta40
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = 0
                    .AD_HABER = 0

                    If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                        .AD_DEBE = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_DEBE = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    Else
                        .AD_HABER = Entidad.CO_IGV
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_HABER = Math.Round(Entidad.CO_IGV * Entidad.CO_TCAM, 2)
                        End If
                    End If

                    .AD_MONTO_ORI = Entidad.CO_IGV
                    .AD_TCAM = 0
                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                        .AD_TCAM = Entidad.CO_TCAM
                    End If

                    .AD_PORCE_DESTINO = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = Entidad.CO_NOTAS
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = Entidad.CO_USUARIO
                    .AD_TERMINAL = Entidad.CO_TERMINAL
                    .AD_FECREG = Date.Now
                End With
                Detalles.Add(E_Detalle)


                'Aqui hay que darle vuelta al detalle para grabar los detalles de la 70

                'Entidad.CO_IDTIPO_ORI = 1 = ambulatorio
                If tramiento > 0 Or Entidad.CO_TDOC.DO_CODIGO.Equals("07") Or Entidad.CO_IDTIPO_ORI = 1 Then
                    'si tiene tratamiento y su Cuenta contable es "CuentaCont"
                    If CuentaCont = "" Then
                        'si esta vacio es xq falto migrar la cuenta :D
                        CuentaCont = "709999"
                    End If

                    If Entidad.CO_IDTIPO_ORI = 1 Then
                        CuentaCont = "704131"
                    End If

                    E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                    With E_Detalle
                        .AD_IDCAB = E_Cabecera
                        .AD_SECUENCIA = 3
                        .AD_CUENTA = CuentaCont
                        .AD_TANEXO = Nothing
                        .AD_IDANEXO = Nothing
                        .AD_TDOC = Nothing
                        .AD_SDOC = String.Empty
                        .AD_NDOC = String.Empty
                        .AD_FDOC = String.Empty
                        .AD_VDOC = String.Empty
                        .AD_HABER = 0
                        .AD_DEBE = 0

                        If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                            .AD_DEBE = Entidad.CO_SUBTOTAL
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_DEBE = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                            End If
                        Else
                            .AD_HABER = Entidad.CO_SUBTOTAL
                            If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                .AD_HABER = Math.Round(Entidad.CO_SUBTOTAL * Entidad.CO_TCAM, 2)
                            End If
                        End If

                        .AD_MONTO_ORI = Entidad.CO_SUBTOTAL
                        .AD_TCAM = 0
                        If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                            .AD_TCAM = Entidad.CO_TCAM
                        End If

                        .AD_PORCE_DESTINO = 0
                        .AD_SEC_ORI_DESTINO = 0
                        .AD_GLOSA = Entidad.CO_NOTAS
                        .AD_IDCC = Nothing
                        .AD_ES_DESTINO = 0
                        .AD_USUARIO = Entidad.CO_USUARIO
                        .AD_TERMINAL = Entidad.CO_TERMINAL
                        .AD_FECREG = Date.Now
                    End With
                    Detalles.Add(E_Detalle)




                Else
                    Dim drr_Det As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_FA_SP_S_DET_COMPROBAN", Entidad.CO_ID)
                    Dim cta70 As String = String.Empty

                    If drr_Det.HasRows Then
                        While drr_Det.Read
                            'Buscamos la cuenta 70 por el codigo del articulo

                            Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                            Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

                            articuloBE.AR_ID = drr_Det("CD_IDARTICULO")
                            articuloBE.AR_IDEMPRESA = Entidad.CO_IDEMPRESA.EM_ID
                            articuloBL.get_Articulo_x_Cod(articuloBE)

                            cta70 = articuloBE.AR_NUM_CTA_CONTA

                            If cta70 = String.Empty Then
                                MsgBox("La cuenta 70 del articulo " & articuloBE.AR_ID & "-" & articuloBE.AR_DESCRIPCION & " no esta establecida.")
                                cta70 = 701001
                            End If

                            articuloBE = Nothing
                            articuloBL = Nothing


                            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                            With E_Detalle
                                .AD_IDCAB = E_Cabecera
                                .AD_SECUENCIA = Detalles.Count
                                .AD_CUENTA = cta70
                                .AD_TANEXO = Nothing
                                .AD_IDANEXO = Nothing
                                .AD_TDOC = Nothing
                                .AD_SDOC = String.Empty
                                .AD_NDOC = String.Empty
                                .AD_FDOC = String.Empty
                                .AD_VDOC = String.Empty
                                .AD_HABER = 0
                                .AD_DEBE = 0

                                If Entidad.CO_TDOC.DO_CODIGO.Equals("07") Then
                                    .AD_DEBE = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_DEBE = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                Else
                                    .AD_HABER = drr_Det("CD_SUBTOTAL")
                                    If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                        .AD_HABER = Math.Round(drr_Det("CD_SUBTOTAL") * Entidad.CO_TCAM, 2)
                                    End If
                                End If

                                .AD_MONTO_ORI = drr_Det("CD_SUBTOTAL")
                                .AD_TCAM = 0
                                If Entidad.CO_IDMONEDA.MO_ID <> "01" Then
                                    .AD_TCAM = Entidad.CO_TCAM
                                End If

                                .AD_PORCE_DESTINO = 0
                                .AD_SEC_ORI_DESTINO = 0
                                .AD_GLOSA = Entidad.CO_NOTAS
                                .AD_IDCC = Nothing
                                .AD_ES_DESTINO = 0
                                .AD_USUARIO = Entidad.CO_USUARIO
                                .AD_TERMINAL = Entidad.CO_TERMINAL
                                .AD_FECREG = Date.Now
                            End With
                            Detalles.Add(E_Detalle)

                        End While
                    End If

                    drr_Det.Close()
                    drr_Det = Nothing
                End If



                Dim StrVoucher As String = String.Empty
                Try
                    AsientoBL.Insert_Ventas(E_Cabecera, E_Ventas, Detalles, StrVoucher, False, False)
                    numVoucherConta = StrVoucher
                    'actualizamos la cabecera del comprobante
                    SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_EST_CAB_COMPRO", E_Cabecera.AC_ID, StrVoucher, 1, Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
                Catch ex As Exception
                    Throw New Exception("Error al intentar grabar en contabilidad.")
                End Try

            End If


        End Sub

        Public Function Existe_Comprobante(ByVal entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False

            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUM_FACTURAS", entidad.CO_TDOC.DO_CODIGO, entidad.CO_SDOC, entidad.CO_NDOC, entidad.CO_IDEMPRESA.EM_ID)

            If int_cantidad > 0 Then
                rpta = True
            End If

            Return rpta

        End Function

        Public Function Existe_ComprobAseg_Cuenta(ByVal IdCuentas As Integer) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False
            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUM_FACTURAS_ASEG", IdCuentas)
            If int_cantidad > 0 Then
                rpta = True
            End If

            Return rpta
        End Function

        Public Function Existe_Comprob_Cuenta(ByVal IdCuentas As Integer) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False
            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUM_FACTURAS_COMP", IdCuentas)
            If int_cantidad > 0 Then
                rpta = True
            End If
            Return rpta
        End Function

        Public Function Existe_Comprob_CuentaTodos(ByVal IdCuentas As Integer) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False
            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_S_NUM_FACTURAS_COMPTodo", IdCuentas)
            If int_cantidad > 0 Then
                rpta = True
            End If
            Return rpta
        End Function


        Public Sub Anular(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_U_ANULA_COMPRO", Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
            SqlHelper.ExecuteNonQuery(Cn, "Fertilidad_EliminarPago", Entidad.CO_ID)
        End Sub

        Public Sub Anular_Bot(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String)
            Try
                Entidad.CO_ID = SqlHelper.ExecuteScalar(Cn, "SG_FA_SP_U_ANULA_COMPRO_BOT", Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID, oIdUsuarioActivo, oIdEstacionActiva)
                If Entidad.CO_ID > 0 Then
                    MsgBox("Listo", MsgBoxStyle.Information, ".:. Aviso .:.")
                Else
                    Throw New Exception("No se puede anular el comprobante, corresponde a un Inventario ya cerrado.")
                    Exit Sub
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Insert_codigo(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_I_CODIGOS", oIdUsuarioActivo, oIdEstacionActiva, Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete_codigo(ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String)
            SqlHelper.ExecuteNonQuery(Cn, "SG_FA_SP_D_CODIGOS", oIdUsuarioActivo, oIdEstacionActiva)
        End Sub

        Public Sub Anular_En_Contabilidad(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
            SqlHelper.ExecuteNonQuery(Cn, "SG_CO_SP_ANULA_VOU_VENTASFAC", Entidad.CO_IDVOUCHER, Entidad.CO_IDEMPRESA.EM_ID, Entidad.CO_USUARIO, Entidad.CO_TERMINAL)
        End Sub

        Public Function get_Comprobante_x_Id(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBANTE", Entidad.CO_ID, Entidad.CO_IDEMPRESA.EM_ID)
        End Function

        Public Function get_Comprobante_x_Num_Doc(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBANTE_02", Entidad.CO_TDOC_REF.DO_CODIGO, Entidad.CO_SDOC_REF, Entidad.CO_NDOC_REF, Entidad.CO_IDEMPRESA.EM_ID)
        End Function

        Public Function get_Lista_Edi_x_Dia(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_1", Entidad.CO_FEC_EMI, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Dia_02(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_1_2", Entidad.CO_IDUSUARIO.US_ID, Entidad.CO_FEC_EMI, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Dia_03(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_1_3", Entidad.CO_FEC_EMI, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Semana(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_2", Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Semana_02(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_2_2", Entidad.CO_IDUSUARIO.US_ID, Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Semana_03(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_2_3", Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Mes(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_3", ayo_, mes_, empresa_.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Mes_02(ByVal usuario_ As Integer, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_3_2", usuario_, ayo_, mes_, empresa_.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Mes_03(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_3_3", ayo_, mes_, empresa_.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Dia_Fac(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_1_Fac", Entidad.CO_FEC_EMI, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Semana_Fac(ByVal Entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_2_Fac", Entidad.CO_FEC_EMI, Entidad.CO_FEC_VEN, Entidad.CO_IDEMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_Edi_x_Mes_Fac(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_EDI_3_Fac", ayo_, mes_, empresa_.EM_ID).Tables(0)
        End Function

        Public Function get_Lista_x_Fecha_SoloActivos(ByVal fecha_ As Date, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBAN_X_FECHA", fecha_, empresa_).Tables(0)
        End Function

        Public Function get_Lista_x_Fecha_Todo(ByVal fecha_ As Date, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBAN_X_FECHA_TODO", fecha_, empresa_).Tables(0)
        End Function

        Public Function get_Lista_Compro(ByVal fecha As Date, ByVal fech2 As Date, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa As Integer, ByVal tipo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_LISTA_Compro_BOt", ayo_, mes_, fecha, fech2, empresa, tipo).Tables(0)
        End Function

        Public Sub Generar_Asiento_Caja_02(ByVal fecha_ As Date, ByVal empresa_ As Integer, ByVal usuario_ As String, ByRef str_NumVoucherCaja_ As String, ByVal cajaCab_ As BE.FacturacionBE.SG_FA_TB_CAJA_CAB, ByVal ls_cajaDet_ As List(Of BE.FacturacionBE.SG_FA_TB_CAJA_DET))

            Dim cuenta12 As String = String.Empty
            Dim cuenta13 As String = String.Empty

            'Buscamos la cuentas contables para el asiento
            '________________________________________________________________________'CuentasContales

            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "CTA12"
            cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

            If cuenta12 = String.Empty Then
                MsgBox("No esta establecido la cuenta contable 12 de 'Clientes' ")
                Exit Sub
            End If

            paraetrosBE.AD_NOMBRE = "CTA13"
            cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

            If cuenta13 = String.Empty Then
                MsgBox("No esta establecido la cuenta contable 13 de 'Clientes' ")
                Exit Sub
            End If

            '________________________________________________________________________'CuentasContales


            'Buscamos el codigo de Subdiario
            Dim IdSubdiario_Caja As String = ""

            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "SUBCA"
            IdSubdiario_Caja = paraetrosBL.get_Valor(paraetrosBE)

            If IdSubdiario_Caja = String.Empty Then
                MsgBox("No esta establecido el codigo de subdiario de Caja para el asiento contable")
                Exit Sub
            End If

            paraetrosBE = Nothing
            paraetrosBL = Nothing

            '________________________________________________________________________subdiarios


            Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim asientoBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim ls_Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim ls_IDsComprobantes As New List(Of Integer)
            Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim dt_compros As DataTable = Nothing
            Dim monto_total_compro As Double = 0.0R
            Dim glosa_compro As String = String.Empty
            Dim detallePagoBL As New BL.FacturacionBL.SG_FA_TB_COMPRO_DOCPAGO
            Dim Monto_Cierre_Caja_Dol As Double = 0.0R
            Dim Monto_TC_Caja As Double = 0.0R



            dt_compros = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPRO_X_IDUSU_02", cajaCab_.CA_IDUSUARIO, cajaCab_.CA_ID, empresa_).Tables(0)
            glosa_compro = "CAJA INGRESOS - CAJERO(A) : " & usuario_ & " FECHA : " & fecha_.ToShortDateString

            monto_total_compro = dt_compros.Compute("sum(CO_TOTAL)", "")
            Monto_Cierre_Caja_Dol = dt_compros(0)("CA_CIE_DOL")
            Monto_TC_Caja = dt_compros(0)("CO_TCAM")



            'Cabecera Asiento
            With asientoBE
                .AC_ID = 0
                .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = IdSubdiario_Caja}
                .AC_NUM_VOUCHER = ""
                .AC_ANHO = fecha_.Year
                .AC_MES = fecha_.Month
                .AC_FEC_VOUCHER = fecha_
                .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                .AC_DEBE = monto_total_compro
                .AC_HABER = monto_total_compro
                .AC_TC_OPE = 0
                .AC_TC_ESPECIAL = 0
                .AC_ESTADO = 1
                .AC_GLOSA_VOU = glosa_compro
                .AC_ES_INTERFACE = 1
                .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                .AC_TERMINAL = Environment.MachineName
                .AC_FECREG = Now.Date
                .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                .AC_ES_IMPRESO = 0
            End With


            'Limpiamos la Coleccion de Detalles del Comprobante
            ls_Detalles.Clear()

            Dim dc_cuentas As New Dictionary(Of String, Double)
            Dim tc As Double = 0
            Dim mon As String = ""
            Dim total As Double = 0
            Dim dt_detalle_pago As DataTable = Nothing

            For i As Integer = 0 To dt_compros.Rows.Count - 1

                tc = dt_compros.Rows(i)("CO_TCAM")
                mon = dt_compros.Rows(i)("CO_IDMONEDA")
                total = IIf(mon = "01", dt_compros.Rows(i)("CO_TOTAL"), dt_compros.Rows(i)("CO_TOTAL") * tc)

                dt_detalle_pago = detallePagoBL.get_Cuentas_por_IdComprobante(dt_compros.Rows(i)("CO_ID"), empresa_)

                If dt_detalle_pago.Rows.Count > 0 Then

                    For z As Integer = 0 To dt_detalle_pago.Rows.Count - 1
                        total = dt_detalle_pago.Rows(z)("CD_IMPORTE")
                        If dc_cuentas.ContainsKey(dt_detalle_pago.Rows(z)("DP_CTA_CONTA")) Then
                            dc_cuentas(dt_detalle_pago.Rows(z)("DP_CTA_CONTA")) = dc_cuentas(dt_detalle_pago.Rows(z)("DP_CTA_CONTA")) + total
                        Else
                            dc_cuentas.Add(dt_detalle_pago.Rows(z)("DP_CTA_CONTA"), total)
                        End If
                    Next
                Else
                    If dc_cuentas.ContainsKey(dt_compros.Rows(i)("DP_CTA_CONTA")) Then
                        If dt_compros.Rows(i)("DO_CODIGO_SUNAT") = 7 Or dt_compros.Rows(i)("CO_ES_REEMPLA") = 1 Then
                            dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) = dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) - dt_compros.Rows(i)("CO_TOTAL")
                        Else
                            dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) = dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) + total
                        End If
                    Else
                        dc_cuentas.Add(dt_compros.Rows(i)("DP_CTA_CONTA"), total)
                    End If
                End If

                dt_detalle_pago.Dispose()
            Next


            Dim iItem As Integer = 1

            Dim xxx As New KeyValuePair(Of String, Double)
            Dim sortedDict = (From entry In dc_cuentas Order By entry.Key Ascending).ToDictionary(Function(pair) pair.Key, Function(pair) pair.Value)


            If empresa_ = 1 And Monto_Cierre_Caja_Dol > 0 Then 'clinica miraflores
                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = iItem
                    .AD_CUENTA = "103001"
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = Math.Round((Monto_Cierre_Caja_Dol * Monto_TC_Caja), 2)
                    .AD_HABER = 0
                    .AD_MONTO_ORI = Monto_Cierre_Caja_Dol
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = Monto_TC_Caja
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = glosa_compro
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0
                End With
                ls_Detalles.Add(detalle)
                iItem += 1
            End If

            'Cuenta 10 - Caja
            For Each e As KeyValuePair(Of String, Double) In sortedDict 'dc_cuentas

                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = iItem
                    .AD_CUENTA = e.Key
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = e.Value
                    .AD_HABER = 0
                    .AD_MONTO_ORI = e.Value

                    If e.Key = "103002" And empresa_ = 1 And Monto_Cierre_Caja_Dol > 0 Then 'clinica miraflores
                        .AD_DEBE = (e.Value - Math.Round((Monto_Cierre_Caja_Dol * Monto_TC_Caja), 2))
                    End If
                    
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = glosa_compro
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0
                End With
                ls_Detalles.Add(detalle)

                iItem += 1
            Next

            'Cuentas 12, FT,BV,NC
            For i As Integer = 0 To dt_compros.Rows.Count - 1

                '__________________________________________________________________________________________________
                '### Buscamos el IdAnexo por Ruc de Cliente
                Dim IdAnexo_Conta As Integer = 0

                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = dt_compros.Rows(i)("CL_NDOC")
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexo_Conta = anexoBE.AN_IDANEXO

                If empresa_ = 7 Then 'botica
                    If dt_compros.Rows(i)("CO_TDOC") = "03" Or dt_compros.Rows(i)("CO_TDOC") = "07" Then
                        IdAnexo_Conta = 6064
                    End If
                End If


                anexoBE = Nothing
                anexoBL = Nothing
                '__________________________________________________________________________________________________
                '### calculamos el importe en soles si es dolares, el asiento debe estar en soles pero con su 
                '### referencia en dolares

                tc = dt_compros.Rows(i)("CO_TCAM")
                mon = dt_compros.Rows(i)("CO_IDMONEDA")
                total = IIf(mon = "01", dt_compros.Rows(i)("CO_TOTAL"), dt_compros.Rows(i)("CO_TOTAL") * tc)

                '__________________________________________________________________________________________________



                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = ls_Detalles.Count + 1

                    .AD_CUENTA = IIf(dt_compros.Rows(i)("CL_ES_RELACIONADO") = 1, cuenta13, cuenta12)

                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexo_Conta}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = dt_compros.Rows(i)("DO_CODIGO_SUNAT")}

                    .AD_SDOC = dt_compros.Rows(i)("CO_SDOC")
                    .AD_NDOC = dt_compros.Rows(i)("CO_NDOC")
                    .AD_FDOC = dt_compros.Rows(i)("CO_FEC_EMI")
                    .AD_VDOC = dt_compros.Rows(i)("CO_FEC_VEN")


                    If dt_compros.Rows(i)("DO_CODIGO_SUNAT") = 7 Then
                        .AD_DEBE = total
                        .AD_HABER = 0
                    Else
                        .AD_DEBE = 0
                        .AD_HABER = total
                    End If

                    .AD_MONTO_ORI = IIf(mon = "01", total, dt_compros.Rows(i)("CO_TOTAL"))
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = IIf(mon = "01", 0, tc)
                    .AD_SEC_ORI_DESTINO = 0

                    Select Case empresa_
                        Case 7 'botica
                            .AD_GLOSA = dt_compros.Rows(i)("CL_NOMBRE").ToString
                        Case Else
                            .AD_GLOSA = glosa_compro
                    End Select



                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0

                    'esto para actualizar la cabecera de comprobantes para saber cual ya se contabilizo
                    ls_IDsComprobantes.Add(dt_compros.Rows(i)("CO_ID"))

                End With
                ls_Detalles.Add(detalle)

            Next

            Dim str_num_voucher As String = ""
            asientoBL.Insert_Caja_Facturacion(asientoBE, ls_Detalles, str_num_voucher, ls_IDsComprobantes, cajaCab_, ls_cajaDet_)
            str_NumVoucherCaja_ = str_num_voucher

        End Sub

        Public Sub Generar_Asiento_Caja(ByVal fecha_ As Date, ByVal empresa_ As Integer, ByVal usuario_ As String, ByRef str_NumVoucherCaja_ As String)

            Dim cuenta12 As String = String.Empty

            'buscamos la cuentas contables para el asiento
            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "CTA12"
            cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

            If cuenta12 = String.Empty Then
                MsgBox("No esta establecido la cuenta contable de 'Clientes' ")
                Exit Sub
            End If


            '________________________________________________________________________'CuentasContales


            'Buscamos el codigo de Subdiario
            Dim IdSubdiario_Caja As String = ""

            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "SUBCA"
            IdSubdiario_Caja = paraetrosBL.get_Valor(paraetrosBE)

            If IdSubdiario_Caja = String.Empty Then
                MsgBox("No esta establecido el codigo de subdiario de Caja para el asiento contable")
                Exit Sub
            End If

            paraetrosBE = Nothing
            paraetrosBL = Nothing

            '________________________________________________________________________subdiarios


            Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim asientoBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim ls_Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim ls_IDsComprobantes As New List(Of Integer)
            Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim dt_compros As DataTable = Nothing
            Dim monto_total_compro As Double = 0.0R
            Dim glosa_compro As String = String.Empty
            Dim detallePagoBL As New BL.FacturacionBL.SG_FA_TB_COMPRO_DOCPAGO




            dt_compros = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPROBAN_X_FECHA", fecha_, empresa_).Tables(0)
            glosa_compro = "CAJA INGRESOS - CAJERO(A) : " & usuario_ & " FECHA : " & fecha_.ToShortDateString
            monto_total_compro = dt_compros.Compute("sum(CO_TOTAL)", "")


            'Cabecera Asiento
            With asientoBE
                .AC_ID = 0
                .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = IdSubdiario_Caja}
                .AC_NUM_VOUCHER = ""
                .AC_ANHO = fecha_.Year
                .AC_MES = fecha_.Month
                .AC_FEC_VOUCHER = fecha_
                .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                .AC_DEBE = monto_total_compro
                .AC_HABER = monto_total_compro
                .AC_TC_OPE = 0
                .AC_TC_ESPECIAL = 0
                .AC_ESTADO = 1
                .AC_GLOSA_VOU = glosa_compro
                .AC_ES_INTERFACE = 1
                .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                .AC_TERMINAL = Environment.MachineName
                .AC_FECREG = Now.Date
                .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                .AC_ES_IMPRESO = 0
            End With


            'Limpiamos la Coleccion de Detalles del Comprobante
            ls_Detalles.Clear()

            Dim dc_cuentas As New Dictionary(Of String, Double)
            Dim tc As Double = 0
            Dim mon As String = ""
            Dim total As Double = 0
            Dim dt_detalle_pago As DataTable = Nothing

            For i As Integer = 0 To dt_compros.Rows.Count - 1

                tc = dt_compros.Rows(i)("CO_TCAM")
                mon = dt_compros.Rows(i)("CO_IDMONEDA")
                total = IIf(mon = "01", dt_compros.Rows(i)("CO_TOTAL"), dt_compros.Rows(i)("CO_TOTAL") * tc)

                dt_detalle_pago = detallePagoBL.get_Cuentas_por_IdComprobante(dt_compros.Rows(i)("CO_ID"), empresa_)

                If dt_detalle_pago.Rows.Count > 0 Then

                    For z As Integer = 0 To dt_detalle_pago.Rows.Count - 1
                        total = dt_detalle_pago.Rows(z)("CD_IMPORTE")
                        If dc_cuentas.ContainsKey(dt_detalle_pago.Rows(z)("DP_CTA_CONTA")) Then
                            dc_cuentas(dt_detalle_pago.Rows(z)("DP_CTA_CONTA")) = dc_cuentas(dt_detalle_pago.Rows(z)("DP_CTA_CONTA")) + total
                        Else
                            dc_cuentas.Add(dt_detalle_pago.Rows(z)("DP_CTA_CONTA"), total)
                        End If
                    Next
                Else
                    If dc_cuentas.ContainsKey(dt_compros.Rows(i)("DP_CTA_CONTA")) Then
                        If dt_compros.Rows(i)("DO_CODIGO_SUNAT") = 7 Or dt_compros.Rows(i)("CO_ES_REEMPLA") = 1 Then
                            'dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) = dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) - dt_compros.Rows(i)("CO_TOTAL")
                        Else
                            dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) = dc_cuentas(dt_compros.Rows(i)("DP_CTA_CONTA")) + total
                        End If
                    Else
                        dc_cuentas.Add(dt_compros.Rows(i)("DP_CTA_CONTA"), total)
                    End If
                End If

                dt_detalle_pago.Dispose()

            Next


            Dim iItem As Integer = 1

            Dim xxx As New KeyValuePair(Of String, Double)
            Dim sortedDict = (From entry In dc_cuentas Order By entry.Key Ascending).ToDictionary(Function(pair) pair.Key, Function(pair) pair.Value)



            'Cuenta 10 - Caja
            For Each e As KeyValuePair(Of String, Double) In sortedDict 'dc_cuentas

                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = iItem
                    .AD_CUENTA = e.Key
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing
                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty
                    .AD_DEBE = e.Value
                    .AD_HABER = 0
                    .AD_MONTO_ORI = e.Value
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = 0
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = glosa_compro
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0
                End With
                ls_Detalles.Add(detalle)

                iItem += 1
            Next





            'Cuentas 12, FT,BV,NC
            For i As Integer = 0 To dt_compros.Rows.Count - 1

                '__________________________________________________________________________________________________
                '### Buscamos el IdAnexo por Ruc de Cliente
                Dim IdAnexo_Conta As Integer = 0

                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = dt_compros.Rows(i)("CL_NDOC")
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexo_Conta = anexoBE.AN_IDANEXO

                anexoBE = Nothing
                anexoBL = Nothing
                '__________________________________________________________________________________________________
                '### calculamos el importe en soles si es dolares, el asiento debe estar en soles pero con su 
                '### referencia en dolares

                tc = dt_compros.Rows(i)("CO_TCAM")
                mon = dt_compros.Rows(i)("CO_IDMONEDA")
                total = IIf(mon = "01", dt_compros.Rows(i)("CO_TOTAL"), dt_compros.Rows(i)("CO_TOTAL") * tc)

                '__________________________________________________________________________________________________

                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = ls_Detalles.Count + 1
                    .AD_CUENTA = cuenta12

                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexo_Conta}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = dt_compros.Rows(i)("DO_CODIGO_SUNAT")}

                    .AD_SDOC = dt_compros.Rows(i)("CO_SDOC")
                    .AD_NDOC = dt_compros.Rows(i)("CO_NDOC")
                    .AD_FDOC = dt_compros.Rows(i)("CO_FEC_EMI")
                    .AD_VDOC = dt_compros.Rows(i)("CO_FEC_VEN")

                    If dt_compros.Rows(i)("DO_CODIGO_SUNAT") = 7 Then
                        .AD_DEBE = total
                        .AD_HABER = 0
                    Else
                        .AD_DEBE = 0
                        .AD_HABER = total
                    End If

                    .AD_MONTO_ORI = IIf(mon = "01", total, dt_compros.Rows(i)("CO_TOTAL"))
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = IIf(mon = "01", 0, tc)
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = glosa_compro
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0

                    'esto para actualizar la cabecera de comprobantes para saber cual ya se contabilizo
                    ls_IDsComprobantes.Add(dt_compros.Rows(i)("CO_ID"))

                End With
                ls_Detalles.Add(detalle)

            Next

            Dim str_num_voucher As String = ""
            asientoBL.Insert_Caja_Facturacion(asientoBE, ls_Detalles, str_num_voucher, ls_IDsComprobantes, Nothing, Nothing)
            str_NumVoucherCaja_ = str_num_voucher

        End Sub

        Public Sub Generar_Asiento_FacturaCredito(ByVal fecha_ As Date, ByVal empresa_ As Integer, ByVal usuario_ As String, ByRef str_NumVoucherCaja_ As String, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String)

            Dim cuenta12 As String = String.Empty
            Dim cuenta13 As String = String.Empty
            Dim es_rel As Integer = 0

            'Buscamos la cuentas contables para el asiento
            '________________________________________________________________________'CuentasContales

            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "CTA12"
            cuenta12 = paraetrosBL.get_Valor(paraetrosBE)

            If cuenta12 = String.Empty Then
                MsgBox("No esta establecido la cuenta contable 12 de 'Clientes' ")
                Exit Sub
            End If

            paraetrosBE.AD_NOMBRE = "CTA13"
            cuenta13 = paraetrosBL.get_Valor(paraetrosBE)

            If cuenta13 = String.Empty Then
                MsgBox("No esta establecido la cuenta contable 13 de 'Clientes' ")
                Exit Sub
            End If

            '________________________________________________________________________'CuentasContales


            'Buscamos el codigo de Subdiario
            Dim IdSubdiario_Caja As String = ""

            paraetrosBE.AD_TIPO = "CONTA"
            paraetrosBE.AD_NOMBRE = "SUBCA"
            IdSubdiario_Caja = paraetrosBL.get_Valor(paraetrosBE)

            If IdSubdiario_Caja = String.Empty Then
                MsgBox("No esta establecido el codigo de subdiario de Caja para el asiento contable")
                Exit Sub
            End If

            paraetrosBE = Nothing
            paraetrosBL = Nothing

            '________________________________________________________________________subdiarios


            Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim asientoBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim ls_Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)
            Dim ls_IDsComprobantes As New List(Of Integer)
            Dim detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            Dim dt_compros As DataTable = Nothing
            Dim monto_total_compro As Double = 0.0R
            Dim glosa_compro As String = String.Empty
            Dim detallePagoBL As New BL.FacturacionBL.SG_FA_TB_COMPRO_DOCPAGO


            dt_compros = SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPRO_X_Credito", oIdUsuarioActivo, oIdEstacionActiva, empresa_).Tables(0)
            glosa_compro = "CAJA INGRESOS - CAJERO(A) : " & usuario_ & " FECHA : " & fecha_.ToShortDateString

            monto_total_compro = dt_compros.Compute("sum(CO_TOTAL)", "")


            'Cabecera Asiento
            With asientoBE
                .AC_ID = 0
                .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = IdSubdiario_Caja}
                .AC_NUM_VOUCHER = ""
                .AC_ANHO = fecha_.Year
                .AC_MES = fecha_.Month
                .AC_FEC_VOUCHER = fecha_
                .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = "1"}
                .AC_DEBE = monto_total_compro
                .AC_HABER = monto_total_compro
                .AC_TC_OPE = 0
                .AC_TC_ESPECIAL = 0
                .AC_ESTADO = 1
                .AC_GLOSA_VOU = glosa_compro
                .AC_ES_INTERFACE = 1
                .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
                .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                .AC_TERMINAL = Environment.MachineName
                .AC_FECREG = Now.Date
                .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                .AC_ES_IMPRESO = 0
            End With


            'Limpiamos la Coleccion de Detalles del Comprobante
            ls_Detalles.Clear()

            Dim tc As Double = 0
            Dim mon As String = ""
            Dim total As Double = 0
            'Dim dt_detalle_pago As DataTable = Nothing

            'Cuenta 10 - Caja
            '   For Each e As KeyValuePair(Of String, Double) In sortedDict 'dc_cuentas

            detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
            With detalle
                .AD_IDCAB = asientoBE
                .AD_SECUENCIA = 1
                .AD_CUENTA = "101001"
                .AD_TANEXO = Nothing
                .AD_IDANEXO = Nothing
                .AD_TDOC = Nothing
                .AD_SDOC = String.Empty
                .AD_NDOC = String.Empty
                .AD_FDOC = String.Empty
                .AD_VDOC = String.Empty
                .AD_DEBE = monto_total_compro
                .AD_HABER = 0
                .AD_MONTO_ORI = monto_total_compro
                .AD_PORCE_DESTINO = 0
                .AD_TCAM = 0
                .AD_SEC_ORI_DESTINO = 0
                .AD_GLOSA = glosa_compro
                .AD_IDCC = Nothing
                .AD_ES_DESTINO = 0
                .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                .AD_TERMINAL = Environment.MachineName
                .AD_FECREG = Date.Now
                .AD_IDMEDIOPAGO = Nothing
                .AD_ES_DETRA = 0
            End With
            ls_Detalles.Add(detalle)


            'Cuentas 12, FT,BV,NC
            For i As Integer = 0 To dt_compros.Rows.Count - 1

                '__________________________________________________________________________________________________
                '### Buscamos el IdAnexo por Ruc de Cliente
                Dim IdAnexo_Conta As Integer = 0

                Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
                anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                anexoBE.AN_NUM_DOC = dt_compros.Rows(i)("CL_NDOC")
                anexoBL.getAnexo_x_Ruc(anexoBE)

                IdAnexo_Conta = anexoBE.AN_IDANEXO
                es_rel = anexoBE.AN_ES_RELACIONADO

                anexoBE = Nothing
                anexoBL = Nothing
                '__________________________________________________________________________________________________
                '### calculamos el importe en soles si es dolares, el asiento debe estar en soles pero con su 
                '### referencia en dolares

                tc = dt_compros.Rows(i)("CO_TCAM")
                mon = dt_compros.Rows(i)("CO_IDMONEDA")
                total = IIf(mon = "01", dt_compros.Rows(i)("CO_TOTAL"), dt_compros.Rows(i)("CO_TOTAL") * tc)

                '__________________________________________________________________________________________________

                detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                With detalle
                    .AD_IDCAB = asientoBE
                    .AD_SECUENCIA = ls_Detalles.Count + 1

                    .AD_CUENTA = IIf(es_rel = 1, cuenta13, cuenta12)

                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = IdAnexo_Conta}
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = dt_compros.Rows(i)("DO_CODIGO_SUNAT")}

                    .AD_SDOC = dt_compros.Rows(i)("CO_SDOC")
                    .AD_NDOC = dt_compros.Rows(i)("CO_NDOC")
                    .AD_FDOC = dt_compros.Rows(i)("CO_FEC_EMI")
                    .AD_VDOC = dt_compros.Rows(i)("CO_FEC_VEN")

                    If dt_compros.Rows(i)("DO_CODIGO_SUNAT") = 7 Then
                        .AD_DEBE = total
                        .AD_HABER = 0
                    Else
                        .AD_DEBE = 0
                        .AD_HABER = total
                    End If

                    .AD_MONTO_ORI = IIf(mon = "01", total, dt_compros.Rows(i)("CO_TOTAL"))
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = IIf(mon = "01", 0, tc)
                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = glosa_compro
                    .AD_IDCC = Nothing
                    .AD_ES_DESTINO = 0
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, usuario_)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing
                    .AD_ES_DETRA = 0

                    'esto para actualizar la cabecera de comprobantes para saber cual ya se contabilizo
                    ls_IDsComprobantes.Add(dt_compros.Rows(i)("CO_ID"))

                End With
                ls_Detalles.Add(detalle)

            Next

            Dim str_num_voucher As String = ""
            asientoBL.Insert_FAC_Facturacion(asientoBE, ls_Detalles, str_num_voucher, ls_IDsComprobantes)
            str_NumVoucherCaja_ = str_num_voucher

        End Sub

        Public Sub SEL01(ByVal EMpresa As Integer, ByVal paciente As String, ByVal Fecha As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Scrip = "SELECT CO_ID,DO_ABREVIATURA,CO_SDOC,CO_NDOC,CO_FEC_EMI,isnull(CO_TOTAL,0) as 'CO_TOTAL',CO_IDNUM_HIST, " & _
                        "case when CO_IDNUM_HIST IS null then CL_NOMBRE else HC_APE_PAT+' '+ HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2 end[Nombre] " & _
                    "FROM SG_FA_TB_COMPROBANTE_C " & _
                        "INNER JOIN SG_FA_TB_CLIENTE ON CO_IDCLIENTE = CL_ID AND CO_IDEMPRESA = CL_IDEMPRESA   " & _
                        "INNER JOIN SG_FA_TB_DOCUMENTO C ON CO_TDOC = C.DO_CODIGO  AND  CO_IDEMPRESA = C.DO_IDEMPRESA " & _
                        "left join SG_AD_TB_HISTO_CLINI on CO_IDNUM_HIST=HC_NUM_HIST " & _
                    "WHERE CO_ESTADO = 1 and CO_IDEMPRESA =" & EMpresa & " " & paciente + Fecha & " order by 1,2,3 "
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL01Det(ByVal ID As Integer, ByRef oDt As DataTable)
            Dim Scrip As String
            Scrip = "select CD_CANT,AR_DESCRIPCION,CD_SUBTOTAL " & _
                    "from SG_FA_TB_COMPROBANTE_d  " & _
                        "inner join SG_FA_TB_ARTICULO on AR_ID =CD_IDARTICULO  " & _
                    "where CD_IDCAB = " & ID & ""
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Function get_Comprobantes_Cancelados(ByVal empresa_ As Integer, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_COMPRO_X_Credito2", oIdUsuarioActivo, oIdEstacionActiva, empresa_).Tables(0)
        End Function

        Public Function SEL02(numHisto_ As Integer, fec1 As String, fec2 As String, empresa_ As Integer, sinHistoria_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CONS_COMPRO_01", numHisto_, IIf(fec1 = String.Empty, DBNull.Value, fec1), IIf(fec2 = String.Empty, DBNull.Value, fec2), empresa_, sinHistoria_).Tables(0)
        End Function

        Public Function get_adelantos_x_Historia(num_historia_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ADELANTOS_X_HISTO", num_historia_, empresa_).Tables(0)
        End Function

        Public Function get_Comprobante(ByVal Cuenta As Integer, ByVal idempresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_comprobantes", Cuenta, idempresa).Tables(0)
        End Function

    End Class

    Public Class SG_FA_Reportes
        Inherits ClsBD
        Public Function get_ProduccionTratamiento(ByVal empresa_ As Integer, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ProducXTratamiento", empresa_, Fecha1, Fecha2).Tables(0)
        End Function
        Public Function get_ProduccionMedico(ByVal empresa_ As Integer, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_GananciaPorMEdico", empresa_, Fecha1, Fecha2).Tables(0)
        End Function

        Public Function get_ConsumoFarmacia(ByVal Cuenta As Integer, ByVal Tipo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_ConsumoFarm", Tipo, Cuenta).Tables(0)
        End Function

        Public Function get_CAJA01(ByVal mes As Integer, ByVal año As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJA01", empresa_, mes, año).Tables(0)
        End Function

        Public Function get_CAJA_Deta01(ByVal Usuario As Integer, ByVal Fecha As String, ByVal Turno As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_CAJA_DET01", Usuario, Fecha, Turno, empresa_).Tables(0)
        End Function

        Public Function get_Planilla_CajaM(ByVal usuario_ As Integer, ByVal Caja_ As Integer, ByVal turno_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PLANILLA_CAJAM", usuario_, Caja_, turno_, empresa_).Tables(0)
        End Function

        Public Function get_Planilla_CajaB(ByVal usuario_ As Integer, ByVal Caja_ As Integer, ByVal turno_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PLANILLA_CAJAB", usuario_, Caja_, turno_, empresa_).Tables(0)
        End Function

        'Public Function get_Planilla_Caja_superM(ByVal fecha_ As String, ByVal turno_ As String, ByVal empresa_ As Integer) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PLANILLA_CAJA_SUPERM", fecha_, turno_, empresa_).Tables(0)
        'End Function

        Public Function get_Comprobante(ByVal idComprobante_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REP_01", idComprobante_, empresa_).Tables(0)
        End Function

        Public Function get_Comprobante_Drs(ByVal idComprobante_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REP_01_DRS", idComprobante_, empresa_).Tables(0)
        End Function

        Public Function get_Atencion_Seguros_Ambu(ByVal empresa_ As Integer, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REP_02", empresa_, Fecha1, Fecha2).Tables(0)
        End Function

        Public Function get_Atencion_Seguros_Hosp(ByVal empresa_ As Integer, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REP_03", empresa_, Fecha1, Fecha2).Tables(0)
        End Function

        Public Function get_Atencion_comprobantes(ByVal empresa_ As Integer, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Medico As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REP_04", empresa_, Fecha1, Fecha2, Medico).Tables(0)
        End Function

        Public Function get_Atencion_comprobantesT(ByVal empresa_ As Integer, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Destino As Integer, ByVal medico As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REP_05", empresa_, Fecha1, Fecha2, Destino, medico).Tables(0)
        End Function

        Public Function get_Reg_Venta(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REGVENTA", ayo_, mes_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Venta_2(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_REGVENTA_2", ayo_, mes_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Ventas_x_Dia(ByVal fecha_ As Date, ByVal empresa_ As Integer, ByVal usuario_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_VENTAS_X_DIA", fecha_.Year, fecha_.Month, fecha_.Day, empresa_, usuario_).Tables(0)
        End Function

        Public Function get_Reg_Ventas_x_Dia_2(ByVal fecha_ As Date, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_VENTAS_X_DIA_2", fecha_.Year, fecha_.Month, fecha_.Day, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Ventas_x_Cliente(ByVal idCliente_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_VENTAS_X_CLIENTE", idCliente_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_Ventas_x_Cajero(ByVal idCajero_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_VENTAS_X_CAJERO", idCajero_, empresa_).Tables(0)
        End Function

        Public Function get_Reg_RankingVentas(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_RANKING_VENTAS", empresa_).Tables(0)
        End Function

        Public Function get_Planilla_Caja(ByVal usuario_ As Integer, ByVal fecha_ As String, ByVal turno_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PLANILLA_CAJA", usuario_, fecha_, turno_, empresa_).Tables(0)
        End Function

        'Public Function get_Planilla_CajaM(ByVal usuario_ As Integer, ByVal fecha_ As String, ByVal turno_ As String, ByVal empresa_ As Integer) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PLANILLA_CAJAM", usuario_, fecha_, turno_, empresa_).Tables(0)
        'End Function

        Public Function get_Planilla_Caja_super(ByVal fecha_ As String, ByVal turno_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PLANILLA_CAJA_SUPER", fecha_, turno_, empresa_).Tables(0)
        End Function

        'Public Function get_Planilla_Caja_superM(ByVal fecha_ As String, ByVal turno_ As String, ByVal empresa_ As Integer) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_PLANILLA_CAJA_SUPERM", fecha_, turno_, empresa_).Tables(0)
        'End Function

        Public Function get_Detalle_Pago_x_IdCompro(ByVal idComprobnte_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_FA_SP_S_DETALLE_XID", idComprobnte_).Tables(0)
        End Function

    End Class

End Class

