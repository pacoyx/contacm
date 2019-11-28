Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data


Public Class MarcacionesBL

    Public Class SG_MA_TB_RELA_PERSONAL
        Inherits ClsBD

        Public Function getRelacion(entidad As BE.MarcacionesBE.SG_MA_TB_RELA_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_MA_SP_S_RELA_PERSONAL", entidad.IDPERSONAL_A, entidad.IDEMPRESA).Tables(0)
        End Function

        Public Sub Insert(entidad As BE.MarcacionesBE.SG_MA_TB_RELA_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_MA_SP_I_RELA_PERSONAL", entidad.IDPERSONAL_A, entidad.IDPERSONAL_B, entidad.IDEMPRESA)
        End Sub

        Public Sub Delete(entidad As BE.MarcacionesBE.SG_MA_TB_RELA_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_MA_SP_D_RELA_PERSONAL", entidad.IDPERSONAL_A, entidad.IDPERSONAL_B, entidad.IDEMPRESA)
        End Sub


    End Class


    Public Class SG_MA_TB_PAPELETA
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.MarcacionesBE.SG_MA_TB_PAPELETA)

            With Entidad
                Entidad.PA_ID = SqlHelper.ExecuteScalar(Cn, "SG_MA_SP_I_PAPELETA", .PA_IDPERSONAL, .PA_IDJEFE, _
                                          .PA_IDMOTIVO, _
                                          IIf(.PA_FEC_INI = String.Empty, DBNull.Value, .PA_FEC_INI), _
                                          IIf(.PA_FEC_FIN = String.Empty, DBNull.Value, .PA_FEC_FIN), _
                                          .PA_HOR_INI, .PA_HOR_FIN, .PA_DET_OTROS, .PA_VISTO_JEFE, _
                                          IIf(.PA_FEC_VIS_JEFE = String.Empty, DBNull.Value, .PA_FEC_VIS_JEFE), _
                                          .PA_VISTO_RRHH, _
                                          IIf(.PA_FEC_VIS_RRHH = String.Empty, DBNull.Value, .PA_FEC_VIS_RRHH), _
                                          .PA_USER, .PA_FEC_REG, .PA_PC, _
                                          .PA_FEC_MOD, .PA_PERIODO_VACA)
            End With

        End Sub

        Public Sub Update(Entidad As BE.MarcacionesBE.SG_MA_TB_PAPELETA)

            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_MA_SP_U_PAPELETA", .PA_ID, .PA_IDPERSONAL, .PA_IDJEFE, _
                                          .PA_IDMOTIVO, _
                                          IIf(.PA_FEC_INI = String.Empty, DBNull.Value, .PA_FEC_INI), _
                                          IIf(.PA_FEC_FIN = String.Empty, DBNull.Value, .PA_FEC_FIN), _
                                          .PA_HOR_INI, .PA_HOR_FIN, .PA_DET_OTROS, .PA_VISTO_JEFE, _
                                          IIf(.PA_FEC_VIS_JEFE = String.Empty, DBNull.Value, .PA_FEC_VIS_JEFE), _
                                          .PA_VISTO_RRHH, _
                                          IIf(.PA_FEC_VIS_RRHH = String.Empty, DBNull.Value, .PA_FEC_VIS_RRHH), _
                                          .PA_USER, .PA_FEC_REG, .PA_PC, _
                                          .PA_FEC_MOD)
            End With

        End Sub

        Public Sub Update_Visto_JA(id_ As Integer, estado_ As Integer, fecha_ As DateTime)
            SqlHelper.ExecuteNonQuery(Cn, "SG_MA_SP_U_VISTO_JA", id_, estado_, fecha_)
        End Sub

        Public Function get_Dias_x_Periodo_Vacacional(idusuario_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_MA_SP_DIAS_X_PER_VACA", idusuario_).Tables(0)
        End Function

        Public Function get_Info_Usuario(idusuario_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_MA_SP_S_INFO_USU", idusuario_).Tables(0)
        End Function

        Public Function get_Rep_01(idpapeleta_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_MA_SP_S_REP_01", idpapeleta_).Tables(0)
        End Function

        Public Function get_Rep_02(idpersonal_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_MA_SP_S_REP_02", idpersonal_).Tables(0)
        End Function

        Public Function get_Area_X_Jefe(idjefe_ As Integer, visto_jefe_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_MA_SP_S_AREA_X_JEFE", idjefe_, visto_jefe_, empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_MA_TB_MOTIVO
        Inherits ClsBD

        Public Function get_Motivos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_MA_SP_S_MOTIVO").Tables(0)
        End Function

        Public Sub Insert(entidad As BE.MarcacionesBE.SG_MA_TB_MOTIVO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_MA_SP_I_MOTIVO", entidad.MO_ID, entidad.MO_DESCRIPCION, entidad.MO_ES_DM, entidad.MO_ES_VA)
        End Sub

        Public Sub Update(entidad As BE.MarcacionesBE.SG_MA_TB_MOTIVO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_MA_SP_U_MOTIVO", entidad.MO_ID, entidad.MO_DESCRIPCION, entidad.MO_ES_DM, entidad.MO_ES_VA)
        End Sub

    End Class

End Class
