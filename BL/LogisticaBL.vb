Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data
Public Class LogisticaBL

    Public Class SG_LO_TB_ARTICULOS_AREA
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_ARTICULOS_AREA", obe.AA_IDAREA _
            , obe.AA_IDARTICULO _
            , obe.AA_IDEMPRESA _
        )
            Return N
        End Function

        'Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_ARTICULOS_AREA", oIdUsuarioActivo, oIdEstacionActiva _
        '    , obe.AA_IDAREA _
        '    , obe.AR_IDARTICULO _
        '    , obe.AA_IDEMPRESA _
        ')
        '    Return N
        'End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA, ByVal Origen As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_ARTICULOS_AREA", obe.AA_IDEMPRESA _
            , obe.AA_IDAREA _
            , Origen _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS_AREA_1", obe.AA_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA, ByVal Origen As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS_AREA_2", obe.AA_IDEMPRESA, obe.AA_IDAREA, Origen).Tables(0)
        End Function

        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA, ByVal Origen As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS_AREA_3", obe.AA_IDEMPRESA, obe.AA_IDAREA, Origen).Tables(0)
        End Function

        Public Function SEL04(ByVal obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA, ByVal Origen As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS_AREA_4", obe.AA_IDEMPRESA, obe.AA_IDAREA, Origen).Tables(0)
        End Function

    End Class

    Public Class SG_LO_TB_REQUERIMIENTO_C
        Inherits ClsBD
        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_REQUERIMIENTO_C", oIdUsuarioActivo, oIdEstacionActiva _
                        , obe.RC_IDTIPO _
                        , obe.RC_IDUSUARIO _
                        , obe.RC_FECHA_REQ _
                        , obe.RC_NOTA _
                        , obe.RC_IDAREA _
                        , obe.RC_IDCC _
                        , obe.RC_IDPROYECTO _
                        , obe.RC_IDEMPRESA, obe.RC_IDRegistro _
                      )
                obe.RC_ID = N
                For Each d As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_REQUERIMIENTO_D", obe.RC_ID, .RD_ITEM, .RD_IDARTICULO, .RD_CANT, .RD_NOTA)
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

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_U_REQUERIMIENTO_C", oIdUsuarioActivo, oIdEstacionActiva _
                                , obe.RC_ID _
                                , obe.RC_IDTIPO _
                                , obe.RC_IDUSUARIO _
                                , obe.RC_NOTA _
                                , obe.RC_IDPROYECTO _
                                )
                If N <> -2 Then
                    SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_REQUERIMIENTO_D", obe.RC_ID)

                    For Each d As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_REQUERIMIENTO_D", obe.RC_ID, .RD_ITEM, .RD_IDARTICULO, .RD_CANT, .RD_NOTA)
                        End With
                    Next
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_REQUERIMIENTO_C", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RC_ID _
        )
            Return N
        End Function

        'Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C) As SqlDataReader
        '    Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_REQUERIMIENTO_C_1", obe.RC_ID)
        'End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_REQUERIMIENTO_C_1", obe.RC_IDEMPRESA, obe.RC_IDRegistro, obe.RC_IDAREA).Tables(0)
        End Function

        Public Function SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_REQUERIMIENTO_C_2", obe.RC_ID).Tables(0)
        End Function

        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_REQUERIMIENTO_C_3", obe.RC_ID).Tables(0)
        End Function

        Public Function SEL04(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_REQUERIMIENTO_C_4", obe.RC_IDCC).Tables(0)
        End Function

        Public Function SEL05(ByVal IDRegistro As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_REQUERIMIENTO_C_5", IDRegistro).Tables(0)
        End Function

    End Class
    Public Class SG_LO_TB_REQUERIMIENTO_D
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_REQUERIMIENTO_D", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RD_IDCAB _
            , obe.RD_ITEM _
            , obe.RD_IDARTICULO _
            , obe.RD_CANT _
            , obe.RD_ESTADO _
            , obe.RD_NOTA _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_REQUERIMIENTO_D", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RD_IDCAB _
            , obe.RD_ITEM _
            , obe.RD_IDARTICULO _
            , obe.RD_CANT _
            , obe.RD_ESTADO _
            , obe.RD_NOTA _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_REQUERIMIENTO_D", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RD_IDCAB _
            , obe.RD_ITEM _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_REQUERIMIENTO_D_1", obe.RD_IDCAB)
        End Function

        Public Function SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_REQUERIMIENTO_D_2", obe.RD_IDCAB).Tables(0)
        End Function

        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_REQUERIMIENTO_D_3", obe.RD_IDCAB)
        End Function

    End Class




    Public Class SG_LO_TB_FORMA_PRESENTACION
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_PRESENTACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_FORMA_PRESENTACION", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.FP_NOMBRE _
            , obe.FP_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_PRESENTACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_FORMA_PRESENTACION", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.FP_ID _
            , obe.FP_NOMBRE _
            , obe.FP_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_PRESENTACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_FORMA_PRESENTACION", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.FP_ID _
        )
            Return N
        End Function

        'Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_PRESENTACION) As SqlDataReader
        '    Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_FORMA_PRESENTACION_1", obe.FP_ID)
        'End Function

        Public Function SEL01(ByVal IDEmpresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FORMA_PRESENTACION_1", IDEmpresa).Tables(0)
        End Function

        'Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_PRESENTACION) As DataSet
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FORMA_PRESENTACION_3", obe.FP_ID)
        'End Function

    End Class

    Public Class SG_LO_TB_FORMA_FARMACEUTICA
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_FORMA_FARMACEUTICA", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.FF_NOMBRE _
            , obe.FF_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_FORMA_FARMACEUTICA", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.FF_ID _
            , obe.FF_NOMBRE _
            , obe.FF_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_FORMA_FARMACEUTICA", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.FF_ID _
        )
            Return N
        End Function

        'Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA) As SqlDataReader
        '    Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_FORMA_FARMACEUTICA_1", obe.FF_ID)
        'End Function

        Public Function SEL01(ByVal IDEmpresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FORMA_FARMACEUTICA_1", IDEmpresa).Tables(0)
        End Function

        'Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA) As DataSet
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FORMA_FARMACEUTICA_3", obe.FF_ID)
        'End Function

    End Class

    Public Class SG_LO_TB_GENERICO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_GENERICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_GENERICO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.GE_ID _
            , obe.GE_DESCRIPCION _
            , obe.GE_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_GENERICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_GENERICO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.GE_ID _
            , obe.GE_DESCRIPCION _
            , obe.GE_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_GENERICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_GENERICO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.GE_ID _
            , obe.GE_IDEMPRESA _
        )
            Return N
        End Function

        'Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_GENERICO) As SqlDataReader
        '    Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_GENERICO_1", obe.GE_ID)
        'End Function

        Public Function SEL01(ByVal IDEmpresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_GENERICO_1", IDEmpresa).Tables(0)
        End Function

        'Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_GENERICO) As DataSet
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_GENERICO_3", obe.GE_ID)
        'End Function

    End Class

    Public Class SG_LO_TB_SALDOS_C
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_SALDOS_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_SALDOS_D), ByVal TipoCierre As Integer) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim SA_ID As Integer = obe.SA_ID
            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_SALDOS_C", oIdUsuarioActivo, oIdEstacionActiva _
                      , obe.SA_ID _
                      , obe.SA_IDALMACEN _
                      , obe.SA_IDEMPRESA _
                      , TipoCierre _
                      , obe.SA_FECHA_INICIO_INV _
                      )

                obe.SA_ID = N

                For Each d As BE.LogisticaBE.SG_LO_TB_SALDOS_D In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_SALDOS_D", .DS_IDSALDO, .DS_IDLOTE, .DS_IDARTICULO, .DS_INICIAL, .DS_INGRESOS, .DS_SALIDAS, .DS_SALDO, .DS_SALDO_FISICO, .DS_COSTO, obe.SA_IDALMACEN, obe.SA_IDEMPRESA, obe.SA_ID, .Val)
                    End With
                Next
                If TipoCierre = 1 Then
                    SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_MOVIMIENTO_AJUSTES", SA_ID, obe.SA_IDALMACEN, obe.SA_IDEMPRESA)
                End If

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_SALDOS_C, ByVal idarticulo As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_SALDOS_C_2", obe.SA_IDALMACEN, obe.SA_IDEMPRESA, idarticulo)
        End Function

        Public Function SEL01(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_SALDOS_C, ByVal Tipo As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_LISTA_SALDOS", Entidad.SA_IDALMACEN, Entidad.SA_IDEMPRESA, Entidad.SA_ID, Tipo)
        End Function

        Public Function ListaImprimirInv(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_SALDOS_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_LISTA_SALDOS_01", Entidad.SA_IDEMPRESA, Entidad.SA_ID).Tables(0)
        End Function

        Public Function ListaImprimirInv2(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_SALDOS_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_LISTA_SALDOS_02", Entidad.SA_IDEMPRESA, Entidad.SA_ID).Tables(0)
        End Function

        Public Function SEL03(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_SALDOS_C, ByVal Tipo As Integer, ByVal IDEMPRESA As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_SALDOS_C_3", Entidad.SA_IDALMACEN, Entidad.SA_FECHA_APERTURA, Entidad.SA_FECHA_CIERRE, Tipo, IDEMPRESA).Tables(0)
        End Function

        Public Function SEL04(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_SALDOS_C, ByVal mes As String, ByVal ayo As Integer, ByVal IDeMPRES As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_SALDOS_C_4", Entidad.SA_IDALMACEN, mes, ayo, IDeMPRES).Tables(0)
        End Function

        Public Function CentroCosto(ByVal mes As String, ByVal ayo As Integer, ByVal IDeMPRES As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_SALDOS_CentroCosto", IDeMPRES, mes, ayo).Tables(0)
        End Function

        Public Function Rotacion(ByVal mes As String, ByVal ayo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_SALDOS_C_Rotacion", mes, ayo).Tables(0)
        End Function

        Public Function Costo(ByVal IDAlmacen As String, ByVal mes As String, ByVal ayo As Integer, ByVal Motivo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_SALDOS_C_costo", IDAlmacen, mes, ayo, Motivo).Tables(0)
        End Function
        Public Function Costo2(ByVal IDAlmacen As String, ByVal mes As String, ByVal ayo As Integer, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_SALDOS_C_costo2", IDAlmacen, mes, ayo, empresa).Tables(0)
        End Function

        Public Function Consumo(ByVal IDAlmacen As String, ByVal mes As String, ByVal ayo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_SALDOS_C_consumo", IDAlmacen, mes, ayo).Tables(0)
        End Function

        'Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_SALDOS_C) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_LISTA_SALDOS", obe.SA_ID).Tables(0)
        'End Function

    End Class

    Public Class SG_LO_TB_MOTIVO
        Inherits ClsBD

        Public Sub Insert(ByVal e As BE.LogisticaBE.SG_LO_TB_MOTIVO)
            With e
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_MOTIVO", .MT_NOMBRE, .MT_TIPO, .MT_IDEMPRESA, .MT_TVER, .MT_AREA)
            End With
        End Sub

        Public Sub Update(ByVal e As BE.LogisticaBE.SG_LO_TB_MOTIVO)
            With e
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_MOTIVO", .MT_ID, .MT_NOMBRE, .MT_TIPO, .MT_IDEMPRESA, .MT_TVER, .MT_AREA)
            End With
        End Sub

        Public Sub Delete(ByVal e As BE.LogisticaBE.SG_LO_TB_MOTIVO)
            With e
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_MOTIVO", .MT_ID, .MT_IDEMPRESA)
            End With
        End Sub

        Public Function get_Motivos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOTIVO", empresa_).Tables(0)
        End Function

        Public Function get_Motivos_ult_cod(ByVal empresa_ As Integer) As Integer
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_MOTIVO_ULT_COD", empresa_)
        End Function


        'Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_MOTIVO", oIdUsuarioActivo, oIdEstacionActiva _
        '    , obe.MT_NOMBRE _
        '    , obe.MT_TIPO _
        '    , obe.MT_IDEMPRESA _
        '    , obe.MT_TVER _
        ')
        '    Return N
        'End Function

        'Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_MOTIVO", oIdUsuarioActivo, oIdEstacionActiva _
        '    , obe.MT_ID _
        '    , obe.MT_NOMBRE _
        '    , obe.MT_TIPO _
        '    , obe.MT_IDEMPRESA _
        '    , obe.MT_TVER _
        ')
        '    Return N
        'End Function

        'Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_MOTIVO", oIdUsuarioActivo, oIdEstacionActiva _
        '    , obe.MT_ID _
        ')
        '    Return N
        'End Function

        'Public Sub SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO)
        '    Dim drr As SqlDataReader = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_MOTIVO_1", obe.MT_ID)
        '    If drr.HasRows Then
        '        drr.Read()
        '        With obe
        '            .HasRow = True
        '            .MT_NOMBRE = drr("MT_NOMBRE")
        '            .MT_TIPO = drr("MT_TIPO")
        '            .MT_IDEMPRESA = drr("MT_IDEMPRESA")
        '            .MT_TVER = drr("MT_TVER")
        '        End With
        '    End If
        '    drr.Close()
        'End Sub

        Public Function SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOTIVO_2", obe.MT_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOTIVO_3", obe.MT_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL04(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOTIVO_4", obe.MT_IDEMPRESA).Tables(0)
        End Function
        '   Public Sub SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO, ByRef oDt As DataTable)
        '          Dim da As New SqlDataAdapter("SG_LO_SP_S_MOTIVO_2", Cn)
        '          da.Fill(oDt)
        '   End Sub

        'Public Sub SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOTIVO, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_LO_SP_S_MOTIVO_3", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@MT_ID", System.Data.SqlDbType.Int).Value = obe.MT_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_LO_TB_MOVIMIENTOS_C
        Inherits ClsBD
        Public Function Existe_cORRETATIVO(ByVal entidad As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False

            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_NUM_FACTURAS", entidad.MO_TDOC, entidad.MO_SDOC, entidad.MO_NDOC, entidad.MO_IDEMPRESA)

            If int_cantidad > 0 Then
                rpta = True
            End If

            Return rpta

        End Function

        Public Function Insert_porConsumo(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D), ByVal ls_detC As List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_MOVIMIENTOS_C", oIdUsuarioActivo, oIdEstacionActiva _
                        , obe.MO_TDOC _
                        , obe.MO_SDOC _
                        , obe.MO_NDOC _
                        , obe.MO_IDMOTIVO _
                        , obe.MO_IDALMACEN_ORI _
                        , obe.MO_IDALMACEN_DES _
                        , obe.MO_FECHA _
                        , obe.MO_IDEMPRESA _
                        , obe.MO_IDCONSUMO _
                        , obe.MO_IDAREA _
                        , obe.MO_NOTA _
                      )

                obe.MO_ID = N

                For Each d As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_MOVIMIENTOS_D", obe.MO_ID, .MO_IDLOTE, .MO_IDARTICULO, .MO_CANTIDAD)
                    End With
                Next

                SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_CONSUMO_D", obe.MO_IDCONSUMO)

                For Each d As BE.LogisticaBE.SG_LO_TB_CONSUMO_D In ls_detC
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_CONSUMO_D", obe.MO_IDCONSUMO, .DC_ITEM, .DC_IDARTICULO, .DC_IDLOTE, .DC_CANT, .DC_PRECIO, .DC_TOTAL, .DC_SEG_CUBRE)
                    End With
                Next

                Dim queryy As String = "UPDATE SG_LO_TB_CONSUMO_C set CM_ESTADO_DOC = case CM_ESTADO_DOC when 3 then 3 else 2 end where CM_ID= " & obe.MO_IDCONSUMO
                SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, queryy)


                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = obe.MO_NDOC
                Dim numeracionBL As New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
                Dim numeracionBE As New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = obe.MO_TDOC
                numeracionBE.NC_SERIE = obe.MO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = obe.MO_IDEMPRESA
                numeracionBL.Update_2(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Update_porConsumo(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D), ByVal ls_detC As List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D), ByVal TrasAct As Integer) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                If TrasAct = 0 Then
                    Dim queryx As String = "UPDATE SG_LO_TB_MOVIMIENTOS_C set MO_IDCONSUMO = '" & obe.MO_IDCONSUMO & "' where MO_ID= " & obe.MO_ID
                    SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, queryx)

                    Dim queryy As String = "UPDATE SG_LO_TB_CONSUMO_C set CM_Ref_Transferencia='" & obe.MO_ID & "', CM_ESTADO_DOC = case CM_ESTADO_DOC when 3 then 3 else 2 end where CM_ID= " & obe.MO_IDCONSUMO
                    SqlHelper.ExecuteNonQuery(TRvar, CommandType.Text, queryy)
                Else
                    N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_U_MOVIMIENTOS_C", oIdUsuarioActivo, oIdEstacionActiva _
                                          , obe.MO_ID _
                                          , obe.MO_TDOC _
                                          , obe.MO_SDOC _
                                          , obe.MO_NDOC _
                                          , obe.MO_FECHA _
                                          , obe.MO_IDEMPRESA _
                                          , obe.MO_IDCONSUMO _
                                          , obe.MO_NOTA _
                                          )
                    If N <> -2 Then
                        SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_MOVIMIENTOS_D", obe.MO_ID)

                        For Each d As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D In ls_det
                            With d
                                SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_MOVIMIENTOS_D", obe.MO_ID, .MO_IDLOTE, .MO_IDARTICULO, .MO_CANTIDAD)
                            End With
                        Next
                    End If
                End If

                    SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_CONSUMO_D", obe.MO_IDCONSUMO)

                    For Each d As BE.LogisticaBE.SG_LO_TB_CONSUMO_D In ls_detC
                        With d
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_CONSUMO_D", obe.MO_IDCONSUMO, .DC_ITEM, .DC_IDARTICULO, .DC_IDLOTE, .DC_CANT, .DC_PRECIO, .DC_TOTAL, .DC_SEG_CUBRE)
                        End With
                    Next


                    N = 1
                    TRvar.Commit()
                    TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Update_Consumo(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D), ByVal ls_detC As List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                'SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_MOVIMIENTOS_D", obe.MO_ID)

                'For Each d As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D In ls_det
                '    With d
                '        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_MOVIMIENTOS_D", obe.MO_ID, .MO_IDLOTE, .MO_IDARTICULO, .MO_CANTIDAD)
                '    End With
                'Next

                SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_CONSUMO_D", obe.MO_IDCONSUMO)

                For Each d As BE.LogisticaBE.SG_LO_TB_CONSUMO_D In ls_detC
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_CONSUMO_D", obe.MO_IDCONSUMO, .DC_ITEM, .DC_IDARTICULO, .DC_IDLOTE, .DC_CANT, .DC_PRECIO, .DC_TOTAL, .DC_SEG_CUBRE)
                    End With
                Next
                N = 1
                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function


        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_MOVIMIENTOS_C", oIdUsuarioActivo, oIdEstacionActiva _
                        , obe.MO_TDOC _
                        , obe.MO_SDOC _
                        , obe.MO_NDOC _
                        , obe.MO_IDMOTIVO _
                        , obe.MO_IDALMACEN_ORI _
                        , obe.MO_IDALMACEN_DES _
                        , obe.MO_FECHA _
                        , obe.MO_IDEMPRESA _
                        , obe.MO_IDCONSUMO _
                        , obe.MO_IDAREA _
                        , obe.MO_NOTA _
                      )

                obe.MO_ID = N

                For Each d As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_MOVIMIENTOS_D", obe.MO_ID, .MO_IDLOTE, .MO_IDARTICULO, .MO_CANTIDAD)
                    End With
                Next

                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = obe.MO_NDOC
                Dim numeracionBL As New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
                Dim numeracionBE As New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = obe.MO_TDOC
                numeracionBE.NC_SERIE = obe.MO_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = obe.MO_IDEMPRESA
                numeracionBL.Update_2(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_U_MOVIMIENTOS_C", oIdUsuarioActivo, oIdEstacionActiva _
                                            , obe.MO_ID _
                                            , obe.MO_TDOC _
                                            , obe.MO_SDOC _
                                            , obe.MO_NDOC _
                                            , obe.MO_FECHA _
                                            , obe.MO_IDEMPRESA _
                                            , obe.MO_IDCONSUMO _
                                            , obe.MO_NOTA _
                                            )
                'obe.MO_ID = N
                If N <> -2 Then
                    SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_MOVIMIENTOS_D", obe.MO_ID)

                    For Each d As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_MOVIMIENTOS_D", obe.MO_ID, .MO_IDLOTE, .MO_IDARTICULO, .MO_CANTIDAD)
                        End With
                    Next
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_MOVIMIENTOS_C", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.MO_ID _
            , obe.MO_IDEMPRESA _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal Mes As Integer, ByVal Anio As Integer, ByVal iDUsuario As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_1", obe.MO_IDEMPRESA, Mes, Anio, iDUsuario).Tables(0)
        End Function

        Public Function SEL02(ByVal entidad As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False

            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_2", entidad.MO_TDOC, entidad.MO_SDOC, entidad.MO_NDOC, entidad.MO_IDEMPRESA)

            If int_cantidad > 0 Then
                rpta = True
            End If

            Return rpta

        End Function

        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_3", obe.MO_ID).Tables(0)
        End Function

        Public Function SEL04(ByVal consumo As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_4", consumo)
        End Function

        Public Function SEL09(ByVal consumo As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_9", consumo)
        End Function

        Public Function SEL05(ByVal IDMOv As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_5", IDMOv).Tables(0)
        End Function

        Public Function SEL06(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal Excluye As String, ByVal idArticulo As Integer, ByVal FechaI As String, ByVal FechaF As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_6", Entidad.MO_IDALMACEN_ORI, Entidad.MO_IDEMPRESA, Excluye, idArticulo, FechaI, FechaF).Tables(0)
        End Function

        Public Function SEL07(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_7", Entidad.MO_IDALMACEN_ORI, Entidad.MO_IDALMACEN_DES, Entidad.MO_IDEMPRESA).Tables(0)
        End Function
        '   Public Sub SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByRef oDt As DataTable)
        '          Dim da As New SqlDataAdapter("SG_LO_SP_S_MOVIMIENTOS_C_2", Cn)
        '          da.Fill(oDt)
        '   End Sub

        'Public Sub SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_LO_SP_S_MOVIMIENTOS_C_3", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@MO_ID", System.Data.SqlDbType.int).Value = obe.MO_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub
        Public Function SEL08(ByVal obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C, ByVal Mes As Integer, ByVal Anio As Integer, ByVal idusuario As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MOVIMIENTOS_C_8", obe.MO_IDEMPRESA, Mes, Anio, idusuario).Tables(0)
        End Function
    End Class

    Public Class SG_LO_TB_NUM_COMPRO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_NUM_COMPRO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.NC_IDTIPO _
            , obe.NC_SERIE _
            , obe.NC_NUMERO _
            , obe.NC_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_NUM_COMPRO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.NC_IDTIPO _
            , obe.NC_SERIE _
            , obe.NC_NUMERO _
            , obe.NC_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_NUM_COMPRO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.NC_IDTIPO _
            , obe.NC_SERIE _
            , obe.NC_IDEMPRESA _
        )
            Return N
        End Function

        'Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO) As SqlDataReader
        '    Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_NUM_COMPRO_1", obe.NC_IDTIPO)
        'End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_NUM_COMPRO_1", obe.NC_IDEMPRESA).Tables(0)
        End Function
        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_NUM_COMPRO_3", obe.NC_IDEMPRESA, obe.NC_IDTIPO).Tables(0)
        End Function
        'Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO) As DataSet
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_NUM_COMPRO_3", obe.NC_IDTIPO)
        'End Function

        Public Function SEL02(ByVal entidad As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO) As String
            Dim ult_num As String = String.Empty
            ult_num = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_NUM_COMPRO_2", entidad.NC_IDTIPO, entidad.NC_SERIE, entidad.NC_IDEMPRESA)

            ult_num = (CInt(ult_num) + 1).ToString.PadLeft(7, "0")

            Return ult_num

        End Function

        Public Function Update_2(ByVal obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_NUM_COMPRO_2" _
            , obe.NC_IDTIPO _
            , obe.NC_SERIE _
            , obe.NC_NUMERO _
            , obe.NC_IDEMPRESA _
        )
            Return N
        End Function

    End Class

    Public Class SG_LO_TB_USU_ALMACEN
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_USU_ALMACEN, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_USU_ALMACEN", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.UA_IDUSUARIO _
            , obe.UA_IDALMACEN _
            , obe.UA_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_USU_ALMACEN, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_USU_ALMACEN", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.UA_IDUSUARIO _
            , obe.UA_IDALMACEN _
            , obe.UA_IDEMPRESA _
        )
            Return N
        End Function

        'Public Sub SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_USU_ALMACEN)
        '    Dim drr As SqlDataReader = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_USU_ALMACEN_1", obe.UA_IDUSUARIO)
        '    If drr.HasRows Then
        '        drr.Read()
        '        With obe
        '            .HasRow = True
        '            .UA_IDUSUARIO = drr("UA_IDUSUARIO")
        '            .UA_IDALMACEN = drr("UA_IDALMACEN")
        '            .UA_IDEMPRESA = drr("UA_IDEMPRESA")
        '        End With
        '    End If
        '    drr.Close()
        'End Sub

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_USU_ALMACEN) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_USU_ALMACEN_1", obe.UA_IDUSUARIO, obe.UA_IDEMPRESA).Tables(0)
        End Function

        ''   Public Sub SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_USU_ALMACEN, ByRef oDt As DataTable)
        ''          Dim da As New SqlDataAdapter("SG_LO_SP_S_USU_ALMACEN_2", Cn)
        ''          da.Fill(oDt)
        ''   End Sub

        'Public Sub SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_USU_ALMACEN, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_LO_SP_S_USU_ALMACEN_3", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_LO_TB_ALMACEN_SERIE
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_ALMACEN_SERIE", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.AS_IDALMACEN _
            , obe.AS_SERIE _
            , obe.AS_IDEMPRESA _
            , obe.AS_TDOC _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_ALMACEN_SERIE", oIdUsuarioActivo, oIdEstacionActiva _
                                           , obe.AS_IDALMACEN _
                                            , obe.AS_SERIE _
                                            , obe.AS_IDEMPRESA _
                                            , obe.AS_TDOC _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN_SERIE_1", obe.AS_IDALMACEN, obe.AS_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN_SERIE_2", obe.AS_IDALMACEN, obe.AS_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN_SERIE_3", obe.AS_IDALMACEN, obe.AS_TDOC, obe.AS_IDEMPRESA).Tables(0)
        End Function
        Public Function SEL04(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN_SERIE_4", obe.AS_IDEMPRESA).Tables(0)
        End Function
        Public Function SEL05(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN_SERIE_5", obe.AS_TDOC, obe.AS_IDEMPRESA).Tables(0)
        End Function
    End Class


    Public Class SG_LO_TB_ORIGEN
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_ORIGEN, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_ORIGEN", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.OR_ID _
            , obe.OR_NOMBRE _
            , obe.OR_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_ORIGEN, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_ORIGEN", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.OR_ID _
            , obe.OR_NOMBRE _
            , obe.OR_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_ORIGEN, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_ORIGEN", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.OR_ID _
            , obe.OR_IDEMPRESA _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_ORIGEN) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ORIGEN_1", obe.OR_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL02(ByVal idempres As Integer, ByVal articulo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ORIGEN_2", idempres, articulo).Tables(0)
        End Function

        '   Public Sub SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_ORIGEN, ByRef oDt As DataTable)
        '          Dim da As New SqlDataAdapter("SG_LO_SP_S_ORIGEN_2", Cn)
        '          da.Fill(oDt)
        '   End Sub

        'Public Sub SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_ORIGEN, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_LO_SP_S_ORIGEN_3", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@OR_ID", System.Data.SqlDbType.Char).Value = obe.OR_ID
        '    cmd.Parameters.Add("@OR_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.OR_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_LO_TB_PROVE_COMUNI
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_PROVE_COMUNI", .CC_IDPROVE, .CC_IDCOMUNICA, .CC_DESCRIPCION)
            End With
        End Sub

        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI)
            SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_PROVE_COMUNI", entidad.CC_IDPROVE)
        End Sub

        Public Function get_Comunicaciones_x_Id(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PROVE_COMUNI_BYID", entidad.CC_IDPROVE).Tables(0)
        End Function

    End Class
    Public Class SG_LO_TB_TIPO_COMUNICACION
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_COMUNICACION)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_TIPO_COMUNICACION", .TC_ID, .TC_DESCRIPCION, .TC_IDEMPRESA)
            End With
        End Sub

        Public Sub Update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_COMUNICACION)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_TIPO_COMUNICACION", .TC_ID, .TC_DESCRIPCION, .TC_IDEMPRESA)
            End With
        End Sub

        Public Sub Delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_COMUNICACION)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_TIPO_COMUNICACION", .TC_ID, .TC_IDEMPRESA)
            End With
        End Sub

        Public Function get_Tipos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_COMUNICACION", empresa_).Tables(0)
        End Function

        Public Function get_Tipos_x_Id(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_COMUNICACION) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_COMU_BYID", entidad.TC_ID, entidad.TC_IDEMPRESA).Tables(0)
        End Function

        Public Function get_ult_cod(ByVal empresa_ As Integer) As Integer
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_TIPO_COMU_ULT_COD", empresa_)
        End Function

    End Class

    Public Class SG_LO_TB_PROVEEDOR
        Inherits ClsBD

        Public Sub Insert(ByRef entidad As BE.LogisticaBE.SG_LO_TB_PROVEEDOR, ByVal lista As List(Of BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI))
            With entidad
                entidad.PR_ID = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_I_PROVEEDOR", .PR_DESCRIPCION, .PR_TDOC, .PR_NDOC, .PR_DIRECCION, .PR_ES_RELACIONADO, .PR_IDPAIS, .PR_DIR_WEB, .PR_ESTADO, .PR_NOTAS, .PR_USUARIO, .PR_TERMINAL, .PR_FECREG, .PR_IDEMPRESA, .PR_IDANEXO_CONTA)
            End With

            For Each item As BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI In lista
                With item
                    SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_PROVE_COMUNI", entidad.PR_ID, .CC_IDCOMUNICA, .CC_DESCRIPCION)
                End With
            Next

            'grabamos en contabilidad
            Dim tipoDocConta As Integer

            Dim documentoBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCU_PERSO
            Dim documentoBE As New BE.LogisticaBE.SG_LO_TB_TIPO_DOCU_PERSO
            Dim drr As SqlDataReader
            documentoBE.DO_IDEMPRESA = entidad.PR_IDEMPRESA
            documentoBE.DO_CODIGO = entidad.PR_TDOC
            drr = documentoBL.get_Docu_x_id(documentoBE)
            documentoBE = Nothing
            documentoBL = Nothing


            If drr.HasRows Then
                drr.Read()
                tipoDocConta = drr("DO_COD_CONTA")
            End If
            drr.Close()
            drr = Nothing

            'verificamos is existe en anexos contables
            Dim dr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_ANEXO_BY_DOC", tipoDocConta, entidad.PR_NDOC, 2, entidad.PR_IDEMPRESA)
            If Not dr.HasRows Then
                dr.Close()
                entidad.PR_IDANEXO_CONTA = SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_I_ANEXO_X_LOGIS", 2, 2, tipoDocConta, entidad.PR_NDOC, entidad.PR_DESCRIPCION, entidad.PR_USUARIO, _
                                            entidad.PR_TERMINAL, entidad.PR_FECREG, entidad.PR_IDEMPRESA, entidad.PR_ES_RELACIONADO)

                SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "UPDATE SG_LO_TB_PROVEEDOR SET PR_IDANEXO_CONTA = " & entidad.PR_IDANEXO_CONTA & " WHERE PR_ID = " & entidad.PR_ID)
            Else
                dr.Read()
                entidad.PR_IDANEXO_CONTA = dr("AN_IDANEXO")
                dr.Close()
                SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "UPDATE SG_LO_TB_PROVEEDOR SET PR_IDANEXO_CONTA = " & entidad.PR_IDANEXO_CONTA & " WHERE PR_ID = " & entidad.PR_ID)
            End If

            dr = Nothing

        End Sub

        Public Sub Update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROVEEDOR, ByVal lista As List(Of BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI))
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_PROVEEDOR", .PR_ID, .PR_DESCRIPCION, .PR_TDOC, .PR_NDOC, .PR_DIRECCION, .PR_ES_RELACIONADO, .PR_IDPAIS, .PR_DIR_WEB, .PR_ESTADO, .PR_NOTAS, .PR_USUARIO, .PR_TERMINAL, .PR_FECREG, .PR_IDEMPRESA, .PR_IDANEXO_CONTA)
            End With

            If lista.Count > 0 Then
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_PROVE_COMUNI", lista(0).CC_IDPROVE)
            End If

            For Each item As BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI In lista
                With item
                    SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_PROVE_COMUNI", .CC_IDPROVE, .CC_IDCOMUNICA, .CC_DESCRIPCION)
                End With
            Next

        End Sub

        Public Sub Delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROVEEDOR)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_PROVEEDOR", .PR_ID)
            End With
        End Sub

        Public Function get_Proveedores(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PROVEEDOR", empresa_).Tables(0)
        End Function

        Public Function get_Proveedores_x_Id(ByVal idProve_ As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_PROVEEDOR_BYID", idProve_)
        End Function

        Public Function get_Proveedores_x_numeroDoc(ByVal numdoc_ As String, ByVal empresa As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_PROVEEDOR_BYID2", numdoc_, empresa)
        End Function

        Public Function get_Proveedores_ayuda(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_LIS_AYU_PROVE_01", empresa_).Tables(0)
        End Function

        Public Function get_Proveedores_cmb(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_LIS_AYU_PROVE_02", empresa_).Tables(0)
        End Function

    End Class
    Public Class SG_LO_TB_TIPO_DOCU_PERSO
        Inherits ClsBD

        Public Function get_Documentos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_DOCU_PERSO", empresa_).Tables(0)
        End Function

        Public Function get_Documentos_cmb(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPDOCPERO_CMB01", empresa_).Tables(0)
        End Function

        Public Function get_Docu_x_id(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_DOCU_PERSO) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_TIPO_DOC_PERSO_BYID", entidad.DO_CODIGO, entidad.DO_IDEMPRESA)
        End Function


    End Class

    Public Class SG_LO_TB_ARTICULO
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ARTICULO, ByVal ls_imgs As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO_IMG), ByVal ls_Ori As List(Of BE.LogisticaBE.SG_LO_TB_ORIGEN))

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    .AR_ID = SqlHelper.ExecuteScalar(tr, "SG_LO_SP_I_ARTICULO_L", .AR_CODIGO, .AR_CODIGO_ALT, .AR_DESCRIPCION, _
                    .AR_PRECIO_VENTA, _
                    IIf(.AR_IDFAMILIA = String.Empty, DBNull.Value, .AR_IDFAMILIA), _
                    IIf(.AR_IDCATEGORIA = String.Empty, DBNull.Value, .AR_IDCATEGORIA), _
                    .AR_NUM_CTA_CONTA, .AR_ESTADO, .AR_IDEMPRESA, .AR_USUARIO, .AR_TERMINAL, .AR_FECREG, _
                    .AR_TIPO_ARTI, .AR_INCLUYE_IGV, .AR_ING_RAP, .AR_MON_VTA, .AR_CTRL_STOCK, .AR_ORIGEN, _
                    IIf(.AR_IDPROVEEDOR = 0, DBNull.Value, .AR_IDPROVEEDOR), _
                    IIf(.AR_IDGRUPO = 0, DBNull.Value, .AR_IDGRUPO), _
                    IIf(.AR_IDUBICACION = 0, DBNull.Value, .AR_IDUBICACION), _
                    IIf(.AR_IDPAIS = 0, DBNull.Value, .AR_IDPAIS), _
                    IIf(.AR_IDFABRICANTE = 0, DBNull.Value, .AR_IDFABRICANTE), _
                    .AR_MODELO, _
                    IIf(.AR_MARCA = 0, DBNull.Value, .AR_MARCA), _
                    IIf(.AR_UM_COMPRA = String.Empty, DBNull.Value, .AR_UM_COMPRA), _
                    IIf(.AR_UM_VENTA = String.Empty, DBNull.Value, .AR_UM_VENTA), _
                    IIf(.AR_UM_DISTRI = String.Empty, DBNull.Value, .AR_UM_DISTRI), _
                    .AR_CANT_UMC, .AR_COLOR, .AR_PESO, _
                    IIf(.AR_UM_PESO = String.Empty, DBNull.Value, .AR_UM_PESO), _
                    .AR_STOCK_MIN, _
                    .AR_PRECIO_COMPRA, IIf(.AR_IDGENERICO = 0, DBNull.Value, .AR_IDGENERICO), _
                    .AR_CUM, .AR_ATC, IIf(.AR_TIPO_MED = String.Empty, DBNull.Value, .AR_TIPO_MED), _
                    IIf(.AR_IDFORMA_F = 0, DBNull.Value, .AR_IDFORMA_F), IIf(.AR_IDFORMA_P = 0, DBNull.Value, .AR_IDFORMA_P), _
                    .AR_SIN_IGV)

                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, "UPDATE SG_FA_TB_ARTICULO SET AR_CODIGO = '" & .AR_ID & "' WHERE AR_ID = " & .AR_ID)
                End With

                For Each img As BE.LogisticaBE.SG_LO_TB_ARTICULO_IMG In ls_imgs
                    SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_ARTICULO_IMG", entidad.AR_ID, img.AI_ITEM, img.AI_DESCRIPCION, img.AI_IMG)
                Next

                For Each ori As BE.LogisticaBE.SG_LO_TB_ORIGEN In ls_Ori
                    SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_ARTICULO_ORI", entidad.AR_ID, ori.OR_ID, entidad.AR_IDEMPRESA)
                Next

                tr.Commit()
                tr.Dispose()

            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ARTICULO, ByVal ls_imgs As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO_IMG), ByVal ls_Ori As List(Of BE.LogisticaBE.SG_LO_TB_ORIGEN))

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_U_ARTICULO_L", .AR_ID, .AR_CODIGO, .AR_CODIGO_ALT, .AR_DESCRIPCION, .AR_PRECIO_VENTA, _
                    IIf(.AR_IDFAMILIA = String.Empty, DBNull.Value, .AR_IDFAMILIA), _
                    IIf(.AR_IDCATEGORIA = String.Empty, DBNull.Value, .AR_IDCATEGORIA), _
                    .AR_NUM_CTA_CONTA, .AR_ESTADO, .AR_IDEMPRESA, .AR_USUARIO, .AR_TERMINAL, .AR_FECREG, _
                    .AR_TIPO_ARTI, .AR_INCLUYE_IGV, .AR_ING_RAP, .AR_MON_VTA, .AR_CTRL_STOCK, .AR_ORIGEN, _
                    IIf(.AR_IDPROVEEDOR = 0, DBNull.Value, .AR_IDPROVEEDOR), _
                    IIf(.AR_IDGRUPO = 0, DBNull.Value, .AR_IDGRUPO), _
                    IIf(.AR_IDUBICACION = 0, DBNull.Value, .AR_IDUBICACION), _
                    IIf(.AR_IDPAIS = 0, DBNull.Value, .AR_IDPAIS), _
                    IIf(.AR_IDFABRICANTE = 0, DBNull.Value, .AR_IDFABRICANTE), .AR_MODELO, _
                    IIf(.AR_MARCA = 0, DBNull.Value, .AR_MARCA), _
                    IIf(.AR_UM_COMPRA = String.Empty, DBNull.Value, .AR_UM_COMPRA), _
                    IIf(.AR_UM_VENTA = String.Empty, DBNull.Value, .AR_UM_VENTA), _
                    IIf(.AR_UM_DISTRI = String.Empty, DBNull.Value, .AR_UM_DISTRI), .AR_CANT_UMC, .AR_COLOR, .AR_PESO, _
                    IIf(.AR_UM_PESO = String.Empty, DBNull.Value, .AR_UM_PESO), .AR_STOCK_MIN, _
                    .AR_PRECIO_COMPRA, IIf(.AR_IDGENERICO = 0, DBNull.Value, .AR_IDGENERICO), _
                    .AR_CUM, .AR_ATC, IIf(.AR_TIPO_MED = String.Empty, DBNull.Value, .AR_TIPO_MED), _
                    IIf(.AR_IDFORMA_F = 0, DBNull.Value, .AR_IDFORMA_F), IIf(.AR_IDFORMA_P = 0, DBNull.Value, .AR_IDFORMA_P), _
                    .AR_SIN_IGV)
                    'SqlHelper.ExecuteNonQuery(tr, CommandType.Text, "UPDATE SG_FA_TB_ARTICULO SET AR_CODIGO = '" & .AR_ID & "' WHERE AR_ORIGEN = 'LO' and  AR_ID = " & .AR_ID)
                End With


                SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_D_ARTICULO_IMG", entidad.AR_ID)

                For Each img As BE.LogisticaBE.SG_LO_TB_ARTICULO_IMG In ls_imgs
                    SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_ARTICULO_IMG", entidad.AR_ID, img.AI_ITEM, img.AI_DESCRIPCION, img.AI_IMG)
                Next

                SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_D_ARTICULO_ORI", entidad.AR_ID)

                For Each ori As BE.LogisticaBE.SG_LO_TB_ORIGEN In ls_Ori
                    SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_ARTICULO_ORI", entidad.AR_ID, ori.OR_ID, entidad.AR_IDEMPRESA)
                Next

                tr.Commit()
                tr.Dispose()

            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub

        Public Function get_Articulos_Ayuda(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTI_AYUDA", empresa_).Tables(0)
        End Function

        Public Function get_Articulos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS", empresa_).Tables(0)
        End Function

        Public Function get_Articulos_x_id(ByVal idarticulo_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS_BYID", idarticulo_, empresa_).Tables(0)
        End Function

        Public Function get_Articulos_x_Codigo(ByVal CODarticulo_ As String, ByVal empresa_ As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_ARTICULOS_BYCODIGO", CODarticulo_, empresa_)
        End Function

        Public Function get_Articulos_IMG(ByVal IDArticulo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULO_IMG", IDArticulo_).Tables(0)
        End Function

        Public Function get_Articulos_Ayuda(ByVal empresa_ As Integer, ByVal igv As Integer, ByVal idalmacen As String, ByVal idseguro As String, ByVal TipoAtencion As Integer) As DataTable
            '@P_Tipo int--1=ambulatoria,2=hospi,3=clinica
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULO_01", empresa_, igv, idalmacen, idseguro, TipoAtencion).Tables(0)
        End Function

        Public Function get_Articulos_generico(ByVal empresa_ As Integer, ByVal generico As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS_02", empresa_, generico).Tables(0)
        End Function

        Public Function get_Saldo_X_Articulo(ByVal empresa_ As Integer, ByVal IDAlmacen As String, ByVal IDarticulo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ARTICULOS_Stock", empresa_, IDAlmacen, IDarticulo).Tables(0)
        End Function
    End Class
    Public Class SG_LO_TB_FORMA_PAGO
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_FORMA_PAGO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_FORMA_PAGO", .id, .descripcion, .dia, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_FORMA_PAGO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_FORMA_PAGO", .id, .descripcion, .dia, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_FORMA_PAGO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_FORMA_PAGO", .id, .empresa)
            End With
        End Sub
        Public Function get_fpgrilla(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FORMA_PAGO2", empresa).Tables(0)
        End Function
        Public Function get_fpvali(ByVal empresa As Integer, ByVal id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FORMA_PAGO3", empresa, id).Tables(0)
        End Function
        Public Function get_Formas(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FORMA_PAGO", empresa_).Tables(0)
        End Function

        Public Function get_Ult_cod_forma_pago(empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_COD_FOR_PAG", empresa_)
        End Function

    End Class
    Public Class SG_LO_TB_TIPO_DOCUMENTO
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_TIPO_DOCUMENTO", .id, .descripcion, .cod_conta, .estado, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_TIPO_DOCUMENTO", .id, .descripcion, .cod_conta, .estado, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_DOCUMENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_TIPO_DOCUMENTO", .id, .empresa)
            End With
        End Sub
        Public Function get_val(ByVal empresa_ As Integer, ByVal id As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_DOCUMENTO2", empresa_, id).Tables(0)
        End Function
        Public Function get_ListaDoc(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_DOCUMENTO4", empresa_).Tables(0)
        End Function
        Public Function get_grilla(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_DOCUMENTO3", empresa_).Tables(0)
        End Function
        Public Function get_Documentos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_DOCUMENTO", empresa_).Tables(0)
        End Function
    End Class
    Public Class SG_LO_TB_MONEDA
        Inherits ClsBD

        Public Function get_Monedas(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MONEDA", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_LO_TB_CONSUMO_C
        Inherits ClsBD
        Public Function Insert_BEBE(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_CONSUMO_C", oIdUsuarioActivo, oIdEstacionActiva _
                      , obe.CM_TDOC _
                      , obe.CM_SDOC _
                      , obe.CM_NDOC _
                      , obe.CM_IDALMACEN _
                      , obe.CM_IDCUENTA _
                      , obe.CM_IDNUM_HIST _
                      , obe.CM_TOTAL _
                      , obe.CM_FECHA _
                      , obe.CM_IDEMPRESA _
                      , obe.CM_IDREGISTRO _
                      )
                obe.CM_ID = N

                For Each d As BE.LogisticaBE.SG_LO_TB_CONSUMO_D In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_CONSUMO_D_sin_mov", obe.CM_ID, .DC_ITEM, .DC_IDARTICULO, .DC_IDLOTE, .DC_CANT, .DC_PRECIO, .DC_TOTAL, .DC_SEG_CUBRE)
                    End With
                Next

                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = obe.CM_NDOC
                Dim numeracionBL As New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
                Dim numeracionBE As New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = obe.CM_TDOC
                numeracionBE.NC_SERIE = obe.CM_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = obe.CM_IDEMPRESA
                numeracionBL.Update_2(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Insert(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_CONSUMO_C", oIdUsuarioActivo, oIdEstacionActiva _
                      , obe.CM_TDOC _
                      , obe.CM_SDOC _
                      , obe.CM_NDOC _
                      , obe.CM_IDALMACEN _
                      , obe.CM_IDCUENTA _
                      , obe.CM_IDNUM_HIST _
                      , obe.CM_TOTAL _
                      , obe.CM_FECHA _
                      , obe.CM_IDEMPRESA, 0 _
                      )
                obe.CM_ID = N

                For Each d As BE.LogisticaBE.SG_LO_TB_CONSUMO_D In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_CONSUMO_D", obe.CM_ID, .DC_ITEM, .DC_IDARTICULO, .DC_IDLOTE, .DC_CANT, .DC_PRECIO, .DC_TOTAL, .DC_SEG_CUBRE)
                    End With
                Next


                'actualizamos el correlativo de la tabla numeracion de comprobantes
                Dim nuevo_num As String = obe.CM_NDOC
                Dim numeracionBL As New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
                Dim numeracionBE As New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO

                numeracionBE.NC_IDTIPO = obe.CM_TDOC
                numeracionBE.NC_SERIE = obe.CM_SDOC
                numeracionBE.NC_NUMERO = nuevo_num
                numeracionBE.NC_IDEMPRESA = obe.CM_IDEMPRESA
                numeracionBL.Update_2(numeracionBE)

                numeracionBE = Nothing
                numeracionBL = Nothing


                '  SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_I_CONSUMO_C", oIdUsuarioActivo, oIdEstacionActiva)

                TRvar.Commit()
                TRvar.Dispose()


            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Update_bebe(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_U_CONSUMO_C", oIdUsuarioActivo, oIdEstacionActiva _
                                            , obe.CM_ID _
                                            , obe.CM_TDOC _
                                            , obe.CM_SDOC _
                                            , obe.CM_NDOC _
                                            , obe.CM_IDALMACEN _
                                            , obe.CM_IDCUENTA _
                                            , obe.CM_IDNUM_HIST _
                                            , obe.CM_TOTAL _
                                            , obe.CM_IDEMPRESA _
                                            )
                ' obe.CM_ID = N
                If N <> -2 Then
                    SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_CONSUMO_D", obe.CM_ID)

                    For Each d As BE.LogisticaBE.SG_LO_TB_CONSUMO_D In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_CONSUMO_D_sin_mov", obe.CM_ID, .DC_ITEM, .DC_IDARTICULO, .DC_IDLOTE, .DC_CANT, .DC_PRECIO, .DC_TOTAL, .DC_SEG_CUBRE)
                        End With
                    Next
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Update(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_U_CONSUMO_C", oIdUsuarioActivo, oIdEstacionActiva _
                                            , obe.CM_ID _
                                            , obe.CM_TDOC _
                                            , obe.CM_SDOC _
                                            , obe.CM_NDOC _
                                            , obe.CM_IDALMACEN _
                                            , obe.CM_IDCUENTA _
                                            , obe.CM_IDNUM_HIST _
                                            , obe.CM_TOTAL _
                                            , obe.CM_IDEMPRESA _
                                            )
                ' obe.CM_ID = N
                If N <> -2 Then
                    SqlHelper.ExecuteScalar(TRvar, "SG_LO_SP_D_CONSUMO_D", obe.CM_ID)

                    For Each d As BE.LogisticaBE.SG_LO_TB_CONSUMO_D In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_LO_SP_I_CONSUMO_D", obe.CM_ID, .DC_ITEM, .DC_IDARTICULO, .DC_IDLOTE, .DC_CANT, .DC_PRECIO, .DC_TOTAL, .DC_SEG_CUBRE)
                        End With
                    Next
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                TRvar.Rollback()
                Throw ex
            End Try

            Return N
        End Function

        Public Function Delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_CONSUMO_C", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.CM_ID _
            , obe.CM_IDEMPRESA)

            Return N
        End Function

        Public Function Delete2(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal ID_Articulo As Integer) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_CONSUMO_D2", obe.CM_ID _
            , ID_Articulo _
        )
            Return N
        End Function

        Public Function Cambio(ByVal IDCuenta As Integer, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal idCuentaNueva As Integer) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_U_CONSUMO_C2", oIdUsuarioActivo, oIdEstacionActiva _
            , IDCuenta, idCuentaNueva _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal usu As Integer, ByVal mes As Integer, ByVal anio As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_1", obe.CM_IDEMPRESA, usu, mes, anio).Tables(0)
        End Function

        Public Function SEL02(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_2", obe.CM_IDEMPRESA, obe.CM_IDALMACEN, obe.CM_IDREGISTRO).Tables(0)
        End Function

        Public Function SEL03(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_D, ByVal Tipo As Integer, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_3", obe.DC_IDCONSUMO, Tipo, empresa).Tables(0)
        End Function

        Public Function SEL04(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal mes As Integer, ByVal anio As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_4", obe.CM_IDEMPRESA, mes, anio).Tables(0)
        End Function

        Public Function SEL05(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal IGV As Decimal, ByVal CubreNo As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_5", obe.CM_IDCUENTA, IGV, CubreNo).Tables(0)
        End Function

        Public Function SEL06(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C, ByVal SegC As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_6", obe.CM_IDCUENTA, obe.CM_IDALMACEN, SegC).Tables(0)
        End Function

        Public Function SEL07(ByVal obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_7", obe.CM_IDCUENTA).Tables(0)
        End Function

        Public Function SEL08(ByVal idEmpresa As Integer, ByVal IDRegistro As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CONSUMO_C_8", idEmpresa, IDRegistro).Tables(0)
        End Function

        Public Function Existe_Transferencia(ByVal IdConsumo As Integer) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False
            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_LO_NUM_Transferencia_Consumo", IdConsumo)
            If int_cantidad > 0 Then
                rpta = True
            End If
            Return rpta
        End Function

    End Class

    Public Class SG_LO_TB_COMPROBANTES_CAB
        Inherits ClsBD
        Public Function Existe_Comprobante(ByVal entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB) As Boolean
            Dim int_cantidad As Integer = 0
            Dim rpta As Boolean = False

            int_cantidad = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_NUM_COMPRAS", entidad.CO_TDOC, entidad.CO_SDOC, entidad.CO_NDOC, entidad.CO_IDPROVE, entidad.CO_IDEMPRESA)

            If int_cantidad > 0 Then
                rpta = True
            End If

            Return rpta

        End Function
        Public Function get_ComprobanteImprimir(ByVal idComprobante_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_COMPROBANTES_CAB_imp", idComprobante_, empresa_).Tables(0)
        End Function

        'Public Sub Insert_L(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB, ByVal idempresa As Integer, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET))

        '    If Cn.State = ConnectionState.Open Then Cn.Close()
        '    If Cn.State = ConnectionState.Closed Then Cn.Open()

        '    Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

        '    Try
        '        With Entidad
        '            Entidad.CO_ID = SqlHelper.ExecuteScalar(tr, "SG_LO_SP_I_COMPROBANTES_CAB_L", .CO_FEC_DOC, .CO_IDPROVE, .CO_TDOC, .CO_SDOC, .CO_NDOC, .CO_FDOC, .CO_VDOC, .CO_IDMONEDA, .CO_IDFORMA_PAGO, .CO_TC, .CO_FECHA_ENT, .CO_COMENTARIO, .CO_IDAUTORIZADO, .CO_HOR_ENT, .CO_DIR_ENT, .CO_ESTADO, .CO_SUBTOTAL, .CO_DESCUENTO, .CO_IGV, .CO_TOTAL, .CO_USUARIO, .CO_TERMINAL, .CO_IDORDCOM, .CO_IDEMPRESA, .CO_NOTAS, _
        '                                                    IIf(.CO_TDOC_REF = String.Empty, DBNull.Value, .CO_TDOC_REF), _
        '                                                    .CO_SDOC_REF, .CO_NDOC_REF)

        '        End With

        '        For Each d As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET In ls_det
        '            With d
        '                SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_COMPROBANTES_DET", Entidad.CO_ID, .DE_ITEM, .DE_IDARTICULO, .DE_IDUM, .DE_IDUM_V, .DE_CANT, .DE_CANT_V, .DE_PRECIO, .DE_DESCUENTO, .DE_IGV, .DE_SUBTOTAL, .DE_TOTAL, .DE_ESTADO, .DE_COMENTARIO, .DE_IDLOTE, _
        '                                          IIf(.DE_FEC_LOT = String.Empty, DBNull.Value, .DE_FEC_LOT), idempresa, 0)
        '            End With
        '        Next




        '        '-------------------------------------------------------------
        '        tr.Commit()
        '        tr.Dispose()
        '    Catch ex As Exception
        '        tr.Rollback()
        '        Throw ex
        '    End Try
        'End Sub

        Public Sub Insert_STEM(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB, ByVal idempresa As Integer, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET), ByRef Str_NumVoucher As String, ByRef Int_Idcompra_ As String, ByVal TipoMov As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

            Try
                With Entidad
                    Entidad.CO_ID = SqlHelper.ExecuteScalar(tr, "SG_LO_SP_I_COMPROBANTES_CAB_STEM", .CO_FEC_DOC, .CO_IDPROVE, .CO_TDOC, .CO_SDOC, .CO_NDOC, .CO_FDOC, .CO_VDOC, .CO_IDMONEDA, .CO_IDFORMA_PAGO, .CO_TC, .CO_FECHA_ENT, .CO_COMENTARIO, .CO_SUBTOTAL, .CO_DESCUENTO, .CO_IGV, .CO_TOTAL, .CO_USUARIO, .CO_TERMINAL, .CO_IDEMPRESA, .CO_NOTAS, _
                                                            IIf(.CO_TDOC_REF = String.Empty, DBNull.Value, .CO_TDOC_REF), _
                                                            .CO_SDOC_REF, .CO_NDOC_REF, TipoMov, .CO_INCLUYE_IGV)
                    Int_Idcompra_ = Entidad.CO_ID
                End With
                If Entidad.CO_ID > 0 Then
                    For Each d As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_COMPROBANTES_DET", Entidad.CO_ID, .DE_ITEM, .DE_IDARTICULO, .DE_IDUM, .DE_IDUM_V, .DE_CANT, .DE_CANT_V, .DE_PRECIO, .DE_DESCUENTO, .DE_IGV, .DE_SUBTOTAL, .DE_TOTAL, .DE_ESTADO, .DE_COMENTARIO, .DE_IDLOTE, _
                                                      IIf(.DE_FEC_LOT = String.Empty, DBNull.Value, .DE_FEC_LOT), idempresa, TipoMov)
                        End With
                    Next
                    If CDate(Entidad.CO_FDOC) >= CDate("22/05/2015") Then

                        'Inicio Contabilidad : __________________________________________________

                        Dim IDCompra As Integer = 0
                        Dim IdSubdiario As String = "01"
                        Dim empresa As Integer = idempresa
                        Dim ayo As Integer = CDate(Entidad.CO_FEC_DOC).Year
                        Dim mes As Integer = CDate(Entidad.CO_FEC_DOC).Month
                        Dim glosa As String = Entidad.CO_NOTAS
                        Dim moneda As String = "1"
                        Dim Int_TipoAnex As Integer = 2 'proveedor
                        Dim Int_CodAnex As Integer = 0 'codigo de anexo
                        Dim Str_DesAnex As String = "" 'Descripcion de anexo


                        'buscamos el anexo contable 
                        Int_CodAnex = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(PR_IDANEXO_CONTA,0) FROM SG_LO_TB_PROVEEDOR WHERE PR_ID  =  " & Entidad.CO_IDPROVE.ToString)
                        Str_DesAnex = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(PR_DESCRIPCION,'') FROM SG_LO_TB_PROVEEDOR WHERE PR_ID  =  " & Entidad.CO_IDPROVE.ToString)


                        'Obtenemos ultimo numero de voucher de compras
                        Str_NumVoucher = SqlHelper.ExecuteScalar(tr, "SG_CO_SP_C_ULT_NUM_VOU", ayo, mes, IdSubdiario, empresa)

                        'grabamos la cabecera del asiento contable
                        IDCompra = SqlHelper.ExecuteScalar(tr, "SG_CO_SP_I_ASIENTO_CAB", IdSubdiario, _
                                                          Str_NumVoucher, ayo, mes, Entidad.CO_FDOC, _
                                                          moneda, Entidad.CO_TOTAL, Entidad.CO_TOTAL, Entidad.CO_TC, _
                                                          0, 1, Str_DesAnex & " " & glosa, 1, 2, Entidad.CO_USUARIO, _
                                                          Entidad.CO_TERMINAL, Now, empresa)



                        'grabamos cabecera de compras(reg. de compras)



                        Dim Str_TDoc As String = String.Empty 'tipo de doc
                        Dim Str_TDocRef As String = String.Empty 'tipo de doc ref
                        Dim indicador = "01"
                        Dim monto_exone As Double = 0
                        Dim tasa_isc As Double = 0
                        Dim monto_isc As Double = 0
                        Dim otros_tributos As Double = 0
                        Dim es_afec_detra As Integer = 0
                        Dim tasa_detra As Double = 0
                        Dim impor_detra As Double = 0
                        Dim num_detra As String = ""
                        Dim es_afec_percep As Integer = 0
                        Dim estado As Integer = 1



                        'buscamos el cod. conta del doc. del comprobante
                        Str_TDoc = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(TD_COD_CONTA,0) FROM SG_LO_TB_TIPO_DOCUMENTO WHERE TD_IDEMPRESA = " & empresa & " AND TD_ID = '" & Entidad.CO_TDOC & "'")
                        If Entidad.CO_TDOC = "NC" Then
                            Str_TDocRef = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(TD_COD_CONTA,0) FROM SG_LO_TB_TIPO_DOCUMENTO WHERE TD_IDEMPRESA = " & empresa & " AND TD_ID = '" & Entidad.CO_TDOC_REF & "'")
                        End If



                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_COMPRAS", IDCompra, Int_TipoAnex, Int_CodAnex,
                                                  Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, indicador, Entidad.CO_FDOC, Entidad.CO_VDOC, Entidad.CO_FDOC, _
                                                  IIf(Str_TDocRef.Equals(String.Empty), DBNull.Value, Str_TDocRef), Entidad.CO_SDOC_REF, Entidad.CO_NDOC_REF, _
                                                  IIf(Entidad.CO_FDOC_REF.Equals(String.Empty), DBNull.Value, Entidad.CO_FDOC_REF), _
                                                  Entidad.CO_TASA_IGV, Entidad.CO_IGV, monto_exone, tasa_isc, monto_isc, _
                                                  otros_tributos, Entidad.CO_SUBTOTAL, Entidad.CO_TOTAL, es_afec_detra, _
                                                  tasa_detra, impor_detra, 0, num_detra, DBNull.Value, _
                                                  "", "", es_afec_percep, 0, estado, Entidad.CO_TOTAL, 0, 0, 0, 0)


                        'grabamos el detalle del asiento contable
                        Dim items As Integer = 0
                        Dim cuenta_Base As String = "601101"
                        Dim cuenta_Des1 As String = "201111"
                        Dim cuenta_Des2 As String = "611101"
                        Dim cuenta_igv As String = "401111"
                        Dim cuenta_tot As String = "421201"
                        Dim tc_det As Double = 0 'Entidad.CO_TC
                        Dim debe As Double = 0
                        Dim haber As Double = 0

                        '__1º la cuenta 60 base imponible
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_SUBTOTAL)
                        haber = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_SUBTOTAL, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Base, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL, 0, 0)


                        '__2º buscamos sus destinos y grabamos la 60 y 79
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_SUBTOTAL)
                        haber = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_SUBTOTAL, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Des1, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL, 0, 0)

                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_SUBTOTAL, 0)
                        haber = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_SUBTOTAL)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Des2, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            0, Entidad.CO_SUBTOTAL, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL, 0, 0)


                        '__3º la cuenta 40 igv
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_IGV)
                        haber = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_IGV, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_igv, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_IGV, 0, 0)


                        '__4º la cuenta 42 total
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_TOTAL, 0)
                        haber = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_TOTAL)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                         items, cuenta_tot, Int_TipoAnex, Int_CodAnex, Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, _
                                                           Entidad.CO_FDOC, Entidad.CO_VDOC, debe, haber, tc_det, 0, _
                                                           Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                           Entidad.CO_TERMINAL, Now, Entidad.CO_TOTAL, 0, 0)


                        'actualizamos el correlativo del numero de voucher en su tabla
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_U_ACT_NUMVOUCHER", ayo, mes, IdSubdiario, Str_NumVoucher, empresa)
                        SqlHelper.ExecuteNonQuery(tr, CommandType.Text, "update SG_LO_TB_COMPROBANTES_CAB set CO_IDVOUCHER=" & IDCompra & " where co_id=" & Entidad.CO_ID)

                        'Fin Contabilidad : __________________________________________________

                    End If
                ElseIf Entidad.CO_ID = -1 Then
                    Throw New Exception("No se puede Grabar un Comprobante con esa fecha, corresponde a un Inventario ya cerrado.")
                    Exit Sub
                Else
                    'tr.Commit()
                    'tr.Dispose()
                    Throw New Exception("El Mes del Comprobante se encuentra cerrado.")
                    Exit Sub
                End If


                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub

        Public Sub Insert_CM(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB, ByVal idempresa As Integer, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET), ByRef Str_NumVoucher As String, ByRef Int_Idcompra_ As String, ByVal TipoMov As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

            Try
                With Entidad
                    Entidad.CO_ID = SqlHelper.ExecuteScalar(tr, "SG_LO_SP_I_COMPROBANTES_CAB_STEM", .CO_FEC_DOC, .CO_IDPROVE, .CO_TDOC, .CO_SDOC, .CO_NDOC, .CO_FDOC, .CO_VDOC, .CO_IDMONEDA, .CO_IDFORMA_PAGO, .CO_TC, .CO_FECHA_ENT, .CO_COMENTARIO, .CO_SUBTOTAL, .CO_DESCUENTO, .CO_IGV, .CO_TOTAL, .CO_USUARIO, .CO_TERMINAL, .CO_IDEMPRESA, .CO_NOTAS, _
                                                            IIf(.CO_TDOC_REF = String.Empty, DBNull.Value, .CO_TDOC_REF), _
                                                            .CO_SDOC_REF, .CO_NDOC_REF, TipoMov, .CO_INCLUYE_IGV)
                    Int_Idcompra_ = Entidad.CO_ID
                End With
                If Entidad.CO_ID > 0 Then
                    For Each d As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_COMPROBANTES_DET", Entidad.CO_ID, .DE_ITEM, .DE_IDARTICULO, .DE_IDUM, .DE_IDUM_V, .DE_CANT, .DE_CANT_V, .DE_PRECIO, .DE_DESCUENTO, .DE_IGV, .DE_SUBTOTAL, .DE_TOTAL, .DE_ESTADO, .DE_COMENTARIO, .DE_IDLOTE, _
                                                      IIf(.DE_FEC_LOT = String.Empty, DBNull.Value, .DE_FEC_LOT), idempresa, TipoMov)
                        End With
                    Next
                    If CDate(Entidad.CO_FDOC) >= CDate("22/05/2015") Then

                        'Inicio Contabilidad : __________________________________________________

                        Dim IDCompra As Integer = 0
                        Dim IdSubdiario As String = "01"
                        Dim empresa As Integer = idempresa
                        Dim ayo As Integer = CDate(Entidad.CO_FDOC).Year
                        Dim mes As Integer = CDate(Entidad.CO_FDOC).Month
                        Dim glosa As String = Entidad.CO_NOTAS
                        Dim moneda As String = "1"
                        Dim Int_TipoAnex As Integer = 2 'proveedor
                        Dim Int_CodAnex As Integer = 0 'codigo de anexo
                        Dim Str_DesAnex As String = "" 'Descripcion de anexo


                        'buscamos el anexo contable 
                        Int_CodAnex = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(PR_IDANEXO_CONTA,0) FROM SG_LO_TB_PROVEEDOR WHERE PR_ID  =  " & Entidad.CO_IDPROVE.ToString)
                        Str_DesAnex = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(PR_DESCRIPCION,'') FROM SG_LO_TB_PROVEEDOR WHERE PR_ID  =  " & Entidad.CO_IDPROVE.ToString)


                        'Obtenemos ultimo numero de voucher de compras
                        Str_NumVoucher = SqlHelper.ExecuteScalar(tr, "SG_CO_SP_C_ULT_NUM_VOU", ayo, mes, IdSubdiario, empresa)

                        'grabamos la cabecera del asiento contable
                        IDCompra = SqlHelper.ExecuteScalar(tr, "SG_CO_SP_I_ASIENTO_CAB", IdSubdiario, _
                                                          Str_NumVoucher, ayo, mes, Entidad.CO_FDOC, _
                                                          moneda, Entidad.CO_TOTAL, Entidad.CO_TOTAL, Entidad.CO_TC, _
                                                          0, 1, Str_DesAnex & " " & glosa, 1, 2, Entidad.CO_USUARIO, _
                                                          Entidad.CO_TERMINAL, Now, empresa)



                        'grabamos cabecera de compras(reg. de compras)



                        Dim Str_TDoc As String = String.Empty 'tipo de doc
                        Dim Str_TDocRef As String = String.Empty 'tipo de doc ref
                        Dim indicador = "01"
                        Dim monto_exone As Double = 0
                        Dim tasa_isc As Double = 0
                        Dim monto_isc As Double = 0
                        Dim otros_tributos As Double = 0
                        Dim es_afec_detra As Integer = 0
                        Dim tasa_detra As Double = 0
                        Dim impor_detra As Double = 0
                        Dim num_detra As String = ""
                        Dim es_afec_percep As Integer = 0
                        Dim estado As Integer = 1



                        'buscamos el cod. conta del doc. del comprobante
                        Str_TDoc = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(TD_COD_CONTA,0) FROM SG_LO_TB_TIPO_DOCUMENTO WHERE TD_IDEMPRESA = " & empresa & " AND TD_ID = '" & Entidad.CO_TDOC & "'")
                        If Entidad.CO_TDOC = "NC" Then
                            Str_TDocRef = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(TD_COD_CONTA,0) FROM SG_LO_TB_TIPO_DOCUMENTO WHERE TD_IDEMPRESA = " & empresa & " AND TD_ID = '" & Entidad.CO_TDOC_REF & "'")
                        End If


                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_COMPRAS", IDCompra, Int_TipoAnex, Int_CodAnex,
                                                  Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, indicador, Entidad.CO_FDOC, Entidad.CO_VDOC, Entidad.CO_FDOC, _
                                                  IIf(Str_TDocRef.Equals(String.Empty), DBNull.Value, Str_TDocRef), Entidad.CO_SDOC_REF, Entidad.CO_NDOC_REF, _
                                                  IIf(Entidad.CO_FDOC_REF.Equals(String.Empty), DBNull.Value, Entidad.CO_FDOC_REF), _
                                                  Entidad.CO_TASA_IGV, Entidad.CO_IGV, monto_exone, tasa_isc, monto_isc, _
                                                  otros_tributos, Entidad.CO_SUBTOTAL, Entidad.CO_TOTAL, es_afec_detra, _
                                                  tasa_detra, impor_detra, 0, num_detra, DBNull.Value, _
                                                  "", "", es_afec_percep, 0, estado, Entidad.CO_TOTAL, 0, 0, 0, 0)


                        'grabamos el detalle del asiento contable
                        Dim items As Integer = 0

                        Dim cuenta_Base As String = "601101"

                        Dim cuenta_Des1 As String = "201111"
                        Dim cuenta_Des2 As String = "611101"

                        Dim cuenta_igv As String = "401112"
                        Dim cuenta_tot As String = "421201"
                        Dim tc_det As Double = 0 'Entidad.CO_TC
                        Dim debe As Double = 0
                        Dim haber As Double = 0

                        For Each d As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET In ls_det
                            cuenta_Base = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT GA_CntConta FROM SG_FA_TB_ARTICULO INNER JOIN SG_LO_TB_GRUPO_ARTICULO ON AR_IDGRUPO =GA_ID AND AR_IDEMPRESA =GA_IDEMPRESA WHERE AR_ID =" & d.DE_IDARTICULO)

                            Dim DR As SqlDataReader = SqlHelper.ExecuteReader(tr, "sg_co_sp_s_SISA_CTAS_DESTINO", cuenta_Base, empresa, ayo)
                            DR.Read()
                            cuenta_Des1 = DR.GetString(0).ToString()
                            cuenta_Des2 = DR.GetString(1).ToString()
                            DR.Close()

                            '__1º la cuenta 60 base imponible
                            items += 1
                            debe = IIf(Entidad.CO_TDOC = "NC", 0, d.DE_SUBTOTAL)
                            haber = IIf(Entidad.CO_TDOC = "NC", d.DE_SUBTOTAL, 0)
                            SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                              items, cuenta_Base, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                                debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                                Entidad.CO_TERMINAL, Now, d.DE_SUBTOTAL, 0, 0)


                            '__2º buscamos sus destinos y grabamos la 60 y 79
                            items += 1
                            debe = IIf(Entidad.CO_TDOC = "NC", 0, d.DE_SUBTOTAL)
                            haber = IIf(Entidad.CO_TDOC = "NC", d.DE_SUBTOTAL, 0)
                            SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                              items, cuenta_Des1, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                                debe, haber, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                                Entidad.CO_TERMINAL, Now, d.DE_SUBTOTAL, 0, 0)

                            items += 1
                            debe = IIf(Entidad.CO_TDOC = "NC", d.DE_SUBTOTAL, 0)
                            haber = IIf(Entidad.CO_TDOC = "NC", 0, d.DE_SUBTOTAL)
                            SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                              items, cuenta_Des2, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                                debe, haber, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                                Entidad.CO_TERMINAL, Now, d.DE_SUBTOTAL, 0, 0)

                        Next



                        '__3º la cuenta 40 igv
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_IGV)
                        haber = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_IGV, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_igv, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_IGV, 0, 0)


                        '__4º la cuenta 42 total
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_TOTAL, 0)
                        haber = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_TOTAL)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                         items, cuenta_tot, Int_TipoAnex, Int_CodAnex, Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, _
                                                           Entidad.CO_FDOC, Entidad.CO_VDOC, debe, haber, tc_det, 0, _
                                                           Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                           Entidad.CO_TERMINAL, Now, Entidad.CO_TOTAL, 0, 0)


                        'actualizamos el correlativo del numero de voucher en su tabla
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_U_ACT_NUMVOUCHER", ayo, mes, IdSubdiario, Str_NumVoucher, empresa)
                        SqlHelper.ExecuteNonQuery(tr, CommandType.Text, "update SG_LO_TB_COMPROBANTES_CAB set CO_IDVOUCHER=" & IDCompra & " where co_id=" & Entidad.CO_ID)

                        'Fin Contabilidad : __________________________________________________

                    End If

                ElseIf Entidad.CO_ID = -1 Then
                    Throw New Exception("No se puede Grabar un Comprobante con esa fecha, corresponde a un Inventario ya cerrado.")
                    Exit Sub
                Else
                    'tr.Commit()
                    'tr.Dispose()
                    Throw New Exception("El Mes del Comprobante se encuentra cerrado.")
                    Exit Sub
                End If


                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub

        Public Sub Update_STEM(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB, ByVal idempresa As Integer, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET))

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim valcom As Integer = 0
            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

            Try
                With Entidad
                    valcom = SqlHelper.ExecuteScalar(tr, "SG_LO_SP_U_COMPROBANTES_CAB_STEM", .CO_ID, .CO_FEC_DOC, .CO_IDPROVE, .CO_TDOC, .CO_SDOC, .CO_NDOC, .CO_FDOC, .CO_VDOC, .CO_IDMONEDA, .CO_IDFORMA_PAGO, .CO_TC, .CO_FECHA_ENT, .CO_SUBTOTAL, .CO_DESCUENTO, .CO_IGV, .CO_TOTAL, .CO_IDEMPRESA, .CO_NOTAS, _
                                                            IIf(.CO_TDOC_REF = String.Empty, DBNull.Value, .CO_TDOC_REF), _
                                                            .CO_SDOC_REF, .CO_NDOC_REF, .CO_INCLUYE_IGV, .CO_USUARIO, .CO_TERMINAL)

                End With
                If valcom > 0 Then
                    SqlHelper.ExecuteScalar(tr, "SG_LO_SP_D_COMPROBANTES_DET", Entidad.CO_ID, Entidad.CO_IDEMPRESA, 1)

                    For Each d As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_COMPROBANTES_DET", Entidad.CO_ID, .DE_ITEM, .DE_IDARTICULO, .DE_IDUM, .DE_IDUM_V, .DE_CANT, .DE_CANT_V, .DE_PRECIO, .DE_DESCUENTO, .DE_IGV, .DE_SUBTOTAL, .DE_TOTAL, .DE_ESTADO, .DE_COMENTARIO, .DE_IDLOTE, _
                                                      IIf(.DE_FEC_LOT = String.Empty, DBNull.Value, .DE_FEC_LOT), idempresa, 1)
                        End With
                    Next
                ElseIf valcom = -1 Then
                    Throw New Exception("No se puede actualizar el comprobante, corresponde a un Inventario ya cerrado.")
                    Exit Sub
                Else
                    Throw New Exception("El Mes del Comprobante se encuentra cerrado.")
                    Exit Sub
                End If

                '-------------------------------------

                '------------------------------------

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub

        Public Sub Insert_B(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB, ByVal idempresa As Integer, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET), ByRef Str_NumVoucher As String, ByRef Int_Idcompra_ As String, ByVal TipoMov As Integer)

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

            Try
                With Entidad
                    Entidad.CO_ID = SqlHelper.ExecuteScalar(tr, "SG_LO_SP_I_COMPROBANTES_CAB_B", .CO_FEC_DOC, .CO_IDPROVE, .CO_TDOC, .CO_SDOC, .CO_NDOC, .CO_FDOC, .CO_VDOC, .CO_IDMONEDA, .CO_IDFORMA_PAGO, .CO_TC, .CO_FECHA_ENT, .CO_COMENTARIO, .CO_SUBTOTAL, .CO_DESCUENTO, .CO_IGV, .CO_TOTAL, .CO_USUARIO, .CO_TERMINAL, .CO_IDEMPRESA, .CO_NOTAS, _
                                                            IIf(.CO_TDOC_REF = String.Empty, DBNull.Value, .CO_TDOC_REF), _
                                                            .CO_SDOC_REF, .CO_NDOC_REF, TipoMov, .CO_SUBTOTAL_NA, .CO_INCLUYE_IGV)
                End With
                If Entidad.CO_ID > 0 Then


                    For Each d As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_COMPROBANTES_DET", Entidad.CO_ID, .DE_ITEM, .DE_IDARTICULO, .DE_IDUM, .DE_IDUM_V, .DE_CANT, .DE_CANT_V, .DE_PRECIO, .DE_DESCUENTO, .DE_IGV, .DE_SUBTOTAL, .DE_TOTAL, .DE_ESTADO, .DE_COMENTARIO, .DE_IDLOTE, _
                                                      IIf(.DE_FEC_LOT = String.Empty, DBNull.Value, .DE_FEC_LOT), idempresa, TipoMov)
                        End With
                    Next



                    'Inicio Contabilidad : __________________________________________________

                    Dim IDCompra As Integer = 0
                    Dim IdSubdiario As String = "01"
                    Dim empresa As Integer = idempresa
                    Dim ayo As Integer = CDate(Entidad.CO_FDOC).Year 'fecha de mision
                    Dim mes As Integer = CDate(Entidad.CO_FDOC).Month 'fecha de mision

                    Dim glosa As String = Entidad.CO_NOTAS
                    Dim moneda As String = "1"
                    Dim Int_TipoAnex As Integer = 2 'proveedor
                    Dim Int_CodAnex As Integer = 0 'codigo de anexo
                    Dim Str_DesAnex As String = "" 'Descripcion de anexo
                    Dim Int_ProveRela As Integer = 0

                    'buscamos el anexo contable 
                    Int_CodAnex = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(PR_IDANEXO_CONTA,0) FROM SG_LO_TB_PROVEEDOR WHERE PR_ID  =  " & Entidad.CO_IDPROVE.ToString)
                    Int_ProveRela = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(PR_ES_RELACIONADO,0) FROM SG_LO_TB_PROVEEDOR WHERE PR_ID  =  " & Entidad.CO_IDPROVE.ToString)
                    Str_DesAnex = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(PR_DESCRIPCION,'') FROM SG_LO_TB_PROVEEDOR WHERE PR_ID  =  " & Entidad.CO_IDPROVE.ToString)


                    'Obtenemos ultimo numero de voucher de compras
                    Str_NumVoucher = SqlHelper.ExecuteScalar(tr, "SG_CO_SP_C_ULT_NUM_VOU", ayo, mes, IdSubdiario, empresa)

                    'grabamos la cabecera del asiento contable
                    IDCompra = SqlHelper.ExecuteScalar(tr, "SG_CO_SP_I_ASIENTO_CAB", IdSubdiario, _
                                                         Str_NumVoucher, ayo, mes, Entidad.CO_FDOC, _
                                                        moneda, Entidad.CO_TOTAL, Entidad.CO_TOTAL, Entidad.CO_TC, _
                                                          0, 1, Str_DesAnex & " " & glosa, 1, 2, Entidad.CO_USUARIO, _
                                                          Entidad.CO_TERMINAL, Now, empresa)

                    Int_Idcompra_ = IDCompra

                    'grabamos cabecera de compras(reg. de compras)

                    Entidad.CO_SUBTOTAL = Math.Round(Entidad.CO_SUBTOTAL - Entidad.CO_SUBTOTAL_NA, 2)
                    Dim monto_exone As Double = Entidad.CO_SUBTOTAL_NA
                    Dim Str_TDoc As String = String.Empty 'tipo de doc
                    Dim Str_TDocRef As String = String.Empty 'tipo de doc ref
                    Dim indicador As String = "01"
                    If monto_exone > 0 And Entidad.CO_IGV > 0 Then
                        indicador = "03"
                    End If
                    If monto_exone > 0 And Entidad.CO_IGV = 0 Then
                        indicador = "02"
                    End If
                    Dim tasa_isc As Double = 0
                    Dim monto_isc As Double = 0
                    Dim otros_tributos As Double = 0
                    Dim es_afec_detra As Integer = 0
                    Dim tasa_detra As Double = 0
                    Dim impor_detra As Double = 0
                    Dim num_detra As String = ""
                    Dim es_afec_percep As Integer = 0
                    Dim estado As Integer = 1



                    'buscamos el cod. conta del doc. del comprobante
                    Str_TDoc = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(TD_COD_CONTA,0) FROM SG_LO_TB_TIPO_DOCUMENTO WHERE TD_IDEMPRESA = " & empresa & " AND TD_ID = '" & Entidad.CO_TDOC & "'")
                    If Entidad.CO_TDOC = "NC" Then
                        Str_TDocRef = SqlHelper.ExecuteScalar(tr, CommandType.Text, "SELECT ISNULL(TD_COD_CONTA,0) FROM SG_LO_TB_TIPO_DOCUMENTO WHERE TD_IDEMPRESA = " & empresa & " AND TD_ID = '" & Entidad.CO_TDOC_REF & "'")
                    End If



                    SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_COMPRAS", IDCompra, Int_TipoAnex, Int_CodAnex,
                                              Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, indicador, Entidad.CO_FDOC, Entidad.CO_VDOC, Entidad.CO_FDOC, _
                                              IIf(Str_TDocRef.Equals(String.Empty), DBNull.Value, Str_TDocRef), Entidad.CO_SDOC_REF, Entidad.CO_NDOC_REF, _
                                              IIf(Entidad.CO_FDOC_REF.Equals(String.Empty), DBNull.Value, Entidad.CO_FDOC_REF), _
                                              Entidad.CO_TASA_IGV, Entidad.CO_IGV, monto_exone, tasa_isc, monto_isc, _
                                              otros_tributos, IIf(indicador = "02", Entidad.CO_SUBTOTAL_NA, Entidad.CO_SUBTOTAL), Entidad.CO_TOTAL, es_afec_detra, _
                                              tasa_detra, impor_detra, 0, num_detra, DBNull.Value, _
                                              "", "", es_afec_percep, 0, estado, Entidad.CO_TOTAL, 0, 0, 0, 0)


                    'grabamos el detalle del asiento contable
                    Dim items As Integer = 0
                    Dim cuenta_Base As String = "601101"
                    Dim cuenta_Des1 As String = "201111"
                    Dim cuenta_Des2 As String = "611101"
                    Dim cuenta_igv As String = "401111"
                    Dim cuenta_tot As String = IIf(Int_ProveRela = 1, "431251", "421201")
                    Dim tc_det As Double = 0 'Entidad.CO_TC
                    Dim debe As Double = 0
                    Dim haber As Double = 0

                    If Entidad.CO_SUBTOTAL > 0 Then

                        '__1º la cuenta 60 base imponible
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_SUBTOTAL)
                        haber = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_SUBTOTAL, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Base, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL, 0, 0)


                        '__2º buscamos sus destinos y grabamos la 60 y 79
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_SUBTOTAL)
                        haber = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_SUBTOTAL, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Des1, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL, 0, 0)

                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_SUBTOTAL, 0)
                        haber = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_SUBTOTAL)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Des2, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_SUBTOTAL, 0, 0)

                    End If
                    If monto_exone > 0 Then

                        '__1º la cuenta 60 base imponible
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, monto_exone)
                        haber = IIf(Entidad.CO_TDOC = "NC", monto_exone, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Base, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, monto_exone, 0, 0)


                        '__2º buscamos sus destinos y grabamos la 60 y 79
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, monto_exone)
                        haber = IIf(Entidad.CO_TDOC = "NC", monto_exone, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Des1, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, monto_exone, 0, 0)

                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", monto_exone, 0)
                        haber = IIf(Entidad.CO_TDOC = "NC", 0, monto_exone)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_Des2, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 1, Str_DesAnex, DBNull.Value, 1, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, monto_exone, 0, 0)

                    End If
                    If Entidad.CO_IGV > 0 Then

                        '__3º la cuenta 40 igv
                        items += 1
                        debe = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_IGV)
                        haber = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_IGV, 0)
                        SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                          items, cuenta_igv, DBNull.Value, DBNull.Value, DBNull.Value, "", "", DBNull.Value, DBNull.Value, _
                                                            debe, haber, tc_det, 0, Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                            Entidad.CO_TERMINAL, Now, Entidad.CO_IGV, 0, 0)

                    End If
                    '__4º la cuenta 42 total
                    items += 1
                    debe = IIf(Entidad.CO_TDOC = "NC", Entidad.CO_TOTAL, 0)
                    haber = IIf(Entidad.CO_TDOC = "NC", 0, Entidad.CO_TOTAL)
                    SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_I_ASIENTO_DET", IDCompra, _
                                                     items, cuenta_tot, Int_TipoAnex, Int_CodAnex, Str_TDoc, Entidad.CO_SDOC, Entidad.CO_NDOC, _
                                                       Entidad.CO_FDOC, Entidad.CO_VDOC, debe, haber, tc_det, 0, _
                                                       Str_DesAnex, DBNull.Value, 0, Entidad.CO_USUARIO, _
                                                       Entidad.CO_TERMINAL, Now, Entidad.CO_TOTAL, 0, 0)


                    'actualizamos el correlativo del numero de voucher en su tabla
                    SqlHelper.ExecuteNonQuery(tr, "SG_CO_SP_U_ACT_NUMVOUCHER", ayo, mes, IdSubdiario, Str_NumVoucher, empresa)
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, "update SG_LO_TB_COMPROBANTES_CAB set CO_IDVOUCHER=" & IDCompra & " where co_id=" & Entidad.CO_ID)

                    'Fin Contabilidad : __________________________________________________

                ElseIf Entidad.CO_ID = -1 Then
                    Throw New Exception("No se puede Grabar un Comprobante con esa fecha, corresponde a un Inventario ya cerrado.")
                    Exit Sub
                Else
                    'tr.Commit()
                    'tr.Dispose()
                    Throw New Exception("El Mes del Comprobante se encuentra cerrado.")
                    Exit Sub
                End If


                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub

        Public Sub update_B(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB, ByVal idempresa As Integer, ByVal ls_det As List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET))

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Dim valcom As Integer = 0
            Dim tr As SqlTransaction = Cn.BeginTransaction(IsolationLevel.Serializable)

            Try
                With Entidad
                    valcom = SqlHelper.ExecuteScalar(tr, "SG_LO_SP_U_COMPROBANTES_CAB_B", .CO_ID, .CO_FEC_DOC, .CO_IDPROVE, .CO_TDOC, .CO_SDOC, .CO_NDOC, .CO_FDOC, .CO_VDOC, .CO_IDMONEDA, .CO_IDFORMA_PAGO, .CO_TC, .CO_FECHA_ENT, .CO_SUBTOTAL, .CO_DESCUENTO, .CO_IGV, .CO_TOTAL, .CO_IDEMPRESA, .CO_NOTAS, _
                                                            IIf(.CO_TDOC_REF = String.Empty, DBNull.Value, .CO_TDOC_REF), _
                                                            .CO_SDOC_REF, .CO_NDOC_REF, .CO_SUBTOTAL_NA, .CO_INCLUYE_IGV, .CO_USUARIO, .CO_TERMINAL)

                End With
                If valcom > 0 Then
                    SqlHelper.ExecuteScalar(tr, "SG_LO_SP_D_COMPROBANTES_DET", Entidad.CO_ID, Entidad.CO_IDEMPRESA, 1)

                    For Each d As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "SG_LO_SP_I_COMPROBANTES_DET", Entidad.CO_ID, .DE_ITEM, .DE_IDARTICULO, .DE_IDUM, .DE_IDUM_V, .DE_CANT, .DE_CANT_V, .DE_PRECIO, .DE_DESCUENTO, .DE_IGV, .DE_SUBTOTAL, .DE_TOTAL, .DE_ESTADO, .DE_COMENTARIO, .DE_IDLOTE, _
                                                      IIf(.DE_FEC_LOT = String.Empty, DBNull.Value, .DE_FEC_LOT), idempresa, 1)
                        End With
                    Next
                ElseIf valcom = -1 Then
                    Throw New Exception("No se puede actualizar el comprobante, corresponde a un Inventario ya cerrado.")
                    Exit Sub
                Else
                    Throw New Exception("El Mes del Comprobante se encuentra cerrado.")
                    Exit Sub
                End If

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                Throw ex
            End Try
        End Sub

        Public Sub Anular_B(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB)
            Try
                Dim val As Integer = 0
                val = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_COMPROBANTES_CAB_B", Entidad.CO_ID, Entidad.CO_IDEMPRESA, Entidad.CO_USUARIO, Entidad.CO_TERMINAL)
                If val > 0 Then
                    MsgBox("Listo", MsgBoxStyle.Information, ".:. Aviso .:.")
                ElseIf val = -1 Then
                    Throw New Exception("No se puede anular el comprobante, corresponde a un Inventario ya cerrado.")
                    Exit Sub
                Else
                    Throw New Exception("El Mes del Comprobante se encuentra cerrado.")
                    Exit Sub
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        'Public Function get_Comprobante_xDoc(prove_ As Integer, td_ As String, sd_ As String, nd_ As String, empresa_ As Integer) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_DET_COMPRO_XNUM", prove_, td_, sd_, nd_, empresa_).Tables(0)
        'End Function

        Public Function get_Comprobante_x_Id(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_COMPROBANTES_CAB_2", Entidad.CO_ID, Entidad.CO_IDEMPRESA)
        End Function

        Public Function get_Comprobante_xProv(ByVal prove_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_COMPROBANTES_CAB_1", prove_, empresa_).Tables(0)
        End Function

        Public Function get_ComprobanteCredito_xFecha(ByVal Tipo As Integer, ByVal FechaIni As String, ByVal FechaFin As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_COMPROBANTES_CAB_3", Tipo, FechaIni, FechaFin, empresa_).Tables(0)
        End Function
        Public Function get_ComprobanteRegsitro(ByVal Anio As Integer, ByVal Mes As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_COMPROBANTES_CAB_4", Anio, Mes, empresa_).Tables(0)
        End Function

        Public Function get_Comprobante_DET_xProv(ByVal IDCOMPRO As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_COMPROBANTES_DET_1", IDCOMPRO).Tables(0)
        End Function

        Public Function get_Lista_Edi_Compro(ByVal fecha As Date, ByVal fech2 As Date, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa As Integer, ByVal tipo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_LISTA_EDI_Compro", ayo_, mes_, fecha, fech2, empresa, tipo).Tables(0)
        End Function

    End Class
    Public Class SG_LO_TB_UNI_MED
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_UNI_MED)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_UNI_MED", .id, .descripcion, .abrevi, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_UNI_MED)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_UNI_MED", .id, .descripcion, .abrevi, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_UNI_MED)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_UNI_MED", .id, .empresa)
            End With
        End Sub
        Public Function get_val(ByVal empresa_ As Integer, ByVal id As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_UNI_MED2", empresa_, id).Tables(0)
        End Function
        Public Function get_grilla(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_UNI_MED3", empresa_).Tables(0)
        End Function
        Public Function getMedidas(ByVal empresa_ As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_UNI_MED", empresa_).Tables(0)
        End Function
        Public Function get_req(ByVal empresa_ As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S1_UNI_MED", empresa_).Tables(0)
        End Function
    End Class
    Public Class SG_LO_TB_MARCA
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_MARCA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_MARCA", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_MARCA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_MARCA", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_MARCA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_MARCA ", .id, .empresa)
            End With
        End Sub
        Public Function get_maval(ByVal empresa_ As Integer, ByVal id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MARCA2", id, empresa_).Tables(0)
        End Function
        Public Function get_magrilla(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MARCA3", empresa_).Tables(0)
        End Function
        Public Function getMarcas(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_MARCA", empresa_).Tables(0)
        End Function

        Public Function get_Ult_codigo_marca(empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_COD_MARCA", empresa_)
        End Function

    End Class
    Public Class SG_LO_TB_FABRICANTE
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_FABRICANTE)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_FABRICANTE", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_FABRICANTE)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_FABRICANTE", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_FABRICANTE)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_FABRICANTE ", .id, .empresa)
            End With
        End Sub
        Public Function get_faval(ByVal empresa_ As Integer, ByVal id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FABRICANTE2", empresa_, id).Tables(0)
        End Function
        Public Function get_fagrilla(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FABRICANTE3", empresa_).Tables(0)
        End Function
        Public Function getFabricantes(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_FABRICANTE", empresa_).Tables(0)
        End Function

        Public Function get_Ult_Cod_facbricante(empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_COD_FABRIC", empresa_)
        End Function

    End Class
    Public Class SG_LO_TB_PAIS
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PAIS)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_PAIS", .codigo_, .descripcion_, .idempresa_)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PAIS)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_PAIS", .codigo_, .descripcion_, .idempresa_)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PAIS)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_PAIS", .codigo_, .idempresa_)
            End With
        End Sub
        Public Function getpa(ByVal idempresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PAIS1", idempresa).Tables(0)
        End Function
        Public Function getpaval(ByVal codigo As Integer, ByVal idempresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PAIS2", codigo, idempresa).Tables(0)
        End Function
        Public Function getPaises(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PAIS", empresa_).Tables(0)
        End Function

        Public Function get_Ult_cod_Pais(empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_COD_PAIS", empresa_)
        End Function

    End Class
    Public Class SG_LO_TB_UBICACION_ART
        Inherits ClsBD
        Public Sub Insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_UBICACION_ART)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_UBICACION_ART", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub Update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_UBICACION_ART)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_UBICACION_ART", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub Delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_UBICACION_ART)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_UBICACION_ART", .id, .empresa)
            End With
        End Sub
        Public Function get_val(ByVal empresa_ As Integer, ByVal id As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_UBICACION_ART2", empresa_, id).Tables(0)
        End Function
        Public Function get_grilla(ByVal empresa_ As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_UBICACION_ART3", empresa_).Tables(0)
        End Function
        Public Function getUbicaciones(ByVal empresa_ As Integer)
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_UBICACION_ART", empresa_).Tables(0)
        End Function

        Public Function get_ult_codigo_Ubic(ByVal empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_COD_UBI", empresa_)
        End Function

    End Class
    Public Class SG_LO_TB_GRUPO_ARTICULO
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_GRUPO_ARTICULO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_GRUPO_ARTICULO", .id, .descripcion, .empresa, .CntConta)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_GRUPO_ARTICULO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_GRUPO_ARTICULO", .id, .descripcion, .empresa, .CntConta)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_GRUPO_ARTICULO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_GRUPO_ARTICULO", .id, .empresa)
            End With
        End Sub
        Public Function get_gaval(ByVal empresa_ As Integer, ByVal id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_GRUPO_ARTICULO2", empresa_, id).Tables(0)
        End Function
        Public Function get_gagrilla(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_GRUPO_ARTICULO3", empresa_).Tables(0)
        End Function
        Public Function getGrupos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_GRUPO_ARTICULO", empresa_).Tables(0)
        End Function

        Public Function get_ult_codigo(ByVal empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_COD_GRUPO", empresa_)
        End Function

    End Class
    Public Class SG_LO_TB_CENTRO_COSTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_CENTRO_COSTO", .CC_ID, .CC_DESCRIPCION, .CC_IDEMPRESA)
            End With
        End Sub
        Public Sub Update(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_CENTRO_COSTO", .CC_ID, .CC_DESCRIPCION, .CC_IDEMPRESA)
            End With
        End Sub
        Public Sub Delete(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_CENTRO_COSTO", .CC_ID, .CC_IDEMPRESA)
            End With
        End Sub
        'Public Sub Select(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO)
        '    With Entidad
        '        SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_S_CENTRO_COSTO", .CC_ID, .CC_DESCRIPCION, .CC_IDEMPRESA)
        '    End With
        'End Sub
        Public Function get_val(ByVal id_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CENTRO_COSTO2", id_, empresa_).Tables(0)
        End Function
        Public Function getcc(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_CENTRO_COSTO", empresa_).Tables(0)
        End Function

        Public Function get_ult_cod_cc(ByVal empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_CENCOS", empresa_)
        End Function

    End Class
    Public Class SG_LO_TB_AREA
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_AREA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_AREA", .AR_ID, .AR_DESCRIPCION, .AR_IDEMPRESA, .AR_IDCentroCosto)
            End With
        End Sub
        Public Sub Update(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_AREA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_AREA", .AR_ID, .AR_DESCRIPCION, .AR_IDEMPRESA, .AR_IDCentroCosto)
            End With
        End Sub
        Public Sub Delete(ByVal Entidad As BE.LogisticaBE.SG_LO_TB_AREA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_AREA", .AR_ID, .AR_IDEMPRESA)
            End With
        End Sub
        Public Function getar(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_AREA", empresa_).Tables(0)
        End Function
        Public Function get_val(ByVal id As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_AREA2", id, empresa_).Tables(0)
        End Function

        Public Function get_ult_codigo(ByVal empresa_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_S_ULT_COD", empresa_)
        End Function
    End Class
    Public Class SG_LO_TB_ESTADO_DOCU
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ESTADO_DOCU)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_EST_DOC", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ESTADO_DOCU)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_EST_DOC", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ESTADO_DOCU)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_EST_DOC ", .id, .empresa)
            End With
        End Sub
        Public Function get_edval(ByVal empresa_ As Integer, ByVal id As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_EST_DOC2", empresa_, id).Tables(0)
        End Function
        Public Function get_edgrilla(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_EST_DOC3", empresa_).Tables(0)
        End Function
    End Class
    Public Class SG_LO_TB_AGENCIA_ADUANAS
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_AGENCIA_ADUANAS)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_AGENCIA_ADUANAS", .id, .descripcion, .direccion, .estado, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_AGENCIA_ADUANAS)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_AGENCIA_ADUANAS", .id, .descripcion, .direccion, .estado, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_AGENCIA_ADUANAS)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_AGENCIA_ADUANAS ", .id, .empresa)
            End With
        End Sub
        Public Function get_aaval(ByVal empresa_ As Integer, ByVal id As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_AGENCIA_ADUANAS2", empresa_, id).Tables(0)
        End Function
        Public Function get_aagrilla(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_AGENCIA_ADUANAS3", empresa_).Tables(0)
        End Function
    End Class
    Public Class SG_LO_TB_TRANSA
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TRANSA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_TRANSA", .id, .descripcion, .es_sum, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TRANSA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_TRANSA", .id, .descripcion, .es_sum, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TRANSA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_TRANSA", .id, .empresa)
            End With
        End Sub
        Public Function get_val(ByVal empresa As Integer, ByVal id As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TRANSA2", empresa, id).Tables(0)
        End Function
        Public Function get_grilla(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TRANSA3", empresa).Tables(0)
        End Function
    End Class

    Public Class SG_LO_TB_PROYECTO
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROYECTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_PROYECTO", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROYECTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_PROYECTO", .id, .descripcion, .empresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_PROYECTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_PROYECTO", .id, .empresa)
            End With
        End Sub
        Public Function get_val(ByVal id As Integer, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PROYECTO", id, empresa).Tables(0)
        End Function
        Public Function get_grilla(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PROYECTO2", empresa).Tables(0)
        End Function
        Public Function get_cod(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_PROYECTO3", empresa).Tables(0)
        End Function
    End Class

    Public Class SG_LO_TB_ESTADO_REQUERIMIENTO
        Inherits ClsBD
        Public Sub Insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ESTADO_REQUERIMIENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_ESTADO_REQUERIMIENTO", .descripcion, .empresa)
            End With
        End Sub
        Public Sub Update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ESTADO_REQUERIMIENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_ESTADO_REQUERIMIENTO", .id, .descripcion, .empresa)

            End With
        End Sub
        Public Sub Delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ESTADO_REQUERIMIENTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_ESTADO_REQUERIMIENTO", .id, .empresa)
            End With
        End Sub
        Public Function get_grilla(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ESTADO_REQUERIMIENTO", empresa).Tables(0)
        End Function
    End Class
    Public Class SG_LO_TB_TIPO_REQ
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_REQ)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_TIPO_REQUERIMIENTO", .id, .descripcion, .idempresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_REQ)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_TIPO_REQUERIMIENTO", .id, .descripcion, .idempresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_TIPO_REQ)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_TIPO_REQUERIMIENTO", .id, .idempresa)
            End With
        End Sub
        Public Function get_grilla(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_REQUERIMIENTO", empresa).Tables(0)
        End Function
        Public Function get_val(ByVal empresa As Integer, ByVal id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_TIPO_REQUERIMIENTO2", empresa, id).Tables(0)
        End Function
    End Class
    Public Class SG_FA_TB_ARTICULO_UNIDAD_MEDIDA
        Inherits ClsBD
        Public Function get_req(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_UNI_MED_ARTICULO", empresa).Tables(0)
        End Function
    End Class
    Public Class SG_LO_TB_ALMACEN
        Inherits ClsBD

        Public Sub insert(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ALMACEN)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_I_ALMACEN", .id, .descripcion, .direccion _
                                          , .pais, .ubigeo, .telefono, .estado, .afecto, .terminal, .usuario, .fecreg, .idempresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ALMACEN)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_U_ALMACEN", .id, .descripcion, .direccion _
                                          , .pais, .ubigeo, .telefono, .estado, .afecto, .terminal, .usuario, .fecreg, .idempresa)
            End With
        End Sub

        Public Function delete(ByVal obe As BE.LogisticaBE.SG_LO_TB_ALMACEN) As Integer
            Dim N As Integer = -1
            With obe
                N = SqlHelper.ExecuteScalar(Cn, "SG_LO_SP_D_ALMACEN", .id, .idempresa)
            End With

            Return N
        End Function

        'Public Sub delete(ByVal entidad As BE.LogisticaBE.SG_LO_TB_ALMACEN)
        '    With entidad
        '        SqlHelper.ExecuteNonQuery(Cn, "SG_LO_SP_D_ALMACEN", .id, .idempresa)
        '    End With
        'End Sub
        Public Function get_almacen(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN", empresa).Tables(0)
        End Function
        Public Function get_almacen_2(ByVal empresa As Integer, ByVal usuario As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN_2", empresa, usuario).Tables(0)
        End Function
        Public Function get_almacen_3(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_LO_SP_S_ALMACEN_3", empresa).Tables(0)
        End Function
        Public Function get_almacen_4(ByVal empresa As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_LO_SP_S_ALMACEN_4", empresa)
        End Function
    End Class
End Class
