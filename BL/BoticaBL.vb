Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class BoticaBL
    Public Class SG_BO_TB_ATENCION

        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.BoticaBE.SG_BO_TB_ATENCION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_BO_SP_I_ATENCION", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.AT_IDCuenta _
             , obe.AT_IDTipoDoc _
             , obe.AT_Serie _
             , obe.AT_Numero _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.BoticaBE.SG_BO_TB_ATENCION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_BO_SP_U_ATENCION", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.AT_ID _
             , obe.AT_IDCuenta _
             , obe.AT_IDTipoDoc _
             , obe.AT_Serie _
             , obe.AT_Numero _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.BoticaBE.SG_BO_TB_ATENCION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_BO_SP_D_ATENCION", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.AT_ID _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.BoticaBE.SG_BO_TB_ATENCION, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_BO_SP_S1_ATENCION", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@AT_IDCuenta", System.Data.SqlDbType.Int).Value = obe.AT_IDCuenta
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.BoticaBE.SG_BO_TB_ATENCION, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_BO_SP_S2_ATENCION", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@AT_ID", System.Data.SqlDbType.Int).Value = obe.AT_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

End Class
