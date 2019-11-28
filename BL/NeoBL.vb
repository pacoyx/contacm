Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class NeoBL

    
    Public Class SA_TB_BB_UBICACION
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.NeoBE.SA_TB_BB_UBICACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_I_BB_UBICACION", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.UB_NOMBRE _
            , obe.UB_IDTIPO _
            , obe.UB_IDARTICULO _
            , obe.UB_IDEMPRESA _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.NeoBE.SA_TB_BB_UBICACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_U_BB_UBICACION", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.UB_ID _
            , obe.UB_NOMBRE _
            , obe.UB_IDTIPO _
            , obe.UB_IDARTICULO _
            , obe.UB_IDEMPRESA _
            , obe.UB_ESTADO _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.NeoBE.SA_TB_BB_UBICACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_D_BB_UBICACION", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.UB_ID _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.NeoBE.SA_TB_BB_UBICACION) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_UBICACION_1", obe.UB_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL02(ByVal IDEmpresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_UBICACION_2", IDEmpresa).Tables(0)
        End Function

    End Class

    Public Class SA_TB_BB_TIPO_UBI
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.NeoBE.SA_TB_BB_TIPO_UBI, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_I_BB_TIPO_UBI", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.TI_DESCRIPCION _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.NeoBE.SA_TB_BB_TIPO_UBI, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_U_BB_TIPO_UBI", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.TI_ID _
            , obe.TI_DESCRIPCION _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.NeoBE.SA_TB_BB_TIPO_UBI, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_D_BB_TIPO_UBI", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.TI_ID _
        )
            Return N
        End Function

        Public Function SEL01() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_TIPO_UBI_1").Tables(0)
        End Function

    End Class

    Public Class SA_TB_BB_REGISTRO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal IDUbicacion As Integer) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_I_BB_REGISTRO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RE_NOMBRE _
            , obe.RE_IDCUENTA _
            , obe.RE_IDMEDICO _
            , obe.RE_DIAGNOSTICO _
            , obe.RE_OBSERVACION _
            , obe.RE_PESO _
            , obe.RE_TALLA _
            , obe.RE_MADRE _
            , obe.RE_IDEMPRESA _
            , obe.RE_FECHA_INGRESO _
            , IDUbicacion _
            , obe.RE_IDGRUPO_SANG _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_U_BB_REGISTRO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RE_ID _
            , obe.RE_NOMBRE _
            , obe.RE_IDCUENTA _
            , obe.RE_IDMEDICO _
            , obe.RE_DIAGNOSTICO _
            , obe.RE_OBSERVACION _
            , obe.RE_PESO _
            , obe.RE_TALLA _
            , obe.RE_MADRE _
            , obe.RE_FECHA_INGRESO _
            , obe.RE_IDGRUPO_SANG _
        )
            Return N
        End Function

        Public Function Update2(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_U_BB_REGISTRO_2", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RE_ID _
        )
            Return N
        End Function

        Public Function Update3(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_U_BB_REGISTRO_3", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RE_ID _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_D_BB_REGISTRO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.RE_ID _
        )
            Return N
        End Function
        Public Function SEL01(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SA_SP_S_BB_REGISTRO_1", obe.RE_ID)
        End Function

        Public Function SEL02(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_REGISTRO_2", obe.RE_IDEMPRESA).Tables(0)
        End Function

        Public Sub SEL03(ByVal COLUMNA As String, ByVal VALOR As String, ByRef oDt As DataTable)
            Dim Scrip As String

            Scrip = "SELECT RE_ID,RE_NOMBRE,RE_IDCUENTA,RE_DIAGNOSTICO,RE_OBSERVACION,RE_PESO,RE_TALLA,RE_MADRE,RE_FECHA_INGRESO,RE_FECHA_ALTA,RE_IDMEDICO" & _
                    " FROM SA_TB_BB_REGISTRO " & _
                    "where " & COLUMNA & " like '%" & VALOR & "%' order by RE_ID desc"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Function SEL03(ByVal obe As BE.NeoBE.SA_TB_BB_REGISTRO) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_REGISTRO_3", obe.RE_ID)
        End Function

    End Class

    Public Class SA_TB_BB_CONSUMO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.NeoBE.SA_TB_BB_CONSUMO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_I_BB_CONSUMO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.CB_IDREGISTRO _
            , obe.CB_IDARTICULO _
            , obe.CB_IDUBICACION _
            , obe.CB_FECHA _
            , obe.CB_HORA_INI _
            , obe.CB_HORA_FIN _
            , obe.CB_OBSERVACION _
            , obe.CB_CANTIDAD _
            , obe.CB_TOTAL_HORAS _
        )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.NeoBE.SA_TB_BB_CONSUMO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_U_BB_CONSUMO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.CB_IDREGISTRO _
            , obe.CB_ITEM _
            , obe.CB_IDARTICULO _
            , obe.CB_IDUBICACION _
            , obe.CB_FECHA _
            , obe.CB_HORA_INI _
            , obe.CB_HORA_FIN _
            , obe.CB_OBSERVACION _
            , obe.CB_CANTIDAD _
            , obe.CB_TOTAL_HORAS _
        )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.NeoBE.SA_TB_BB_CONSUMO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SA_SP_D_BB_CONSUMO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.CB_IDREGISTRO _
            , obe.CB_ITEM _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.NeoBE.SA_TB_BB_CONSUMO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_CONSUMO_1", obe.CB_IDREGISTRO).Tables(0)
        End Function

        Public Function SEL02(ByVal obe As BE.NeoBE.SA_TB_BB_CONSUMO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_CONSUMO_2", obe.CB_IDREGISTRO).Tables(0)
        End Function

        Public Function SEL03(ByVal IDCUENTA As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_CONSUMO_3", IDCUENTA).Tables(0)
        End Function

        Public Function SEL04(ByVal obe As BE.NeoBE.SA_TB_BB_CONSUMO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SA_SP_S_BB_CONSUMO_4", obe.CB_IDREGISTRO, obe.CB_IDUBICACION).Tables(0)
        End Function
    End Class

End Class
