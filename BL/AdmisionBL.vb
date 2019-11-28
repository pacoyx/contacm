Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class AdmisionBL

    Public Class Siteds

        'Esta clase se desarrolla para conectarse a la base de datos Access del "Siteds", 
        'el objetivo es consultar la tabla de cobertura y obtener los datos de cobertura del paciente
        'esta tabla se llena cuando se imprime el formulario de 'hoja de atencion' desde  la aplicacion del Siteds.

        Public Sub get_Cobertura_x_Paciente(ByVal Dni_ As String, ByVal Seguro As String, ByRef dt_datgen As DataTable)

            Dim nombrebd As String = "epslog.mdb"
            'Dim ArchivoDatos As String = "\\serverigf\BD_SITEDS\DB\" & nombrebd
            Dim ArchivoDatos As String = "\\serverigf\BD_SITEDS\DB\" & nombrebd
            Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & ArchivoDatos
            Dim cnSiteds As New OleDb.OleDbConnection(CadenaConexion)
            cnSiteds.Open()
            ' where dAutoDate= '" & "27/01/2014" & "'
            'Format('" & Date.Now & "', 'yyyymmdd')
            Dim query As String = "select max(d.cAutoCode) as cAutoCode,CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)) as Fecha,d.cAsegCode,c.cCobrCode,c.sCobrName,c.nCoPgFijo,c.nCoPgVari,d.cAfilType,d.cMoneCode from DatosGenerales d " & _
            " inner join Coberturas c on c.cAutoCode=d.cAutoCode and c.cAsegCode=d.cAsegCode and c.cEPSsCode=d.cEPSsCode " & _
            " where CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)) = '" & Date.Now.Date & "' and d.cEPSsCode='" & Seguro & "' and d.cAsegDNIs='" & Dni_ & "' " & _
            " group by CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)),d.cAsegCode,c.cCobrCode,c.sCobrName,c.nCoPgFijo,c.nCoPgVari,d.cAfilType,d.cMoneCode"

            'select CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)), Mid(dAutoDate, 1, 8),Format('" & Date.Now & "', 'yyyymmdd'),*  from DatosGenerales
            'select Mid(dAutoDate, 1, 8),Format('" & Date.Now & "', 'yyyymmdd'),*  from DatosGenerales where CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)) = '" & "27/01/2014" & "'


            ' Dim dt_datgen As New DataTable
            'Dim dt_cobertura As New DataTable
            'Dim dr_fila() As DataRow
            ' Dim ult_cod_atencion As String = String.Empty
            Dim da_Cobertur As New OleDb.OleDbDataAdapter(query, cnSiteds)

            da_Cobertur.Fill(dt_datgen)

            'ult_cod_atencion = dt_datgen.Compute("max(cAutoCode)", "")
            'dr_fila = dt_datgen.Select("cAutoCode = " & ult_cod_atencion)

            'Dim epsCod As String = ""
            'Dim asegCod As String = ""
            'Dim autoCod As String = ""

            'If dr_fila.Length > 0 Then
            '    epsCod = dr_fila(0)("cEPSsCode")
            '    asegCod = dr_fila(0)("cAsegCode")
            '    autoCod = dr_fila(0)("cAutoCode")
            'End If

            'query = "select * from Coberturas where cEPSsCode  = '" & epsCod & "' and cAsegCode = '" & asegCod & "' and cAutoCode = '" & autoCod & "' "

            'da_Cobertur = New OleDb.OleDbDataAdapter(query, cnSiteds)
            'da_Cobertur.Fill(dt_cobertura)

            'Dim coPagoFijo As Double = 0
            'Dim coPagoVar As Double = 0

            'If dt_cobertura.Rows.Count > 0 Then
            '    coPagoFijo = dt_cobertura.Rows(0)("nCopgFijo")
            '    coPagoVar = dt_cobertura.Rows(0)("nCopgVari")
            'End If

            'dt_cobertura.Dispose()
            'dt_datgen.Dispose()

            'Return ds_cobertura

        End Sub
        Public Sub get_Cobertura_x_Paciente2(ByVal Dni_ As String, ByVal Seguro As String, ByRef dt_datgen As DataTable)

            Dim nombrebd As String = "epslog.mdb"
            Dim ArchivoDatos As String = "\\serverigf\BD_SITEDS\DB\" & nombrebd
            Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & ArchivoDatos
            Dim cnSiteds As New OleDb.OleDbConnection(CadenaConexion)
            cnSiteds.Open()
            Dim query As String = "select max(d.cAutoCode) as cAutoCode,CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)) as Fecha,d.cAsegCode " & _
                ",c.cBeneCode as cCobrCode,c.sCobrName,c.nCoPgFijo,c.nCoPgVari,1 as cAfilType,d.cMoneCode from Seguros_DatosGenerales d " & _
                " inner join Seguros_Coberturas c on c.cAutoCode=d.cAutoCode and c.cAsegCode=d.cAsegCode and c.cEPSsCode=d.cEPSsCode " & _
            " where CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)) = '" & Date.Now.Date & "' " & _
                " and d.cEPSsCode='" & Seguro & "' and d.sDocuNumb='" & Dni_ & "' " & _
                " group by CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)),d.cAsegCode,c.cBeneCode,c.sCobrName," & _
                " c.nCoPgFijo,c.nCoPgVari,d.cMoneCode"


            Dim da_Cobertur As New OleDb.OleDbDataAdapter(query, cnSiteds)

            da_Cobertur.Fill(dt_datgen)

        End Sub
        Public Sub get_Cobertura_x_CodeAutoriza(ByVal CodAutoriza As String, ByVal Seguro As String, ByRef dt_datgen As DataTable)

            Dim nombrebd As String = "epslog.mdb"
            'Dim ArchivoDatos As String = "\\serverigf\BD_SITEDS\DB\" & nombrebd
            Dim ArchivoDatos As String = "\\serverigf\BD_SITEDS\DB\" & nombrebd
            Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & ArchivoDatos
            Dim cnSiteds As New OleDb.OleDbConnection(CadenaConexion)
            cnSiteds.Open()
            ' where dAutoDate= '" & "27/01/2014" & "'
            'Format('" & Date.Now & "', 'yyyymmdd')
            Dim query As String = "select max(d.cAutoCode) as cAutoCode,CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)) as Fecha,d.cAsegCode,c.cCobrCode,c.sCobrName,c.nCoPgFijo,c.nCoPgVari,d.cAfilType,d.cMoneCode from DatosGenerales d " & _
            " inner join Coberturas c on c.cAutoCode=d.cAutoCode and c.cAsegCode=d.cAsegCode and c.cEPSsCode=d.cEPSsCode " & _
            " where d.cEPSsCode='" & Seguro & "' and d.cAutoCode='" & CodAutoriza & "' " & _
            " group by CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)),d.cAsegCode,c.cCobrCode,c.sCobrName,c.nCoPgFijo,c.nCoPgVari,d.cAfilType,d.cMoneCode"

            Dim da_Cobertur As New OleDb.OleDbDataAdapter(query, cnSiteds)

            da_Cobertur.Fill(dt_datgen)
        End Sub
        Public Sub get_Cobertura_x_CodeAutoriza2(ByVal CodAutoriza As String, ByVal Seguro As String, ByRef dt_datgen As DataTable)

            Dim nombrebd As String = "epslog.mdb"
            'Dim ArchivoDatos As String = "\\serverigf\BD_SITEDS\DB\" & nombrebd
            Dim ArchivoDatos As String = "\\serverigf\BD_SITEDS\DB\" & nombrebd
            Dim CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & ArchivoDatos
            Dim cnSiteds As New OleDb.OleDbConnection(CadenaConexion)
            cnSiteds.Open()
            ' where dAutoDate= '" & "27/01/2014" & "'
            'Format('" & Date.Now & "', 'yyyymmdd')
            Dim query As String = "select max(d.cAutoCode) as cAutoCode,CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)) as Fecha,d.cAsegCode,c.cBeneCode as cCobrCode,c.sCobrName,c.nCoPgFijo,c.nCoPgVari,1 as cAfilType,d.cMoneCode from Seguros_DatosGenerales d " & _
            " inner join Seguros_Coberturas  c on c.cAutoCode=d.cAutoCode and c.cAsegCode=d.cAsegCode and c.cEPSsCode=d.cEPSsCode " & _
            " where d.cEPSsCode='" & Seguro & "' and d.cAutoCode='" & CodAutoriza & "' " & _
            " group by CDate(Mid(dAutoDate, 1, 4) & '/' & Mid(dAutoDate, 5, 2) & '/' & Mid(dAutoDate, 7, 2)),d.cAsegCode,c.cBeneCode,c.sCobrName,c.nCoPgFijo,c.nCoPgVari,d.cMoneCode"

            Dim da_Cobertur As New OleDb.OleDbDataAdapter(query, cnSiteds)

            da_Cobertur.Fill(dt_datgen)
        End Sub
    End Class

    Public Class SG_AD_TB_TOPICO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_TOPICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.AdmisionBE.SG_AD_TB_TOPICO_DET)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_I_TOPICO", oIdUsuarioActivo, oIdEstacionActiva _
                       , obe.TO_IDNUMHIST _
                       , obe.TO_FECHA _
                       , obe.TO_NUM_ORDEN _
                       , obe.TO_IDTURNO _
                       , obe.TO_HORA_ATENC _
                       , obe.TO_TOTAL _
                       , obe.TO_OBSERVACION _
                       , obe.TO_IDEMPRESA _
                       , obe.TO_MEDICODER _
                       , obe.TO_PERSONAS _
                   )
                obe.TO_ID = N

                For Each d As BE.AdmisionBE.SG_AD_TB_TOPICO_DET In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_AD_SP_I_TOPICO_DET", obe.TO_ID, .DT_IDARTICULO, .DT_CANT, .DT_PRECIO, .DT_SUBTOTAL, .DT_IGV, .DT_TOTAL)
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

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_TOPICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_det As List(Of BE.AdmisionBE.SG_AD_TB_TOPICO_DET)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_U_TOPICO", oIdUsuarioActivo, oIdEstacionActiva _
                                            , obe.TO_ID _
                                            , obe.TO_IDNUMHIST _
                                            , obe.TO_HORA_ATENC _
                                            , obe.TO_TOTAL _
                                            , obe.TO_OBSERVACION _
                                            , obe.TO_MEDICODER _
                                            , obe.TO_PERSONAS _
                                            )
                'obe.MO_ID = N
                If N = 0 Then
                    SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_D_TOPICO_DET", obe.TO_ID)
                    For Each d As BE.AdmisionBE.SG_AD_TB_TOPICO_DET In ls_det
                        With d
                            SqlHelper.ExecuteNonQuery(TRvar, "SG_AD_SP_I_TOPICO_DET", obe.TO_ID, .DT_IDARTICULO, .DT_CANT, .DT_PRECIO, .DT_SUBTOTAL, .DT_IGV, .DT_TOTAL)
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

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_TOPICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_TOPICO", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.TO_ID _
        )
            Return N
        End Function

        Public Function SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_TOPICO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_TOPICO_1", obe.TO_FECHA, obe.TO_IDTURNO, obe.TO_IDEMPRESA).Tables(0)
        End Function

        Public Function SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_TOPICO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_TOPICO_2", obe.TO_ID).Tables(0)
        End Function
        'Public Function SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_TOPICO) As DataTable
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_TOPICO_2", obe.TO_ID).Tables(0)
        'End Function

        'Public Function SEL03(ByVal obe As BE.AdmisionBE.SG_AD_TB_TOPICO) As DataSet
        '    Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_TOPICO_3", obe.TO_ID)
        'End Function
    End Class

    Public Class SG_AD_TB_TURNO

        Inherits ClsBD
        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_TURNO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_TURNO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.TU_ID _
             , obe.TU_DESCRIPCION _
             , obe.TU_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_TURNO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_TURNO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.TU_ID _
             , obe.TU_DESCRIPCION _
             , obe.TU_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_TURNO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_TURNO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.TU_ID _
             , obe.TU_IDEMPRESA _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal Empresa As Integer, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_TURNO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TU_IDEMPRESA", System.Data.SqlDbType.Int).Value = Empresa
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_TURNO, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S2_TURNO", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@TU_ID", System.Data.SqlDbType.Int).Value = obe.TU_ID
        '    cmd.Parameters.Add("@TU_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.TU_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_AD_TB_UBICACION

        Inherits ClsBD
        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_UBICACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_UBICACION", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.UB_Descripcion _
             , obe.UB_IdEmpresa _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_UBICACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_UBICACION", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.UB_ID _
             , obe.UB_Descripcion _
             , obe.UB_IdEmpresa _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_UBICACION, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_UBICACION", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.UB_ID _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_UBICACION, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_UBICACION", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@UB_IdEmpresa", System.Data.SqlDbType.Int).Value = obe.UB_IdEmpresa
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE_SG_AD_TB_UBICACION, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S2_UBICACION", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@UB_ID", System.Data.SqlDbType.int).Value = obe.UB_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class


    Public Class SG_AD_TB_UsuXMedico

        Inherits ClsBD
        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_UsuXMedico, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_UsuXMedico", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.UM_IDUSUARIO _
             , obe.UM_IDMEDICO _
             , obe.UM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_UsuXMedico, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_UsuXMedico", oIdUsuarioActivo, oIdEstacionActiva _
            , obe.UM_IDUSUARIO _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_UsuXMedico, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_UsuXMedico", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_UsuXMedico, ByVal tIPO As Integer, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S2_UsuXMedico", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@UM_IDUSUARIO ", System.Data.SqlDbType.Int).Value = obe.UM_IDUSUARIO
            cmd.Parameters.Add("@UM_Tipo ", System.Data.SqlDbType.Int).Value = tIPO
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL03(ByVal obe As BE.AdmisionBE.SG_AD_TB_UsuXMedico, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S3_UsuXMedico", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL04(ByVal obe As BE.AdmisionBE.SG_AD_TB_UsuXMedico, ByVal fechas As Date, ByRef oDt As DataTable, ByVal Servicio As Integer)
            Dim cmd As New SqlCommand("SG_AD_SP_S4_UsuXMedico", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@UM_IDUSUARIO ", System.Data.SqlDbType.Int).Value = obe.UM_IDUSUARIO
            cmd.Parameters.Add("@ME_IDEMPRESA ", System.Data.SqlDbType.Int).Value = obe.UM_IDEMPRESA
            cmd.Parameters.Add("@ME_FECHA ", System.Data.SqlDbType.DateTime).Value = fechas
            cmd.Parameters.Add("@ME_IDServicio ", System.Data.SqlDbType.Int).Value = Servicio
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

    End Class


    Public Class SG_AD_TB_GrupoSanguineo

        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_GrupoSanguineo, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_GrupoSanguineo", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.GS_NOMBRE _
             , obe.GS_ESTADO _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_GrupoSanguineo, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_GrupoSanguineo", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.GS_ID _
             , obe.GS_NOMBRE _
             , obe.GS_ESTADO _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_GrupoSanguineo, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_GrupoSanguineo", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.GS_ID _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_GrupoSanguineo, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_GrupoSanguineo", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S2_GrupoSanguineo", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@GS_ID", System.Data.SqlDbType.Int).Value = obe.GS_ID
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

    End Class


    Public Class SG_AD_TB_CONDICION_ASEGURADO

        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONDICION_ASEGURADO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_CONDICION_ASEGURADO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CA_NOMBRE _
             , obe.CA_ESTADO _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONDICION_ASEGURADO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_CONDICION_ASEGURADO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CA_ID _
             , obe.CA_NOMBRE _
             , obe.CA_ESTADO _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONDICION_ASEGURADO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_CONDICION_ASEGURADO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CA_ID _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONDICION_ASEGURADO, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_CONDICION_ASEGURADO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S2_CONDICION_ASEGURADO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@CA_ID", System.Data.SqlDbType.Int).Value = obe.CA_ID
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

    End Class

    Public Class SG_AD_TB_RECOMENDADO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_RECOMENDADO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_RECOMENDADO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.RE_NOMBRE _
             , obe.RE_ESTADO _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_RECOMENDADO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_RECOMENDADO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.RE_ID _
             , obe.RE_NOMBRE _
             , obe.RE_ESTADO _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_RECOMENDADO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_RECOMENDADO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.RE_ID _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_RECOMENDADO, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_RECOMENDADO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S2_RECOMENDADO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@RE_ID", System.Data.SqlDbType.Int).Value = obe.RE_ID
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

    End Class

    Public Class SG_AD_TB_OCUPACIONES_MEDICAS
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_OCUPACIONES_MEDICAS", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.OM_IDPROGRAMACION _
             , obe.OM_DESCRIPCION _
             , obe.OM_NUM_ORDEN _
             , obe.OM_HORA_PROG _
             , obe.OM_FECHA _
             , obe.OM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_OCUPACIONES_MEDICAS", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.OM_ID _
             , obe.OM_DESCRIPCION _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_OCUPACIONES_MEDICAS", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.OM_ID _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S1_OCUPACIONES_MEDICAS", obe.OM_ID)
            If drr.HasRows Then
                drr.Read()
                With obe
                    .HasRow = True
                    .OM_IDPROGRAMACION = drr("OM_IDPROGRAMACION")
                    .OM_DESCRIPCION = drr("OM_DESCRIPCION")
                    .OM_NUM_ORDEN = drr("OM_NUM_ORDEN")
                    .OM_HORA_PROG = drr("OM_HORA_PROG")
                    .OM_FECHA = drr("OM_FECHA")
                    .OM_IDEMPRESA = drr("OM_IDEMPRESA")
                End With
            End If

            drr.Close()
        End Sub

        'Public Sub SEL02(ByVal obe As BE_SG_AD_TB_OCUPACIONES_MEDICAS, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S2_OCUPACIONES_MEDICAS", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@OM_ID", System.Data.SqlDbType.int).Value = obe.OM_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_AD_TB_CUENTA_CAB

        Inherits ClsBD

        Public Function Insert_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "TMP_SG_AD_SP_I_CUENTA_DET", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.TCD_ITEM _
             , obe.TCD_IDARTICULO _
             , obe.TCD_CANT _
             , obe.TCD_TOTAL _
             , obe.TCD_PRECIO _
             , obe.TCD_DESCUENTO _
             , obe.TCD_SUB_TOTAL _
             , obe.TCD_IGV _
             , obe.TCD_SINPAGO _
             , obe.TCD_DSCTO_OTRO _
             , obe.TCD_SEG_CUBRE _
             , obe.TCD_DEDUCIBLE)
            Return N
        End Function

        Public Function Update_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "TMP_SG_AD_SP_U_CUENTA_DET", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.TCD_ITEM _
             , obe.TCD_IDARTICULO _
             , obe.TCD_CANT _
             , obe.TCD_TOTAL _
             , obe.TCD_PRECIO _
             , obe.TCD_DESCUENTO _
             , obe.TCD_SUB_TOTAL _
             , obe.TCD_IGV _
             , obe.TCD_SINPAGO _
             , obe.TCD_DSCTO_OTRO _
             , obe.TCD_SEG_CUBRE _
             , obe.TCD_DEDUCIBLE _
             , obe.TCD_DSCTO_PORC)
            Return N
        End Function

        Public Function Delete_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "TMP_SG_AD_SP_D_CUENTA_DET", oIdUsuarioActivo, oIdEstacionActiva, obe.TCD_ITEM _
             )
            Return N
        End Function

        Public Function Delete_TMP_ADMIN(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "TMP_SG_AD_SP_D_CUENTA_DET_ADMIN", oIdUsuarioActivo, oIdEstacionActiva, obe.TCD_ITEM _
             )
            Return N
        End Function
        Public Function DeleteDetalle_val(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_D_CUENTA_DET_val", obe.TCD_IDCAB, obe.TCD_IDCITA, obe.TCD_ITEM, oIdUsuarioActivo, oIdEstacionActiva).Tables(0)
        End Function

        Public Function Delete2_TMP(ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "TMP_SG_AD_SP_D2_CUENTA_DET", oIdUsuarioActivo, oIdEstacionActiva)
            Return N
        End Function

        Public Sub SEL01_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("TMP_SG_AD_SP_S1_CUENTA_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pIdUsuarioActivo", System.Data.SqlDbType.VarChar).Value = oIdUsuarioActivo
            cmd.Parameters.Add("@pIdEstacionActiva", System.Data.SqlDbType.VarChar).Value = oIdEstacionActiva
            cmd.Parameters.Add("@TCD_IDCAB", System.Data.SqlDbType.Int).Value = obe.TCD_IDCAB
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL_TMP01(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("TMP_SG_AD_SP_CUENTA_DET_1", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TCD_IDCAB", System.Data.SqlDbType.Int).Value = obe.TCD_IDCAB
            cmd.Parameters.Add("@TCD_IDCITA", System.Data.SqlDbType.Int).Value = obe.TCD_IDCITA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub


        Public Sub SEL02_TMP(ByRef Entidad As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "TMP_SG_AD_SP_S2_CUENTA_DET", Entidad.TCD_IDCAB, Entidad.TCD_IDCITA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .TCD_IDARTICULO = drr("CD_IDARTICULO")
                    .TCD_TOTAL = drr("CD_TOTAL")
                    .TCD_PRECIO = drr("CD_PRECIO")
                    .TCD_DESCUENTO = drr("CD_DESCUENTO")
                    .TCD_SUB_TOTAL = drr("CD_SUB_TOTAL")
                    .TCD_IGV = drr("CD_IGV")
                    .TCD_IDCOMPROBANTE = drr("CD_IDCOMPROBANTE")
                    .TCD_DSCTO_OTRO = drr("CD_DSCTO_OTRO")
                    .TCD_SEG_CUBRE = drr("CD_SEG_CUBRE")
                End With
            End If

            drr.Close()

        End Sub

        Public Sub SEL03_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("TMP_SG_AD_SP_S3_CUENTA_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pIdUsuarioActivo", System.Data.SqlDbType.VarChar).Value = oIdUsuarioActivo
            cmd.Parameters.Add("@pIdEstacionActiva", System.Data.SqlDbType.VarChar).Value = oIdEstacionActiva
            cmd.Parameters.Add("@TCD_IDCAB", System.Data.SqlDbType.Int).Value = obe.TCD_IDCAB
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL04_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal igv As Integer, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("TMP_SG_AD_SP_S4_CUENTA_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pIdUsuarioActivo", System.Data.SqlDbType.VarChar).Value = oIdUsuarioActivo
            cmd.Parameters.Add("@pIdEstacionActiva", System.Data.SqlDbType.VarChar).Value = oIdEstacionActiva
            cmd.Parameters.Add("@TCD_IDCAB", System.Data.SqlDbType.Int).Value = obe.TCD_IDCAB
            cmd.Parameters.Add("@IGV", System.Data.SqlDbType.Int).Value = igv
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL05_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("TMP_SG_AD_SP_S5_CUENTA_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pIdUsuarioActivo", System.Data.SqlDbType.VarChar).Value = oIdUsuarioActivo
            cmd.Parameters.Add("@pIdEstacionActiva", System.Data.SqlDbType.VarChar).Value = oIdEstacionActiva
            cmd.Parameters.Add("@TCD_IDCAB", System.Data.SqlDbType.Int).Value = obe.TCD_IDCAB
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL06_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("TMP_SG_AD_SP_S6_CUENTA_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TCD_IDCAB", System.Data.SqlDbType.Int).Value = obe.TCD_IDCAB
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub
        Public Function SEL07_TMP(ByVal IDCUENTA As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CUENTA_DET_7", IDCUENTA).Tables(0)
        End Function
        '----------------------

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal Citas As Integer) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva, obe.CC_ID, Citas _
             )
            Return N
        End Function

        Public Sub SEL01(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S1_CUENTA_CAB", Entidad.CC_IDCITA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CC_ID = drr("CC_ID")
                    .CC_IDTIPO_ORI = drr("CC_IDTIPO_ORI")
                    .CC_ESTADO_CTA = drr("CC_ESTADO_CTA")
                    .CC_ESTADO_REG = drr("CC_ESTADO_REG")
                    .CC_SIT_COD_EPS = drr("CC_SIT_COD_EPS").ToString
                    .CC_SIT_COD_ASEG = drr("CC_SIT_COD_ASEG").ToString
                    .CC_SIT_FEC_AUTORI = drr("CC_SIT_FEC_AUTORI").ToString
                    .CC_SIT_COD_COBER = drr("CC_SIT_COD_COBER").ToString
                    .CC_SIT_COPG_FIJO = drr("CC_SIT_COPG_FIJO")
                    .CC_SIT_COPG_VARI = drr("CC_SIT_COPG_VARI")
                    .CC_SIT_COD_GENE = drr("CC_SIT_COD_GENE").ToString
                    .CC_INGRESO_MANUAL = drr("CC_INGRESO_MANUAL")
                    .CC_TIPOAFILIACION = drr("CC_TIPOAFILIACION")
                End With
            End If

            drr.Close()

        End Sub

        Public Sub SEL02(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S2_CUENTA_CAB", Entidad.CC_IDNUM_HIST, Entidad.CC_FECHA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CC_ID = drr("CC_ID")
                    .CC_IDTIPO_ORI = drr("CC_IDTIPO_ORI")
                    .CC_ESTADO_CTA = drr("CC_ESTADO_CTA")
                    .CC_ESTADO_REG = drr("CC_ESTADO_REG")
                    .CC_IDTIPO_ATENC = drr("CC_IDTIPO_ATENC")
                    .CC_IDSEGURO = drr("CC_IDSEGURO")
                    .CC_SIT_COPG_FIJO = drr("CC_SIT_COPG_FIJO")
                    .CC_SIT_COPG_VARI = drr("CC_SIT_COPG_VARI")
                    .CC_SIT_COD_COBER = Val(drr("CC_SIT_COD_COBER").ToString)
                    .CC_FECHA = drr("CC_FECHA")
                    .CC_SIT_COD_EPS = drr("CC_SIT_COD_EPS").ToString
                    .CC_SIT_COD_ASEG = drr("CC_SIT_COD_ASEG")
                    .CC_SIT_FEC_AUTORI = drr("CC_SIT_FEC_AUTORI")
                    .CC_SIT_COD_GENE = drr("CC_SIT_COD_GENE")
                    .CC_INGRESO_MANUAL = drr("CC_INGRESO_MANUAL")
                    .CC_TIPOAFILIACION = drr("CC_TIPOAFILIACION")
                End With
            End If
            drr.Close()
        End Sub

        Public Sub SEL03(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S3_CUENTA_CAB", Entidad.CC_IDCITA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CC_ID = drr("CC_ID")
                    .CC_IDTIPO_ORI = drr("CC_IDTIPO_ORI")
                    .CC_ESTADO_CTA = drr("CC_ESTADO_CTA")
                    .CC_ESTADO_REG = drr("CC_ESTADO_REG")
                    .CC_IDTIPO_ATENC = drr("CC_IDTIPO_ATENC")
                    .CC_IDSEGURO = drr("CC_IDSEGURO")
                    .CC_SIT_COPG_FIJO = drr("CC_SIT_COPG_FIJO")
                    .CC_SIT_COPG_VARI = drr("CC_SIT_COPG_VARI")
                    .CC_FECHA = drr("CC_FECHA")
                End With
            End If

            drr.Close()

        End Sub

        Public Sub SEL04(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S4_CUENTA_CAB", Entidad.CC_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CC_ID = drr("CC_ID")
                    .CC_IDTIPO_ORI = drr("CC_IDTIPO_ORI")
                    .CC_IDNUM_HIST = drr("CC_IDNUM_HIST")
                    .CC_IDCLIENTE = drr("CC_IDCLIENTE")
                    .CC_IDTIPO_ATENC = drr("CC_IDTIPO_ATENC")
                    .CC_IDSEGURO = drr("CC_IDSEGURO")
                    .CC_FECHA = drr("CC_FECHA")
                    .CC_IDPREFAC = drr("CC_IDPREFAC")
                    .CC_SIT_COD_EPS = drr("CC_SIT_COD_EPS").ToString
                    .CC_SIT_COD_ASEG = drr("CC_SIT_COD_ASEG")
                    .CC_SIT_FEC_AUTORI = drr("CC_SIT_FEC_AUTORI")
                    .CC_SIT_COD_COBER = drr("CC_SIT_COD_COBER")
                    .CC_SIT_COPG_FIJO = drr("CC_SIT_COPG_FIJO")
                    .CC_SIT_COPG_VARI = drr("CC_SIT_COPG_VARI")
                    .CC_SIT_COD_GENE = drr("CC_SIT_COD_GENE")
                    .CC_TIPOAFILIACION = drr("CC_TIPOAFILIACION")
                    .CC_MEDICO = drr("PR_MEDICO")
                    .CC_SIT_MONTO_IMP = drr("CC_SIT_MONTO_IMP")
                    .CC_ESTADO_PROC = drr("CC_ESTADO_PROC")
                    .CC_FECHA_PROC = drr("CC_FECHA_PROC")
                End With
            End If

            drr.Close()

        End Sub

        Public Sub SEL14(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S_CUENTA_CAB_14", Entidad.CC_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CC_ID = drr("CC_ID")
                    .CC_IDTIPO_ORI = drr("CC_IDTIPO_ORI")
                    .CC_IDNUM_HIST = drr("CC_IDNUM_HIST")
                    .CC_IDCLIENTE = drr("CC_IDCLIENTE")
                    .CC_IDTIPO_ATENC = drr("CC_IDTIPO_ATENC")
                    .CC_IDSEGURO = drr("CC_IDSEGURO")
                    .CC_FECHA = drr("CC_FECHA")
                    .CC_IDPREFAC = drr("CC_IDPREFAC")
                    .CC_SIT_COD_EPS = drr("CC_SIT_COD_EPS").ToString
                    .CC_SIT_COD_ASEG = drr("CC_SIT_COD_ASEG")
                    .CC_SIT_FEC_AUTORI = drr("CC_SIT_FEC_AUTORI")
                    .CC_SIT_COD_COBER = drr("CC_SIT_COD_COBER")
                    .CC_SIT_COPG_FIJO = drr("CC_SIT_COPG_FIJO")
                    .CC_SIT_COPG_VARI = drr("CC_SIT_COPG_VARI")
                    .CC_SIT_COD_GENE = drr("CC_SIT_COD_GENE")
                    .CC_TIPOAFILIACION = drr("CC_TIPOAFILIACION")
                    .CC_MEDICO = drr("PR_MEDICO")
                    .CC_SIT_MONTO_IMP = drr("CC_SIT_MONTO_IMP")
                    .CC_ESTADO_PROC = drr("CC_ESTADO_PROC")
                    .CC_FECHA_PROC = drr("CC_FECHA_PROC")
                End With
            End If

            drr.Close()

        End Sub

        Public Sub SEL05_CuentaDet(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S5_CUENTA_CAB", Entidad.CC_IDCITA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CC_ID = drr("CC_ID")
                    .CC_IDTIPO_ORI = drr("CC_IDTIPO_ORI")
                    .CC_ESTADO_CTA = drr("CC_ESTADO_CTA")
                    .CC_ESTADO_REG = drr("CC_ESTADO_REG")
                    .CC_SIT_COD_EPS = drr("CC_SIT_COD_EPS").ToString
                    .CC_SIT_COD_ASEG = drr("CC_SIT_COD_ASEG").ToString
                    .CC_SIT_FEC_AUTORI = drr("CC_SIT_FEC_AUTORI").ToString
                    .CC_SIT_COD_COBER = drr("CC_SIT_COD_COBER").ToString
                    .CC_SIT_COPG_FIJO = drr("CC_SIT_COPG_FIJO")
                    .CC_SIT_COPG_VARI = drr("CC_SIT_COPG_VARI")
                    .CC_SIT_COD_GENE = drr("CC_SIT_COD_GENE").ToString
                    .CC_INGRESO_MANUAL = drr("CC_INGRESO_MANUAL")
                    .CC_TIPOAFILIACION = drr("CC_TIPOAFILIACION")
                End With
            End If

            drr.Close()

        End Sub


        Public Sub SEL05(ByVal obe As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal COLUMNA As String, ByVal VALOR As String, ByVal tipo As Boolean, ByVal FechaI As String, ByVal FechaF As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Dim VAlFecha As String = ""
            If tipo = True Then VAlFecha = " AND CONVERT(DATE,CC_FECHA) BETWEEN '" & FechaI & "' AND '" & FechaF & "'"

            Scrip = "SELECT top 1000 CC_ID,CC_IDTIPO_ORI" & _
                          ",OA_DESCRIPCION[TIPO]" & _
                          ",CC_IDNUM_HIST" & _
                          ",HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[PACIENTE] " & _
                          ",CC_IDCLIENTE" & _
                          ",CC_IDTIPO_ATENC" & _
                          ",CC_IDSEGURO" & _
                          ",CC_FECHA" & _
                          ",CC_IDPREFAC" & _
                          ",CC_SIT_COD_EPS" & _
                          ",CC_SIT_COD_ASEG" & _
                          ",CC_SIT_FEC_AUTORI" & _
                          ",CC_SIT_COD_COBER" & _
                          ",CC_SIT_COPG_FIJO" & _
                          ",CC_SIT_COPG_VARI" & _
                          ",CC_SIT_COD_GENE" & _
                          ",CC_TIPOAFILIACION" & _
                          ",CASE WHEN PR_MEDICO IS NULL THEN '' ELSE PR_MEDICO END[MEDICO] " & _
                          ",case when CC_IDPREFAC is null then 'PENDIENTE' else 'PRE-FACTURADO' end [ESTADO] " & _
                          ",CC_SIT_MONTO_IMP " & _
                          ",CC_ESTADO_PROC " & _
                          ",isnull(CC_FECHA_PROC,GETDATE())[CC_FECHA_PROC] " & _
                          ",case when CA_DESCRIPCION IS null then 'PARTICULAR' ELSE CA_DESCRIPCION END[CA_DESCRIPCION] " & _
                    "FROM SG_AD_TB_CUENTA_CAB " & _
                       "INNER JOIN SG_AD_TB_ORIGEN_ATENC ON OA_ID =CC_IDTIPO_ORI " & _
                       "INNER JOIN SG_AD_TB_HISTO_CLINI ON HC_NUM_HIST =CC_IDNUM_HIST " & _
                       "LEFT JOIN SG_AD_TB_CITA_MED ON CM_ID=CC_IDCITA " & _
                       "LEFT JOIN SG_AD_TB_PROGRAMA_CITA ON PR_ID =CM_IDPROGRAMACION AND CM_IDEMPRESA =PR_IDEMPRESA " & _
                       "left join SG_FA_TB_CIA_ASEG on CA_ID =CC_IDSEGURO and CA_IDEMPRESA =CC_IDEMPRESA " & _
                    "where ((CC_IDTIPO_ORI=1 and CC_IDTIPO_ATENC=2) or (CC_IDTIPO_ORI>1)) and CC_IDEMPRESA=" & obe.CC_IDEMPRESA & " and " & COLUMNA & " like '%" & VALOR & "%' " & VAlFecha & " order by CC_ID desc"

            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL06(ByVal obe As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal COLUMNA As String, ByVal VALOR As String, ByVal tipo As Boolean, ByVal FechaI As String, ByVal FechaF As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Dim VAlFecha As String = ""
            If tipo = True Then VAlFecha = " AND CONVERT(DATE,CC_FECHA) BETWEEN '" & FechaI & "' AND '" & FechaF & "'"

            Scrip = "SELECT top 500 CC_ID,CC_IDTIPO_ORI" & _
                          ",OA_DESCRIPCION[TIPO]" & _
                          ",CC_IDNUM_HIST" & _
                          ",HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[PACIENTE] " & _
                          ",CC_IDCLIENTE" & _
                          ",CC_IDTIPO_ATENC" & _
                          ",CC_IDSEGURO" & _
                          ",CC_FECHA" & _
                          ",CC_IDPREFAC" & _
                          ",CC_SIT_COD_EPS" & _
                          ",CC_SIT_COD_ASEG" & _
                          ",CC_SIT_FEC_AUTORI" & _
                          ",CC_SIT_COD_COBER" & _
                          ",CC_SIT_COPG_FIJO" & _
                          ",CC_SIT_COPG_VARI" & _
                          ",CC_SIT_COD_GENE" & _
                          ",CC_TIPOAFILIACION" & _
                          ",CASE WHEN PR_MEDICO IS NULL THEN '' ELSE PR_MEDICO END[MEDICO] " & _
                          ",case when CC_IDPREFAC is null then 'PENDIENTE' else 'PRE-FACTURADO' end [ESTADO] " & _
                    "FROM SG_AD_TB_CUENTA_CAB " & _
                       "INNER JOIN SG_AD_TB_ORIGEN_ATENC ON OA_ID =CC_IDTIPO_ORI " & _
                       "INNER JOIN SG_AD_TB_HISTO_CLINI ON HC_NUM_HIST =CC_IDNUM_HIST " & _
                       "LEFT JOIN SG_AD_TB_CITA_MED ON CM_ID=CC_IDCITA " & _
                       "LEFT JOIN SG_AD_TB_PROGRAMA_CITA ON PR_ID =CM_IDPROGRAMACION AND CM_IDEMPRESA =PR_IDEMPRESA " & _
                    "where CC_IDEMPRESA=" & obe.CC_IDEMPRESA & " and CC_IDTIPO_ORI=3 and CC_IDPREFAC is not null and " & COLUMNA & " like '%" & VALOR & "%' " & VAlFecha & " order by CC_ID desc"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL06_VALCuenta(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S6_CUENTA_CAB", Entidad.CC_IDNUM_HIST, Entidad.CC_FECHA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CC_ID = drr("CC_ID")
                    .CC_IDTIPO_ORI = drr("CC_IDTIPO_ORI")
                    .CC_ESTADO_CTA = drr("CC_ESTADO_CTA")
                    .CC_ESTADO_REG = drr("CC_ESTADO_REG")
                    .CC_IDTIPO_ATENC = drr("CC_IDTIPO_ATENC")
                    .CC_IDSEGURO = drr("CC_IDSEGURO")
                    .CC_SIT_COPG_FIJO = drr("CC_SIT_COPG_FIJO")
                    .CC_SIT_COPG_VARI = drr("CC_SIT_COPG_VARI")
                    .CC_SIT_COD_COBER = Val(drr("CC_SIT_COD_COBER").ToString)
                    .CC_FECHA = drr("CC_FECHA")
                    .CC_SIT_COD_EPS = drr("CC_SIT_COD_EPS")
                    .CC_SIT_COD_ASEG = drr("CC_SIT_COD_ASEG")
                    .CC_SIT_FEC_AUTORI = drr("CC_SIT_FEC_AUTORI")
                    .CC_SIT_COD_GENE = drr("CC_SIT_COD_GENE")
                    .CC_INGRESO_MANUAL = drr("CC_INGRESO_MANUAL")
                    .CC_TIPOAFILIACION = drr("CC_TIPOAFILIACION")
                End With
            End If
            drr.Close()
        End Sub

        Public Function SEL07(ByVal empresa_ As Integer, ByVal fecha_ini_ As String, ByVal fecha_fin_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S7_CUENTA_CAB", empresa_, fecha_ini_, fecha_fin_).Tables(0)
        End Function

        Public Sub SEL08(ByVal COLUMNA As String, ByVal VALOR As String, ByVal tipo As Boolean, ByVal FechaI As String, ByVal FechaF As String, ByVal TipoOrigen As Integer, ByRef oDt As DataTable)
            Dim Scrip As String
            Dim VAlFecha As String = ""
            Dim VAlOrigen As String = ""
            If tipo = True Then VAlFecha = " AND CONVERT(DATE,CC_FECHA) BETWEEN '" & FechaI & "' AND '" & FechaF & "'"
            If TipoOrigen = 2 Then VAlOrigen = " CC_IDTIPO_ORI=2" Else VAlOrigen = " CC_IDTIPO_ORI in(2,3,6)"

            Scrip = "SELECT top 500 CC_ID,CC_IDTIPO_ORI" & _
                          ",OA_DESCRIPCION[TIPO]" & _
                          ",CC_IDNUM_HIST" & _
                          ",HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[PACIENTE] " & _
                          ",CC_IDCLIENTE" & _
                          ",CC_IDTIPO_ATENC" & _
                          ",CC_IDSEGURO" & _
                          ",CC_FECHA" & _
                          ",CC_SIT_COPG_FIJO" & _
                          ",CC_SIT_COPG_VARI " & _
                    "FROM SG_AD_TB_CUENTA_CAB " & _
                       "INNER JOIN SG_AD_TB_ORIGEN_ATENC ON OA_ID =CC_IDTIPO_ORI " & _
                       "INNER JOIN SG_AD_TB_HISTO_CLINI ON HC_NUM_HIST =CC_IDNUM_HIST " & _
                    "where " & VAlOrigen & " and " & COLUMNA & " like '%" & VALOR & "%' " & VAlFecha & " order by CC_ID desc"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL09(ByVal obe As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal COLUMNA As String, ByVal VALOR As String, ByVal tipo As Boolean, ByVal FechaI As String, ByVal FechaF As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Dim VAlFecha As String = ""
            If tipo = True Then VAlFecha = " AND CONVERT(DATE,CC_FECHA) BETWEEN '" & FechaI & "' AND '" & FechaF & "'"

            Scrip = "SELECT top 500 CC_ID,CC_IDTIPO_ORI" & _
                          ",OA_DESCRIPCION[TIPO]" & _
                          ",CC_IDNUM_HIST" & _
                          ",HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[PACIENTE] " & _
                          ",CC_IDCLIENTE" & _
                          ",CC_IDTIPO_ATENC" & _
                          ",CC_IDSEGURO" & _
                          ",CC_FECHA" & _
                          ",CC_IDPREFAC" & _
                          ",CC_SIT_COD_EPS" & _
                          ",CC_SIT_COD_ASEG" & _
                          ",CC_SIT_FEC_AUTORI" & _
                          ",CC_SIT_COD_COBER" & _
                          ",CC_SIT_COPG_FIJO" & _
                          ",CC_SIT_COPG_VARI" & _
                          ",CC_SIT_COD_GENE" & _
                          ",CC_TIPOAFILIACION" & _
                          ",CASE WHEN PR_MEDICO IS NULL THEN case when PF_IDMEDICO is null then '' else PF_IDMEDICO end ELSE PR_MEDICO END[MEDICO] " & _
                          ",case when CC_IDPREFAC is null then 'PENDIENTE' else 'PRE-FACTURADO' end [ESTADO] " & _
                    "FROM SG_AD_TB_CUENTA_CAB " & _
                       "INNER JOIN SG_AD_TB_ORIGEN_ATENC ON OA_ID =CC_IDTIPO_ORI " & _
                       "INNER JOIN SG_AD_TB_HISTO_CLINI ON HC_NUM_HIST =CC_IDNUM_HIST " & _
                       "LEFT JOIN SG_AD_TB_CITA_MED ON CM_ID=CC_IDCITA " & _
                       "LEFT JOIN SG_AD_TB_PROGRAMA_CITA ON PR_ID =CM_IDPROGRAMACION AND CM_IDEMPRESA =PR_IDEMPRESA " & _
                       "left join SG_FA_TB_PRE_FACTURA_CAB on PF_IDCUENTA =CC_ID " & _
                    "where CC_IDEMPRESA=" & obe.CC_IDEMPRESA & " and " & COLUMNA & " like '%" & VALOR & "%' " & VAlFecha & " order by CC_ID desc"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL010_TMP(ByVal obe As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("TMP_SG_AD_SP_S10_CUENTA_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pIdUsuarioActivo", System.Data.SqlDbType.VarChar).Value = oIdUsuarioActivo
            cmd.Parameters.Add("@pIdEstacionActiva", System.Data.SqlDbType.VarChar).Value = oIdEstacionActiva
            cmd.Parameters.Add("@TCD_IDCAB", System.Data.SqlDbType.Int).Value = obe.TCD_IDCAB
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub


        Public Sub SEL11(ByVal Historia As Integer, ByRef oDt As DataTable)
            Dim Scrip As String
            Scrip = "SELECT top 500 CC_ID,CC_IDTIPO_ORI" & _
                          ",OA_DESCRIPCION[TIPO]" & _
                          ",CC_IDNUM_HIST" & _
                          ",HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[PACIENTE] " & _
                          ",CC_IDCLIENTE" & _
                          ",CC_IDTIPO_ATENC" & _
                          ",CC_IDSEGURO" & _
                          ",CC_FECHA" & _
                          ",CC_IDPREFAC" & _
                          ",CC_SIT_COD_EPS" & _
                          ",CC_SIT_COD_ASEG" & _
                          ",CC_SIT_FEC_AUTORI" & _
                          ",CC_SIT_COD_COBER" & _
                          ",CC_SIT_COPG_FIJO" & _
                          ",CC_SIT_COPG_VARI" & _
                          ",CC_SIT_COD_GENE" & _
                          ",CC_TIPOAFILIACION" & _
                          ",CASE WHEN PR_MEDICO IS NULL THEN '' ELSE PR_MEDICO END[MEDICO] " & _
                          ",case when CC_IDPREFAC is null then 'PENDIENTE' else 'PRE-FACTURADO' end [ESTADO] " & _
                    "FROM SG_AD_TB_CUENTA_CAB " & _
                       "INNER JOIN SG_AD_TB_ORIGEN_ATENC ON OA_ID =CC_IDTIPO_ORI " & _
                       "INNER JOIN SG_AD_TB_HISTO_CLINI ON HC_NUM_HIST =CC_IDNUM_HIST " & _
                       "LEFT JOIN SG_AD_TB_CITA_MED ON CM_ID=CC_IDCITA " & _
                       "LEFT JOIN SG_AD_TB_PROGRAMA_CITA ON PR_ID =CM_IDPROGRAMACION AND CM_IDEMPRESA =PR_IDEMPRESA " & _
                    "where HC_NUM_HIST='" & Historia & "' and ((CC_IDSEGURO is not null and DATEADD (DAY  , 7 , convert(date,CC_FECREG))>=convert(date,'" & Now.Date & "')) or (CC_IDSEGURO is null and convert(date,CC_FECREG)=convert(date,'" & Now.Date & "'))) order by CC_ID desc"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Function SEL12(ByVal num_historia_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CUENTA_CAB_12", num_historia_).Tables(0)
        End Function

        Public Sub SEL13(ByVal COLUMNA As String, ByVal VALOR As String, ByRef oDt As DataTable)
            Dim Scrip As String

            Scrip = "SELECT CC_ID,CC_IDTIPO_ORI" & _
                          ",OA_DESCRIPCION[TIPO]" & _
                          ",CC_IDNUM_HIST" & _
                          ",HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[PACIENTE] " & _
                          ",CC_IDCLIENTE" & _
                          ",CC_IDTIPO_ATENC" & _
                          ",CC_IDSEGURO" & _
                          ",CC_FECHA" & _
                          ",CC_SIT_COPG_FIJO" & _
                          ",CC_SIT_COPG_VARI " & _
                    "FROM SG_AD_TB_CUENTA_CAB " & _
                        "INNER JOIN SG_AD_TB_ORIGEN_ATENC ON OA_ID =CC_IDTIPO_ORI " & _
                        "INNER JOIN SG_AD_TB_HISTO_CLINI ON HC_NUM_HIST =CC_IDNUM_HIST " & _
                        "left join  SG_FA_TB_PRE_FACTURA_CAB on PF_IDCUENTA=CC_ID " & _
                    " where " & _
                    "CC_IDTIPO_ORI =2 and (PF_FacTramite =0 or PF_FacTramite is null) and " & COLUMNA & " like '%" & VALOR & "%' order by CC_ID desc"
            ''--CC_FECHA > DATEADD(DD,-30,GETDATE())
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub
    End Class


    Public Class SG_AD_TB_CITA_MED
        Inherits ClsBD

        Public Function Insert_CITA(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_CITA_MED_CITA", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_IDPROGRAMACION _
             , obe.CM_IDNUMHIST _
             , obe.CM_FECHACITA _
             , obe.CM_NUM_ORDEN _
             , obe.CM_HORA_PROG _
             , obe.CM_USUARIO _
             , obe.CM_PC _
             , obe.CM_IDEMPRESA _
             , obe.CM_IDCLIENTE _
             , obe.CM_IDMEDICODERI _
             )
            Return N
        End Function

        Public Function Update_CITA(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_CITA_MED_CITA", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_ID _
             , obe.CM_IDPROGRAMACION _
             , obe.CM_IDNUMHIST _
             , obe.CM_FECHACITA _
             , obe.CM_NUM_ORDEN _
             , obe.CM_HORA_PROG _
             , obe.CM_IDEMPRESA _
             , obe.CM_IDCLIENTE _
             , obe.CM_IDMEDICODERI _
             )
            Return N
        End Function

        Public Function Delete_CITA(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_CITA_MED_CITA", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_ID _
             )
            Return N
        End Function

        '--------CAmbio de Fecha Atencion
        Public Function Update_Atencion(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal Medico As String, ByVal servicio As Integer, ByVal turno As Integer) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_CITA_MED_Eco", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_ID _
             , obe.CM_FECHACITA _
             , obe.CM_HORA_ATENC _
             , obe.CM_OBSERVACIONES _
             , obe.CM_IDEMPRESA _
             , Medico _
             , servicio _
             , turno)

            Return N
        End Function

        '--------servicios
        Public Function Insert_XSer(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal IDCuenta As Integer) As Integer
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_I_CITA_MED", oIdUsuarioActivo, oIdEstacionActiva _
                 , obe.CM_IDPROGRAMACION _
                 , obe.CM_IDNUMHIST _
                 , obe.CM_FECHACITA _
                 , obe.CM_NUM_ORDEN _
                 , obe.CM_HORA_PROG _
                 , obe.CM_HORA_ATENC _
                 , obe.CM_HORA_ING _
                 , obe.CM_OBSERVACIONES _
                 , obe.CM_EDAD_ATENC _
                 , obe.CM_IDTIPO_ATENC _
                 , obe.CM_IDSEGURO _
                 , obe.CM_USUARIO _
                 , obe.CM_PC _
                 , obe.CM_IDEMPRESA _
                 , obe.CM_IDCLIENTE _
                 , obe.CM_IDMEDICODERI _
                , obe.CM_Anamnesis _
                 )

                If N >= 0 Then
                    obeC.CC_IDCITA = N
                    If IDCuenta = 0 Then
                        IDCuenta = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_I2_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
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
                        )
                    End If
                    obeT.TCD_IDCAB = IDCuenta
                    obeT.TCD_IDCITA = obeC.CC_IDCITA

                    N = SqlHelper.ExecuteScalar(TRvar, "TMP_SG_AD_SP_I2_CUENTA_DET", oIdUsuarioActivo, oIdEstacionActiva _
                          , obeT.TCD_IDCAB _
                           , obeT.TCD_IDARTICULO _
                           , obeT.TCD_CANT _
                           , obeT.TCD_TOTAL _
                           , obeT.TCD_PRECIO _
                           , obeT.TCD_DESCUENTO _
                           , obeT.TCD_SUB_TOTAL _
                           , obeT.TCD_IGV _
                           , obeT.TCD_IDempresa _
                           , obeT.TCD_IDCITA, 0 _
                           , obeT.TCD_SINPAGO _
                           , obeT.TCD_DSCTO_OTRO _
                           , obeT.TCD_SEG_CUBRE _
                           , obeT.TCD_DEDUCIBLE _
                           , 0)

                End If

                TRvar.Commit()
                TRvar.Dispose()
            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try
            Return N
        End Function

        Public Function Update_XSer(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal IDCuenta As Integer, ByVal Opcion As Integer, ByVal articulo As Integer) As Integer

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_U2_CITA_MED", oIdUsuarioActivo, oIdEstacionActiva _
                 , obe.CM_ID _
                 , obe.CM_IDPROGRAMACION _
                 , obe.CM_IDNUMHIST _
                 , obe.CM_HORA_ATENC _
                 , obe.CM_HORA_ING _
                 , obe.CM_HORA_SAL _
                 , obe.CM_OBSERVACIONES _
                 , obe.CM_EDAD_ATENC _
                 , obe.CM_IDTIPO_ATENC _
                 , obe.CM_IDSEGURO _
                 , obe.CM_IDEMPRESA _
                 , obe.CM_IDCLIENTE _
                 , obe.CM_IDMEDICODERI _
                 )

                obeC.CC_IDCITA = obe.CM_ID

                If N >= 0 Then
                    If IDCuenta = 0 Then
                        IDCuenta = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_I2_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
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
                        )
                    End If
                    obeT.TCD_IDCAB = IDCuenta
                    obeT.TCD_IDCITA = obeC.CC_IDCITA

                    N = SqlHelper.ExecuteScalar(TRvar, "TMP_SG_AD_SP_I2_CUENTA_DET", oIdUsuarioActivo, oIdEstacionActiva _
                        , obeT.TCD_IDCAB _
                         , obeT.TCD_IDARTICULO _
                         , obeT.TCD_CANT _
                         , obeT.TCD_TOTAL _
                         , obeT.TCD_PRECIO _
                         , obeT.TCD_DESCUENTO _
                         , obeT.TCD_SUB_TOTAL _
                         , obeT.TCD_IGV _
                         , obeT.TCD_IDempresa _
                         , obeT.TCD_IDCITA, Opcion _
                         , obeT.TCD_SINPAGO _
                         , obeT.TCD_DSCTO_OTRO _
                         , obeT.TCD_SEG_CUBRE _
                         , obeT.TCD_DEDUCIBLE _
                         , articulo)

                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try


            Return N

        End Function

        ' ----- citas 

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal TipoCuenta As Integer) As Integer
            'If Cn.State = ConnectionState.Open Then Cn.Close()
            'If Cn.State = ConnectionState.Closed Then Cn.Open()

            'Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            'Try
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_CITA_MED", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_IDPROGRAMACION _
             , obe.CM_IDNUMHIST _
             , obe.CM_FECHACITA _
             , obe.CM_NUM_ORDEN _
             , obe.CM_HORA_PROG _
             , obe.CM_HORA_ATENC _
             , obe.CM_HORA_ING _
             , obe.CM_OBSERVACIONES _
             , obe.CM_EDAD_ATENC _
             , obe.CM_IDTIPO_ATENC _
             , obe.CM_IDSEGURO _
             , obe.CM_USUARIO _
             , obe.CM_PC _
             , obe.CM_IDEMPRESA _
             , obe.CM_IDCLIENTE _
             , obe.CM_IDMEDICODERI _
             , obe.CM_Anamnesis _
             )

            If N >= 0 Then
                obeC.CC_IDCITA = N

                If TipoCuenta = 0 Then
                    N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
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
                    N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_CUENTA_CAB", oIdUsuarioActivo, oIdEstacionActiva _
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
                End If
            End If

            '    TRvar.Commit()
            '    TRvar.Dispose()
            'Catch ex As Exception
            '    N = -1
            '    TRvar.Rollback()
            '    Throw ex
            'End Try
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal TipoCuenta As Integer) As Integer

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_U_CITA_MED", oIdUsuarioActivo, oIdEstacionActiva _
                 , obe.CM_ID _
                 , obe.CM_IDPROGRAMACION _
                 , obe.CM_IDNUMHIST _
                 , obe.CM_HORA_ATENC _
                 , obe.CM_HORA_ING _
                 , obe.CM_OBSERVACIONES _
                 , obe.CM_EDAD_ATENC _
                 , obe.CM_IDTIPO_ATENC _
                 , obe.CM_IDSEGURO _
                 , obe.CM_IDEMPRESA _
                 , obe.CM_IDCLIENTE _
                 , obe.CM_IDMEDICODERI _
                 , obe.CM_Anamnesis _
                 )

                obeC.CC_IDCITA = obe.CM_ID
                If N >= 0 Then
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
                    End If
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try


            Return N

        End Function

        Public Sub SEL01(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_CITA_MED)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S1_CITA_MED", Entidad.CM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CM_HORA_ATENC = drr("CM_HORA_ATENC").ToString
                    .CM_HORA_ING = drr("CM_HORA_ING").ToString
                    .CM_HORA_SAL = drr("CM_HORA_SAL").ToString
                    .CM_OBSERVACIONES = drr("CM_OBSERVACIONES").ToString
                    .CM_EDAD_ATENC = drr("CM_EDAD_ATENC")
                    .CM_IDTIPO_ATENC = drr("CM_IDTIPO_ATENC").ToString
                    .CM_IDSEGURO = drr("CM_IDSEGURO")
                    .CM_IDMEDICODERI = drr("CM_IDMEDICODERI")
                    .CM_Anamnesis = drr("CM_Anamnesis")
                End With
            End If

            drr.Close()

        End Sub

        Public Function Update_XEmer(ByVal obe As BE.AdmisionBE.SG_AD_TB_CITA_MED, ByVal obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal TipoCuenta As Integer) As Integer

            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Dim N As Integer = -1
            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_U_CITA_MED_EMER", oIdUsuarioActivo, oIdEstacionActiva _
                 , obe.CM_ID _
                 , obe.CM_IDPROGRAMACION _
                 , obe.CM_IDNUMHIST _
                 , obe.CM_OBSERVACIONES _
                 , obe.CM_EDAD_ATENC _
                 , obe.CM_IDTIPO_ATENC _
                 , obe.CM_IDSEGURO _
                 , obe.CM_IDEMPRESA _
                 , obe.CM_IDCLIENTE _
                 , obe.CM_IDMEDICODERI _
                 )

                obeC.CC_IDCITA = obe.CM_ID
                If N >= 0 Then
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
                    End If
                End If

                TRvar.Commit()
                TRvar.Dispose()

            Catch ex As Exception
                N = -1
                TRvar.Rollback()
                Throw ex
            End Try


            Return N

        End Function

    End Class

    Public Class SG_AD_TB_ORIGEN_ATENC
        Inherits ClsBD

        Public Function getOrigen() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_ORIGEN_ATENC_01").Tables(0)
        End Function

        Public Function getOrigen2() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_ORIGEN_ATENC_02").Tables(0)
        End Function


    End Class

    Public Class SG_AD_TB_COBERTURA
        Inherits ClsBD

        Public Function getOrigen() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S1_COBERTURA").Tables(0)
        End Function

       
        Public Sub SEL02(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_COBERTURA)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S2_COBERTURA", Entidad.CB_SITEDS)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .CB_ID = drr("CB_ID").ToString
                    .CB_DESCRIPCION = drr("CB_DESCRIPCION").ToString
                    .CB_IDTIPO_ORIGEN = drr("CB_IDTIPO_ORIGEN")
                End With
            End If

            drr.Close()

        End Sub

        'Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_COBERTURA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_COBERTURA", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.CB_IDTIPO_ORIGEN _
        '     , obe.CB_DESCRIPCION _
        '     , obe.CB_IDSUNASA _
        '     , obe.CB_SITEDS _
        '     )
        '    Return N
        'End Function

        'Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_COBERTURA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_COBERTURA", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.CB_ID _
        '     , obe.CB_IDTIPO_ORIGEN _
        '     , obe.CB_DESCRIPCION _
        '     , obe.CB_IDSUNASA _
        '     , obe.CB_SITEDS _
        '     )
        '    Return N
        'End Function

        'Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_COBERTURA, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
        '    Dim N As Integer = -1
        '    N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_COBERTURA", oIdUsuarioActivo, oIdEstacionActiva _
        '     , obe.CB_ID _
        '     )
        '    Return N
        'End Function

        'Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_COBERTURA, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S1_COBERTURA", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@CB_ID", System.Data.SqlDbType.int).Value = obe.CB_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

        'Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_COBERTURA, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S2_COBERTURA", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@CB_ID", System.Data.SqlDbType.int).Value = obe.CB_ID
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub


    End Class

    Public Class SG_AD_TB_MEDICO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.ME_APE_PAT _
             , obe.ME_APE_MAT _
             , obe.ME_NOMBRES _
             , obe.ME_NUM_COLEG _
             , obe.ME_ESTADO _
             , obe.ME_ESPECIALIDAD _
             , obe.ME_RUC _
             , obe.ME_DIRECCION _
             , obe.ME_TELEFONOFIJO _
             , obe.ME_TELEFONOCELULAR _
             , obe.ME_INTERVALO _
             , IIf(obe.ME_FECNAC = Now.Date, DBNull.Value, obe.ME_FECNAC) _
             , obe.ME_CORREO _
             , obe.ME_USUARIO _
             , obe.ME_PC _
             , obe.ME_IDEMPRESA _
             , obe.ME_TDOC _
             , obe.ME_NDOC _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.ME_CODIGO _
             , obe.ME_APE_PAT _
             , obe.ME_APE_MAT _
             , obe.ME_NOMBRES _
             , obe.ME_NUM_COLEG _
             , obe.ME_ESTADO _
             , obe.ME_ESPECIALIDAD _
             , obe.ME_RUC _
             , obe.ME_DIRECCION _
             , obe.ME_TELEFONOFIJO _
             , obe.ME_TELEFONOCELULAR _
             , obe.ME_INTERVALO _
             , IIf(obe.ME_FECNAC = Now.Date, DBNull.Value, obe.ME_FECNAC) _
             , obe.ME_CORREO _
             , obe.ME_IDEMPRESA _
             , obe.ME_TDOC _
             , obe.ME_NDOC _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.ME_CODIGO _
             , obe.ME_IDEMPRESA _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_MEDICO, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_MEDICO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ME_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.ME_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_MEDICO, ByVal fechas As Date, ByRef oDt As DataTable, ByVal Servicio As Integer)
            Dim cmd As New SqlCommand("SG_AD_SP_S2_MEDICO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ME_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.ME_IDEMPRESA
            cmd.Parameters.Add("@ME_FECHA", System.Data.SqlDbType.DateTime).Value = fechas
            cmd.Parameters.Add("@ME_IDServicio", System.Data.SqlDbType.Int).Value = Servicio
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL03(ByVal obe As BE.AdmisionBE.SG_AD_TB_MEDICO, ByVal fechas As Date, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S3_MEDICO", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ME_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.ME_IDEMPRESA
            cmd.Parameters.Add("@ME_FECHA", System.Data.SqlDbType.DateTime).Value = fechas
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_MEDICO, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S2_MEDICO", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@ME_CODIGO", System.Data.SqlDbType.VarChar).Value = obe.ME_CODIGO
        '    cmd.Parameters.Add("@ME_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.ME_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

        Public Function get_Medicos(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_MED", empresa_).Tables(0)
        End Function

        Public Function get_Medicos_cmb(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_MED_CMB", empresa_).Tables(0)
        End Function

        Public Function get_Medicos_x_Id(ByVal Entidad As BE.AdmisionBE.SG_AD_TB_MEDICO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_MED_BYID", Entidad.ME_CODIGO, Entidad.ME_IDEMPRESA).Tables(0)
        End Function

    End Class

    Public Class SG_AD_TB_CONSULTORIO_MEDICO

        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_CONSULTORIO_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_DES_CORTA _
             , obe.CM_DESCRIPCION _
             , obe.CM_USUARIO _
             , obe.CM_PC _
             , obe.CM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_CONSULTORIO_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_ID _
             , obe.CM_DES_CORTA _
             , obe.CM_DESCRIPCION _
             , obe.CM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_CONSULTORIO_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.CM_ID _
             , obe.CM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function get_Consultorios(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CONSUL_MED", empresa_).Tables(0)
        End Function

        'Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S1_CONSULTORIO_MEDICO", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@CM_ID", System.Data.SqlDbType.Int).Value = obe.CM_ID
        '    cmd.Parameters.Add("@CM_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.CM_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

        'Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S2_CONSULTORIO_MEDICO", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@CM_ID", System.Data.SqlDbType.Int).Value = obe.CM_ID
        '    cmd.Parameters.Add("@CM_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.CM_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_AD_TB_SERVICIO_MEDICO
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_SERVICIO_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_SERVICIO_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.SM_DESCRIPCION _
             , obe.SM_ABREVIATURA _
             , obe.SM_USUARIO _
             , obe.SM_TERMINAL _
             , obe.SM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_SERVICIO_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_SERVICIO_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.SM_ID _
             , obe.SM_DESCRIPCION _
             , obe.SM_ABREVIATURA _
             , obe.SM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_SERVICIO_MEDICO, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_SERVICIO_MEDICO", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.SM_ID _
             , obe.SM_IDEMPRESA _
             )
            Return N
        End Function

        Public Function get_Servicios(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_SERV_MED", empresa_).Tables(0)
        End Function

        Public Function get_Servicios_X_Medico(ByVal empresa_ As Integer, ByVal usuario_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_SERV_MED_1", empresa_, usuario_).Tables(0)
        End Function

        Public Function get_Servicios_X_Medico2(ByVal empresa_ As Integer, ByVal fechas As Date) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_SERV_MED_2", empresa_, fechas).Tables(0)
        End Function

    End Class
    Public Class SG_AD_TB_ESPECIALIDADES
        Inherits ClsBD
        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_ESPECIALIDADES, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_ESPECIALIDADES", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.ES_DESCRIPCION _
             , obe.ES_ABREVIATURA _
             , obe.ES_IDEMPRESA _
             , obe.ES_IDCC
             )
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_ESPECIALIDADES, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_ESPECIALIDADES", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.ES_ID _
             , obe.ES_DESCRIPCION _
             , obe.ES_ABREVIATURA _
             , obe.ES_IDEMPRESA _
             , obe.ES_IDCC
             )
            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_ESPECIALIDADES, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_ESPECIALIDADES", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.ES_ID _
             , obe.ES_IDEMPRESA _
             )
            Return N
        End Function

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_ESPECIALIDADES, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S1_ESPECIALIDADES", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ES_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.ES_IDEMPRESA
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_ESPECIALIDADES, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S2_ESPECIALIDADES", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ES_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.ES_IDEMPRESA
            cmd.Parameters.Add("@ES_ID", System.Data.SqlDbType.Int).Value = obe.ES_ID
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        'Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_ESPECIALIDADES, ByRef oDt As DataTable)
        '    Dim cmd As New SqlCommand("SG_AD_SP_S2_ESPECIALIDADES", Cn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@ES_ID", System.Data.SqlDbType.Int).Value = obe.ES_ID
        '    cmd.Parameters.Add("@ES_IDEMPRESA", System.Data.SqlDbType.Int).Value = obe.ES_IDEMPRESA
        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub

    End Class

    Public Class SG_AD_TB_PROGRAMA_CITA
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.AdmisionBE.SG_AD_TB_PROGRAMA_CITA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_I_PROG_CITAS", .PR_MEDICO, .PR_IDCONSULTORIO, .PR_IDSERVICIO, .PR_TURNO_INI, .PR_TURNO_FIN, .PR_FECHA, .PR_ESTADO, .PR_CUPOS, .PR_PC, .PR_USUARIO, .PR_FECREG, .PR_IDEMPRESA, .PR_DIAS, .PR_Tipo, .PR_Turno)
            End With
        End Sub

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_PROGRAMA_CITA) As Integer
            Dim N As Integer = -1
            With obe
                N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_PROG_CITAS", .PR_ID, .PR_MEDICO, .PR_IDCONSULTORIO, .PR_IDSERVICIO, .PR_TURNO_INI, .PR_TURNO_FIN, .PR_FECHA, .PR_ESTADO, .PR_CUPOS, .PR_IDEMPRESA, .PR_DIAS, .PR_Tipo, .PR_Turno)
            End With
            Return N
        End Function

        Public Sub Delete(ByVal entidad As BE.AdmisionBE.SG_AD_TB_PROGRAMA_CITA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_D_PROG_CITAS", .PR_ID, .PR_IDEMPRESA)
            End With
        End Sub

        Public Function get_Programaciones_01(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PROG_CITA", empresa_).Tables(0)
        End Function

        Public Function get_Programaciones_02(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PROG_CITA_Emer", empresa_).Tables(0)
        End Function

        Public Function get_Programacion_x_Fecha(ByVal fecha_ As String, ByVal servicio_ As Integer, ByVal medico_ As String, ByVal empresa_ As Integer, ByVal Turno As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PROG_X_ITEM", fecha_, servicio_, medico_, empresa_, Turno).Tables(0)
        End Function

        Public Function get_Programacion_x_Fecha_Ecograf(ByVal fecha_ As String, ByVal servicio_ As Integer, ByVal medico_ As String, ByVal empresa_ As Integer, ByVal Turno As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PROG_X_ITEM_Ecogra", fecha_, servicio_, medico_, empresa_, Turno).Tables(0)
        End Function

        Public Function get_Programacion_citas_Eco(ByVal fecha_ As String, ByVal servicio_ As Integer, ByVal empresa_ As Integer, ByVal Turno As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PROG_CITAS_ECO", fecha_, servicio_, Turno, empresa_).Tables(0)
        End Function

        Public Function get_Programacion_x_Fecha_Emerg(ByVal fecha_ As String, ByVal medico_ As String, ByVal empresa_ As Integer, ByVal Turno As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PROG_X_ITEM_Emerg", fecha_, medico_, empresa_, Turno).Tables(0)
        End Function

        Public Function get_Programacion_x_Cuenta(ByVal fecha_ As String, ByVal servicio_ As Integer, ByVal medico_ As String, ByVal empresa_ As Integer, ByVal Turno As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PROG_X_CUENTA", fecha_, servicio_, medico_, empresa_, Turno).Tables(0)
        End Function

        Public Function get_Citas_x_FechayDoc(ByVal fecha_ As String, ByVal medico_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_Citas_FechaDoc", fecha_, medico_).Tables(0)
        End Function

        Public Sub get_Programacion_x_Orden(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_PROGRAMA_CITA, ByVal fecha_ As String, ByVal servicio_ As Integer, ByVal medico_ As String, ByVal empresa_ As Integer, ByVal numeroOrden As Integer, ByVal Turno As Integer)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S_PROG_X_ORDEN", fecha_, servicio_, medico_, empresa_, numeroOrden, Turno)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    .PR_TURNO_INI = drr("Hora").ToString
                    .PR_ID = drr("PR_ID")
                End With
            End If

            drr.Close()

        End Sub
    End Class

    Public Class SG_AD_TB_SEXO
        Inherits ClsBD


        Public Function getSexos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_SEXO").Tables(0)
        End Function
    End Class

    Public Class SG_AD_TB_TIP_DOC_PER
        Inherits ClsBD

        Public Function getTiposDocs(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_TIP_DOC_PER", empresa_).Tables(0)
        End Function

        Public Function getTiposDocs_x_Id(ByVal id_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_TIPDOC_PER_BYID", id_, empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_AD_TB_ESTADO_CIVIL
        Inherits ClsBD

        Public Function getEstados(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_ESTADO_CIVIL", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_AD_TB_NACIONALIDAD
        Inherits ClsBD
        Public Sub Insert(ByVal entidad As BE.AdmisionBE.SG_AD_TB_NACIONALIDAD)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_I_NACIO", .NA_ID, .NA_DESCRIPCION, .NA_IDEMPRESA)
            End With
        End Sub
        Public Sub Update(ByVal entidad As BE.AdmisionBE.SG_AD_TB_NACIONALIDAD)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_U_NACIO", .NA_ID, .NA_DESCRIPCION, .NA_IDEMPRESA)
            End With
        End Sub
        Public Sub Delete(ByVal entidad As BE.AdmisionBE.SG_AD_TB_NACIONALIDAD)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_D_NACIO", .NA_ID, .NA_IDEMPRESA)
            End With
        End Sub
        Public Function getNacionalidades(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_NACIONALIDAD", empresa_).Tables(0)
        End Function
        Public Function get_vali(ByVal id As String, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_NACI_BYID", id, empresa).Tables(0)
        End Function
    End Class

    Public Class SG_AD_TB_UBIGEO
        Inherits ClsBD
        Public Function getProvincias() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_UBI_PROVINCIA").Tables(0)
        End Function
        Public Function getUbigeo() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_UBI_UBIGEO").Tables(0)
        End Function
    End Class

    Public Class SG_AD_TB_HISTO_CLINI

        Inherits ClsBD

        Public Function getHistorias_Base_x_Id(ByVal num_histo_cli_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_HISTCLIN_BASE_BYID", num_histo_cli_, empresa_).Tables(0)
        End Function

        Public Function getHistorias_Hoja_Afiliacion(ByVal num_histo_cli_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_HOJA_AFI", num_histo_cli_).Tables(0)
        End Function

        Public Function get_Historias_Ayuda(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_LIS_AYU_HISCLI", empresa_).Tables(0)
        End Function

        Public Function get_Historias_x_HIstoria(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S_HISTO_CLINI_X_His", Entidad.HC_NUM_HIST, Entidad.HC_IDEMPRESA)
        End Function

        Public Sub get_Historias_x_Doc(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S_HISTO_CLINI_X_DOC", Entidad.HC_NDOC, Entidad.HC_IDEMPRESA, Entidad.HC_TDOC)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True
                    If drr("CL_ID").ToString = "" Then
                        'Dim N As Integer = -1
                        'N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_CLIENTE", oIdUsuarioActivo, oIdEstacionActiva _
                        ' , Entidad.HC_NUM_HIST _
                        ' )
                        ''Return N
                    End If

                    .HC_NUM_HIST = drr("HC_NUM_HIST")
                    .HC_IDCLIENTE = drr("CL_ID")
                    .HC_NOMBRE1 = drr("CL_NOMBRE").ToString
                    .HC_TDOC = drr("HC_TDOC")  'New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = drr("CL_TDOC")}
                    .HC_NDOC = drr("HC_NDOC").ToString
                    .HC_FNAC = drr("HC_FNAC")
                    .HC_DIR = drr("HC_DIR").ToString
                    .HC_TITULAR = drr("HC_TITULAR").ToString
                End With
            End If

            drr.Close()

        End Sub

        Public Sub get_Historias_x_DocCOmpleto(ByRef Entidad As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByRef GS As BE.AdmisionBE.SG_AD_TB_GrupoSanguineo _
                                               , ByRef MED As BE.AdmisionBE.SG_AD_TB_MEDICO, ByRef REC As BE.AdmisionBE.SG_AD_TB_RECOMENDADO _
                                               , ByRef EC As BE.AdmisionBE.SG_AD_TB_ESTADO_CIVIL, ByRef NAC As BE.AdmisionBE.SG_AD_TB_NACIONALIDAD)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S_HISTO_CLINI_X_DOC2", Entidad.HC_IDEMPRESA, Entidad.HC_NUM_HIST)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .HasRow = True

                    .HC_NUM_HIST = drr("HC_NUM_HIST")
                    .HC_IDCLIENTE = drr("CL_ID")
                    .HC_NOMBRE1 = drr("CL_NOMBRE").ToString
                    .HC_TDOC = drr("HC_TDOC")  'New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = drr("CL_TDOC")}
                    .HC_NDOC = drr("HC_NDOC").ToString
                    .HC_FNAC = drr("HC_FNAC")
                    .HC_DIR = drr("HC_DIR").ToString
                    .HC_SEXO = drr("HC_SEXO").ToString
                    .HC_APE_PAT = drr("HC_APE_PAT").ToString
                    .HC_APE_MAT = drr("HC_APE_MAT").ToString
                    .HC_NOMBRE1 = drr("HC_NOMBRE1").ToString
                    .HC_OCUPACION = drr("HC_OCUPACION").ToString
                    .HC_TITULAR = drr("HC_TITULAR").ToString
                    .HC_ALERGIAS = drr("HC_ALERGIAS").ToString

                    .HC_FNAC_TITU = drr("HC_FNAC_TITU").ToString
                    .HC_DetRecom = drr("HC_DetRecom").ToString

                    EC.EC_DESCRIPCION = drr("HC_EST_CIVIL").ToString
                    NAC.NA_DESCRIPCION = drr("HC_IDNACIONALIDAD").ToString
                    GS.GS_NOMBRE = drr("HC_IDGRUPO_S").ToString
                    MED.ME_NOMBRES = drr("HC_IDMEDICO").ToString
                    REC.RE_NOMBRE = drr("HC_IDRECOMENDACION").ToString

                    .HC_UBIGEO = drr("UB_DESCRIPCION").ToString
                    .HC_IDCONDICION = drr("HC_IDCONDICION").ToString

                End With
            End If

            drr.Close()

        End Sub
        '--------------

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_comunica As List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_I_HISTO_CLINI", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.HC_NOMBRE1 _
             , obe.HC_NOMBRE2 _
             , obe.HC_APE_PAT _
             , obe.HC_APE_MAT _
             , obe.HC_APE_CASADA _
             , obe.HC_TDOC _
             , obe.HC_NDOC _
             , obe.HC_FNAC _
             , obe.HC_FING _
             , obe.HC_SEXO _
             , obe.HC_EST_CIVIL _
             , obe.HC_DIR _
             , obe.HC_OCUPACION _
             , obe.HC_IDNACIONALIDAD _
             , obe.HC_USUARIO _
             , obe.HC_TERMINAL _
             , obe.HC_IDEMPRESA _
             , obe.HC_UBIGEO _
             , obe.HC_IDGRUPO_S _
             , obe.HC_IDCONDICION _
             , obe.HC_IDRECOMENDACION _
             , obe.HC_IDMEDICO _
             , obe.HC_FNAC_TITU _
             , obe.HC_TITULAR _
             , obe.HC_UBICACION _
             , obe.HC_ALERGIAS _
             , obe.HC_TIPO_H_C _
             , obe.HC_EDAD_REG _
             , obe.HC_DetRecom _
             )

            If N > 0 Then
                If Not ls_comunica Is Nothing Then
                    If ls_comunica.Count > 0 Then
                        Dim x As New BL.FacturacionBL.SG_FA_TB_CLIENTE_COMUNI

                        'Borramos todo del cliente
                        ' x.Delete_all_xId(ls_comunica(0))

                        'Grabamos los telefonos,movil's, correos,etc
                        For Each item As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI In ls_comunica
                            item.CC_IDCLIENTE = N
                            x.Insert(item)
                        Next

                        x = Nothing
                    End If
                End If
                'si tiene numero de documento lo registramos en contabilidad
                If obe.HC_NDOC.ToString.Length > 0 Then

                    Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
                    Dim cod_doc_conta As Integer = 0
                    Dim documentoBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
                    Dim dt_tmp As DataTable = documentoBL.getTiposDocs_x_Id(obe.HC_TDOC, obe.HC_IDEMPRESA)
                    If dt_tmp.Rows.Count > 0 Then
                        cod_doc_conta = dt_tmp.Rows(0)("TD_COD_CONTA")
                    Else
                        cod_doc_conta = 1
                    End If
                    dt_tmp.Dispose()
                    documentoBL = Nothing

                    anexoBE.AN_IDANEXO = 0
                    anexoBE.AN_DESCRIPCION = obe.HC_APE_PAT & " " & obe.HC_APE_MAT & " " & obe.HC_APE_CASADA & " " & obe.HC_NOMBRE1.ToString & " " & obe.HC_NOMBRE2
                    anexoBE.AN_ES_RELACIONADO = 0
                    anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = obe.HC_IDEMPRESA}
                    anexoBE.AN_NUM_DOC = obe.HC_NDOC
                    anexoBE.AN_PC_FECREG = Date.Now
                    anexoBE.AN_PC_TERMINAL = obe.HC_TERMINAL
                    anexoBE.AN_PC_USUARIO = obe.HC_USUARIO
                    anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Cliente}
                    anexoBE.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = cod_doc_conta}
                    anexoBE.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = BE.ContabilidadBE.TipoEmpresa.Natural}

                    anexoBL.Insert_x_Admision(anexoBE, N)

                    anexoBE = Nothing
                    anexoBL = Nothing

                End If
            End If
            Return N
        End Function

        Public Function Update(ByVal obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String, ByVal ls_comunica As List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_U_HISTO_CLINI", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.HC_NUM_HIST _
             , obe.HC_IDCLIENTE _
             , obe.HC_NOMBRE1 _
             , obe.HC_NOMBRE2 _
             , obe.HC_APE_PAT _
             , obe.HC_APE_MAT _
             , obe.HC_APE_CASADA _
             , obe.HC_TDOC _
             , obe.HC_NDOC _
             , obe.HC_FNAC _
             , obe.HC_SEXO _
             , obe.HC_EST_CIVIL _
             , obe.HC_DIR _
             , obe.HC_OCUPACION _
             , obe.HC_IDNACIONALIDAD _
             , obe.HC_IDEMPRESA _
             , obe.HC_UBIGEO _
             , obe.HC_IDGRUPO_S _
             , obe.HC_IDCONDICION _
             , obe.HC_IDRECOMENDACION _
             , obe.HC_IDMEDICO _
             , obe.HC_FNAC_TITU _
             , obe.HC_TITULAR _
             , obe.HC_UBICACION _
             , obe.HC_ALERGIAS _
             , obe.HC_TIPO_H_C _
             , obe.HC_EDAD_REG _
              , obe.HC_DetRecom _
             )

            If Not ls_comunica Is Nothing Then
                If ls_comunica.Count > 0 Then
                    Dim x As New BL.FacturacionBL.SG_FA_TB_CLIENTE_COMUNI

                    'Borramos todo del cliente
                    x.Delete_all_xId(ls_comunica(0))

                    'Grabamos los telefonos,movil's, correos,etc
                    For Each item As BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI In ls_comunica
                        item.CC_IDCLIENTE = obe.HC_IDCLIENTE
                        x.Insert(item)
                    Next

                    x = Nothing
                End If
            End If

            Return N
        End Function

        Public Function Delete(ByVal obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByVal oIdUsuarioActivo As String, ByVal oIdEstacionActiva As String) As Integer
            Dim N As Integer = -1
            N = SqlHelper.ExecuteScalar(Cn, "SG_AD_SP_D_HISTO_CLINI", oIdUsuarioActivo, oIdEstacionActiva _
             , obe.HC_NUM_HIST _
             )
            Return N
        End Function

        'Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByVal COLUMNA As String, ByVal VALOR As String, ByRef oDt As DataTable)
        '    Dim Scrip As String
        '    Scrip = "SELECT TOP 500 (case when HC_NUM_HIST is null then '' else HC_NUM_HIST end)[HC_NUM_HIST]" & _
        '                ",CL_id,HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[CL_NOMBRE]" & _
        '                ",(case when HC_APE_PAT is null then '' else HC_APE_PAT end)[HC_APE_PAT]" & _
        '                ",(case when HC_APE_MAT is null then '' else HC_APE_MAT end)[HC_APE_MAT]" & _
        '                ",(case when HC_APE_CASADA is null then '' else HC_APE_CASADA end)[HC_APE_CASADA]" & _
        '                ",(case when HC_NOMBRE1 is null then '' else HC_NOMBRE1 end)[HC_NOMBRE1]" & _
        '                ",(case when HC_NOMBRE2 is null then '' else HC_NOMBRE2 end)[HC_NOMBRE2]" & _
        '                ",(CASE WHEN HC_TDOC IS NULL THEN CL_TDOC ELSE HC_TDOC END)[HC_TDOC],(CASE WHEN HC_NDOC IS NULL THEN CL_NDOC ELSE HC_NDOC END)[HC_NDOC]" & _
        '                ",(CASE WHEN HC_FNAC IS NULL THEN getdate() ELSE HC_FNAC END)[HC_FNAC]" & _
        '                ",(CASE WHEN HC_FING IS NULL THEN getdate() ELSE HC_FING END)[HC_FING]" & _
        '                ",(case when HC_SEXO is null then 'F' else HC_SEXO end)[HC_SEXO]" & _
        '                ",(case when HC_EST_CIVIL is null then 0 else HC_EST_CIVIL end)[HC_EST_CIVIL]" & _
        '                ",(CASE WHEN HC_DIR IS NULL THEN CL_DIRECCION ELSE HC_DIR END)[HC_DIR]" & _
        '                ",(case when HC_OCUPACION is null then '' else HC_OCUPACION end)[HC_OCUPACION]" & _
        '                ",(case when HC_IDNACIONALIDAD is null then '' else HC_IDNACIONALIDAD end)[HC_IDNACIONALIDAD]" & _
        '                ",CL_UBIGEO,HC_IDGRUPO_S,HC_IDCONDICION,HC_IDRECOMENDACION,HC_IDMEDICO,HC_FNAC_TITU,HC_TITULAR,HC_UBICACION,HC_ALERGIAS,HC_TIPO_H_C,HC_EDAD_REG " & _
        '            "FROM SG_AD_TB_HISTO_CLINI " & _
        '                "left join SG_FA_TB_CLIENTE on CL_id=HC_IDCLIENTE " & _
        '                "where HC_IDEMPRESA=" & obe.HC_IDEMPRESA & " and " & COLUMNA & " like '%" & VALOR & "%' order by CL_NOMBRE"
        '    Dim cmd As New SqlCommand(Scrip, Cn)
        '    cmd.CommandType = CommandType.Text

        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(oDt)
        'End Sub
        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByVal apepat As String, ByVal apemat As String, ByVal apecas As String, ByVal nombre As String, ByVal historia As String, ByVal doc As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Scrip = "SELECT TOP 500 (case when HC_NUM_HIST is null then '' else HC_NUM_HIST end)[HC_NUM_HIST]" & _
                        ",CL_id,HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[CL_NOMBRE]" & _
                        ",(case when HC_APE_PAT is null then '' else HC_APE_PAT end)[HC_APE_PAT]" & _
                        ",(case when HC_APE_MAT is null then '' else HC_APE_MAT end)[HC_APE_MAT]" & _
                        ",(case when HC_APE_CASADA is null then '' else HC_APE_CASADA end)[HC_APE_CASADA]" & _
                        ",(case when HC_NOMBRE1 is null then '' else HC_NOMBRE1 end)[HC_NOMBRE1]" & _
                        ",(case when HC_NOMBRE2 is null then '' else HC_NOMBRE2 end)[HC_NOMBRE2]" & _
                        ",(CASE WHEN HC_TDOC IS NULL THEN CL_TDOC ELSE HC_TDOC END)[HC_TDOC],(CASE WHEN HC_NDOC IS NULL THEN CL_NDOC ELSE HC_NDOC END)[HC_NDOC]" & _
                        ",(CASE WHEN HC_FNAC IS NULL THEN getdate() ELSE HC_FNAC END)[HC_FNAC]" & _
                        ",(CASE WHEN HC_FING IS NULL THEN getdate() ELSE HC_FING END)[HC_FING]" & _
                        ",(case when HC_SEXO is null then 'F' else HC_SEXO end)[HC_SEXO]" & _
                        ",(case when HC_EST_CIVIL is null then 0 else HC_EST_CIVIL end)[HC_EST_CIVIL]" & _
                        ",(CASE WHEN HC_DIR IS NULL THEN CL_DIRECCION ELSE HC_DIR END)[HC_DIR]" & _
                        ",(case when HC_OCUPACION is null then '' else HC_OCUPACION end)[HC_OCUPACION]" & _
                        ",(case when HC_IDNACIONALIDAD is null then '' else HC_IDNACIONALIDAD end)[HC_IDNACIONALIDAD]" & _
                        ",CL_UBIGEO,HC_IDGRUPO_S,HC_IDCONDICION,HC_IDRECOMENDACION,HC_IDMEDICO,HC_FNAC_TITU,HC_TITULAR,HC_UBICACION,HC_ALERGIAS,HC_TIPO_H_C,HC_EDAD_REG,HC_DetRecom " & _
                    "FROM SG_AD_TB_HISTO_CLINI " & _
                        "left join SG_FA_TB_CLIENTE on CL_id=HC_IDCLIENTE " & _
                        "where HC_IDEMPRESA=" & obe.HC_IDEMPRESA & "  " & apepat + apemat + apecas + nombre + historia + doc & " order by CL_NOMBRE"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub
        Public Sub SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByVal COLUMNA As String, ByVal VALOR As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Scrip = "SELECT HC_NUM_HIST,CL_id " & _
                        ",(case when HC_APE_PAT is null then '' else HC_APE_PAT end)[HC_APE_PAT]" & _
                        ",(case when HC_APE_MAT is null then '' else HC_APE_MAT end)[HC_APE_MAT]" & _
                        ",(case when HC_APE_CASADA is null then '' else HC_APE_CASADA end)[HC_APE_CASADA]" & _
                        ",(case when HC_NOMBRE1 is null then '' else HC_NOMBRE1 end)[HC_NOMBRE1]" & _
                        ",(case when HC_NOMBRE2 is null then '' else HC_NOMBRE2 end)[HC_NOMBRE2]" & _
                        ",HC_TDOC" & _
                        ",HC_NDOC" & _
                        ",(CASE WHEN HC_FNAC IS NULL THEN getdate() ELSE HC_FNAC END)[HC_FNAC]" & _
                        ",(CASE WHEN HC_FING IS NULL THEN getdate() ELSE HC_FING END)[HC_FING]" & _
                        ",(case when HC_SEXO is null then 'F' else HC_SEXO end)[HC_SEXO]" & _
                        ",(case when HC_EST_CIVIL is null then 0 else HC_EST_CIVIL end)[HC_EST_CIVIL]" & _
                        ",HC_DIR" & _
                        ",(case when HC_OCUPACION is null then '' else HC_OCUPACION end)[HC_OCUPACION]" & _
                        ",(case when HC_IDNACIONALIDAD is null then '' else HC_IDNACIONALIDAD end)[HC_IDNACIONALIDAD]" & _
                        ",CL_UBIGEO" & _
                        ",HC_IDGRUPO_S,HC_IDCONDICION,HC_IDRECOMENDACION,HC_IDMEDICO,HC_FNAC_TITU,HC_TITULAR,HC_UBICACION,HC_ALERGIAS" & _
                        ",HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2[CL_NOMBRE]" & _
                    "FROM SG_AD_TB_HISTO_CLINI " & _
                        "left join SG_FA_TB_CLIENTE on CL_id=HC_IDCLIENTE  " & _
                        "where HC_IDEMPRESA=" & obe.HC_IDEMPRESA & " and " & COLUMNA & " like '" & VALOR & "%' order by CL_NOMBRE"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Function SEL03(nombre_ As String, tipo_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CONS03", nombre_, tipo_, empresa_).Tables(0)
        End Function

        Public Function SEL04(nombre_ As String, tipo_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CONS04", nombre_, tipo_, empresa_).Tables(0)
        End Function

        Public Function SEL05(ByVal obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI, ByVal empresa_ As Integer) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S_HISTO_CLINI_1", obe.HC_NDOC, obe.HC_TDOC, obe.HC_NOMBRE1, obe.HC_APE_MAT, obe.HC_APE_PAT, obe.HC_FNAC, obe.HC_SEXO, empresa_)
        End Function

        Public Function SEL06(ByVal dni As String) As SqlDataReader
            Return SqlHelper.ExecuteReader(Cn, "SG_AD_SP_S_DatosReniec", dni)
        End Function

    End Class

    Public Class SG_AD_TB_Reportes

        Inherits ClsBD

        Public Sub SEL01(ByVal FechaD As String, ByVal FechaH As String, ByVal EMpresa As Integer, ByVal paciente As String, ByVal servicio As String, ByVal medico As String, ByVal pacienteSISA As String, ByVal servicioSISA As String, ByVal medicoSISA As String, ByVal pacienteEcoSISA As String, ByVal MEcoSISA As String, ByVal SEcoSISA As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Scrip = "select * from (" & _
                        "select convert(date,CM_FECHACITA)[CM_FECHACITA],CM_NUM_ORDEN,CM_HORA_PROG,RIGHT(REPLICATE('0',10)+CAST(CM_IDNUMHIST AS VARCHAR(10)),10)[CM_IDNUMHIST]" & _
                                ",CASE WHEN CM_IDNUMHIST IS NULL THEN CL_NOMBRE ELSE HC_APE_PAT +' '+HC_APE_MAT +' '+HC_NOMBRE1+' '+HC_NOMBRE2 END[HC_NOMBRE1]" & _
                                ",SM_DESCRIPCION,ME_APE_PAT+' '+ME_APE_MAT+' '+ME_NOMBRES[ME_NOMBRES]" & _
                                ",case when CC_ID IS null then '' when SEG='PARTICULAR' then 'PARTICULAR' else CA_DESCRIPCION end[CM_IDSEGURO]" & _
                                ",CASE WHEN CB_DESCRIPCION IS NULL OR SEG='PARTICULAR' THEN '' ELSE CB_DESCRIPCION END[CM_SIT_DES_COBER]" & _
                                ",case when CM_HORA_ING<>'' then 'Paso Consulta' when CM_HORA_ATENC<>'' then 'Atendido' else 'Citado' end [Estado] 	" & _
                        "from SG_AD_TB_CITA_MED " & _
                                "left join SG_AD_TB_HISTO_CLINI on HC_NUM_HIST=CM_IDNUMHIST " & _
                                "left join SG_FA_TB_CLIENTE on CL_ID=CM_IDCLIENTE " & _
                                "inner join SG_AD_TB_PROGRAMA_CITA on PR_ID=CM_IDPROGRAMACION and CM_IDEMPRESA =PR_IDEMPRESA   " & _
                                "inner join SG_AD_TB_MEDICO on ME_CODIGO =PR_MEDICO and CM_IDEMPRESA =ME_IDEMPRESA  " & _
                                "inner join SG_AD_TB_SERVICIO_MEDICO on SM_ID=PR_IDSERVICIO and CM_IDEMPRESA =SM_IDEMPRESA  " & _
                                "left join (SELECT * FROM( " & _
                                                "select CD_IDCITA,CD_IDCAB,case WHEN CC_IDSEGURO IS null then 'PARTICULAR' when CD_SEG_CUBRE=0 and CD_DEDUCIBLE=0 then 'PARTICULAR' ELSE CC_IDSEGURO END[SEG] from SG_AD_TB_CUENTA_DET " & _
                                                "inner join  SG_AD_TB_CUENTA_CAB on CC_ID =CD_IDCAB WHERE CD_IDCITA IS NOT NULL group by CD_IDCITA,CD_IDCAB,CD_SEG_CUBRE,CD_DEDUCIBLE,CC_IDSEGURO  " & _
                                            ")AS TMP1 GROUP BY  CD_IDCITA,CD_IDCAB,SEG " & _
                                ") as tmp on CD_IDCITA =CM_ID " & _
                                "left join SG_AD_TB_CUENTA_CAB on CC_ID =CD_IDCAB " & _
                                "left join SG_FA_TB_CIA_ASEG on CA_ID=CC_IDSEGURO and CC_IDEMPRESA =CA_IDEMPRESA  " & _
                                "left join SG_AD_TB_COBERTURA on CC_SIT_COD_COBER=CB_ID  " & _
                        "WHERE CM_IDEMPRESA=" & EMpresa & " and convert(date,CM_FECHACITA) between '" & FechaD & "' and '" & FechaH & "' " & paciente + servicio + medico & _
                    "union all " & _
                        "select convert(date,ci_fechacita)[CM_FECHACITA],ci_orden,ci_indicatencion,ci_numhist" & _
                                  ",hc_apepat+' '+hc_apemat+' '+hc_apecas+' '+hc_nombre[paciente],se_descripcion,me_nombres" & _
                                  ",case hc_TipoAsegurado when '01' then 'PARTICULAR' else ae_desc end [seguro]" & _
                                  ",''[Cobertura]" & _
                                  ",case when ci_horing<>'     ' and ci_horing IS not null then 'Paso Consulta' when ci_horatencion<>'' then 'Atendido' else 'Citado' end " & _
                          "from dbclinica..Citas " & _
                                  "inner join dbclinica..Historias on ci_numhist=hc_numhis " & _
                                  "left join dbclinica..Aseguradora on hc_aseguradora=ae_codi " & _
                                  "inner join dbclinica..Servicios on se_codigo =ci_servicio " & _
                                  "left join dbclinica..Medicos on me_codigo =ci_medico " & _
                          "where ci_fechacita between '" & FechaD & "' and '" & FechaH & "' " & pacienteSISA + servicioSISA + medicoSISA & _
                    "union all " & _
                          "select convert(date,ce_fecha)[CM_FECHACITA],ce_orden,ce_hora,ce_numhist" & _
                                  ",hc_apepat+' '+hc_apemat+' '+hc_apecas+' '+hc_nombre[paciente],'ECOGRAFIA','ASCENZO APARICIO, RAFAEL'" & _
                                  ",case hc_TipoAsegurado when '01' then 'PARTICULAR' else ae_desc end [seguro]" & _
                                  ",''[Cobertura]" & _
                                  ",case when ce_atendido=1 then 'Paso Consulta' else '' end " & _
                                  "from dbclinica..citas_ecografia " & _
                                  "inner join dbclinica..Historias on ce_numhist=hc_numhis " & _
                                  "left join dbclinica..Aseguradora on hc_aseguradora=ae_codi " & _
                                  "where ce_fecha between '" & FechaD & "' and '" & FechaH & "' " & pacienteEcoSISA + MEcoSISA + SEcoSISA & _
                    ")as tmp ORDER BY CM_FECHACITA dESC ,CM_NUM_ORDEN aSC"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL02(ByVal EMpresa As Integer, ByRef oDt As DataSet)
            Dim Scrip As String
            Scrip = "select 'DE '+PR_TURNO_INI+' A '+PR_TURNO_FIN[1],ME_APE_PAT+' '+ME_APE_MAT+' '+ME_NOMBRES[2],PR_ID[1num] from SG_AD_TB_PROGRAMA_CITA " & _
                        "inner join SG_AD_TB_MEDICO on ME_CODIGO =PR_MEDICO and PR_IDEMPRESA =ME_IDEMPRESA " & _
                        "where PR_IDEMPRESA =" & EMpresa & " and PR_ESTADO=1 order by 2"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt, "Reporte1")
        End Sub
        Public Sub SEL03(ByVal FechaD As String, ByVal EMpresa As Integer, ByRef oDt As DataSet)
            Dim Scrip As String
            Scrip = "select CM_NUM_ORDEN[1num],CASE WHEN CM_IDNUMHIST IS NULL THEN CL_NOMBRE ELSE HC_APE_PAT +' '+HC_APE_MAT +' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2 END[1]" & _
                        ",RIGHT(REPLICATE('0',10)+CAST(CM_IDNUMHIST AS VARCHAR(10)),10)[2],case when CM_HORA_ATENC is null then 'P' else CM_HORA_ATENC end[3],CM_IDPROGRAMACION[2num] " & _
                    "from SG_AD_TB_CITA_MED " & _
                          "left join SG_AD_TB_HISTO_CLINI on HC_NUM_HIST=CM_IDNUMHIST " & _
                          "left join SG_FA_TB_CLIENTE on CL_ID=CM_IDCLIENTE " & _
                          "left join SG_AD_TB_PROGRAMA_CITA on CM_IDPROGRAMACION=PR_ID and PR_IDEMPRESA=CM_IDEMPRESA  " & _
                          "left join SG_AD_TB_MEDICO on ME_CODIGO =PR_MEDICO and PR_IDEMPRESA =ME_IDEMPRESA " & _
                    "WHERE CM_IDEMPRESA=" & EMpresa & " and convert(date,CM_FECHACITA)='" & FechaD & "'" & _
                    "ORDER BY ME_APE_PAT+' '+ME_APE_MAT+' '+ME_NOMBRES,CM_IDPROGRAMACION,CM_NUM_ORDEN"
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt, "Reporte2")
        End Sub

        Public Sub SEL04(ByRef oDt As DataTable, ByVal dato As String, ByVal Tipo As Integer)
            Dim cmd As New SqlCommand("SG_AD_TB_S_REP01", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@p_dato", System.Data.SqlDbType.VarChar).Value = dato
            cmd.Parameters.Add("@p_tipo", System.Data.SqlDbType.Int).Value = Tipo
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Sub SEL05(ByVal paciente As String, ByRef oDt As DataTable)
            Dim Scrip As String
            Scrip = "select CM_FECHACITA[fecha],AR_DESCRIPCION[tipo],CB_DESCRIPCION[cobertura] " & _
                    "from SG_AD_TB_PROGRAMA_CITA " & _
                    "inner join SG_AD_TB_CITA_MED on CM_IDPROGRAMACION =PR_ID   " & _
                    "left join SG_AD_TB_CUENTA_DET on CD_IDCITA =CM_ID   " & _
                    "left join SG_FA_TB_ARTICULO on CD_IDARTICULO =AR_ID    " & _
                    "left join SG_AD_TB_CUENTA_CAB on CC_ID =CD_IDCAB  " & _
                    "left join SG_AD_TB_COBERTURA on CB_ID =CC_SIT_COD_COBER  " & _
                    "where CM_HORA_ING<>'' and CC_IDNUM_HIST ='" & paciente & "' and PR_IDSERVICIO=7  " & _
                    "and CD_IDARTICULO in (337,338,331) and CD_SEG_CUBRE=1 and CC_IDSEGURO is not null order by CM_FECHACITA DESC "
            Dim cmd As New SqlCommand(Scrip, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Function SEL06(ByVal IDEmpresa As Integer, ByVal FECHAI As String, ByVal FECHAF As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_SP_S_ANAMNESIS", IDEmpresa, FECHAI, FECHAF).Tables(0)
        End Function

        Public Function get_Gra_Atencion(ByVal p_mes As Integer, ByVal p_fec1 As String, ByVal p_fec2 As String, ByVal p_ano As Integer, ByVal p_opc As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "AD_SP_S_GRAFICO_ATENCION", p_mes, p_fec1, p_fec2, p_ano, p_opc).Tables(0)
        End Function

        Public Function get_Gra_Intermedio(ByVal p_mes As Integer, ByVal p_fec1 As String, ByVal p_fec2 As String, ByVal p_ano As Integer, ByVal p_opc As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "AD_SP_S_GRAFICO_INTERVENCIONES", p_mes, p_fec1, p_fec2, p_ano, p_opc).Tables(0)
        End Function

        Public Function get_Gra_EcoXMedico(ByVal p_empresa As Integer, ByVal p_ano As Integer, ByVal p_Medico As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "AD_SP_S_GRAFICO_ECO_X_MEDICOS", p_empresa, p_ano, p_Medico).Tables(0)
        End Function

        Public Function get_Gra_EcoXTipo(ByVal p_empresa As Integer, ByVal p_mes As Integer, ByVal p_fec1 As String, ByVal p_fec2 As String, ByVal p_ano As Integer, ByVal p_opc As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "AD_SP_S_GRAFICO_ECO_TIPO", p_empresa, p_mes, p_fec1, p_fec2, p_ano, p_opc).Tables(0)
        End Function

    End Class

    Public Class SG_AD_TB_Centro_Costo
        Inherits ClsBD
        Public Sub insert(ByVal entidad As BE.AdmisionBE.SG_AD_TB_CENTRO_COSTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_I_CENTRO_COSTO", .id, .descripcion, .abreviatura, .idcc_conta, .usuario, .terminal, .fecreg, .idempresa)
            End With
        End Sub
        Public Sub update(ByVal entidad As BE.AdmisionBE.SG_AD_TB_CENTRO_COSTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_U_CENTRO_COSTO", .id, .descripcion, .abreviatura, .idcc_conta, .usuario, .terminal, .fecreg, .idempresa)
            End With
        End Sub
        Public Sub delete(ByVal entidad As BE.AdmisionBE.SG_AD_TB_CENTRO_COSTO)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_D_CENTRO_COSTO", .id, .idempresa)
            End With
        End Sub
        Public Function get_grilla(ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CENTRO_COSTO", empresa).Tables(0)
        End Function
        Public Function get_val(ByVal id As String, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CENTRO_COSTO2", id, empresa).Tables(0)
        End Function
    End Class
    Public Class SG_AD_TB_CATE_MEDI
        Inherits ClsBD
        Public Function get_categoria(empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CATE_MEDI", empresa).Tables(0)
        End Function
    End Class
    Public Class SG_AD_TB_MEDICA_RE
        Inherits ClsBD
        Public Sub insercion(entidad As BE.AdmisionBE.SG_AD_TB_MEDICA_RE)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_I_MEDICA_RE", .descripcion, .idcat, .compo_gene _
                                          , .presentacion, .idempresa)
            End With
        End Sub
        Public Sub actualizar(entidad As BE.AdmisionBE.SG_AD_TB_MEDICA_RE)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_U_MEDICA_RE", .id, .descripcion, .idcat, .compo_gene _
                                          , .presentacion, .idempresa)
            End With
        End Sub
        Public Sub eliminar(entidad As BE.AdmisionBE.SG_AD_TB_MEDICA_RE)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_AD_SP_D_MEDICA_RE", .id)
            End With
        End Sub
        Public Function mostrar(empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_MEDICA_RE2", empresa).Tables(0)
        End Function
        Public Function get_medicamentos(idcat As Integer, empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_MEDICA_RE", idcat, empresa).Tables(0)
        End Function
    Public Function mostrar_categoria() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_CATEGORIA").Tables(0)
        End Function
        Public Function mostrar_presentacion() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_PRESENTACION").Tables(0)
        End Function
    End Class
    Public Class SG_AD_TB_RECETA_MEDICA
        Inherits ClsBD

        Public Function Insert(ByVal obe As BE.AdmisionBE.SG_AD_TB_RECETA_MEDICA, ByVal ls_det As List(Of BE.AdmisionBE.SG_AD_TB_RECETA_DET)) As Integer
            Dim N As Integer = -1
            If Cn.State = ConnectionState.Open Then Cn.Close()
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim TRvar As SqlClient.SqlTransaction = Cn.BeginTransaction(System.Data.IsolationLevel.Serializable)

            Try
                N = SqlHelper.ExecuteScalar(TRvar, "SG_AD_SP_I_RECETA_MEDICA", obe.RM_IDCITA _
                      , obe.RM_IDHISTORIA _
                      )

                obe.RM_ID = N

                For Each d As BE.AdmisionBE.SG_AD_TB_RECETA_DET In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(TRvar, "SG_AD_SP_I_RECETA_DET", obe.RM_ID, .DR_IDMEDICAMENTO, .DR_RECETA, .DR_CANT_TOMA, .DR_OBS)
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

        Public Sub SEL01(ByVal obe As BE.AdmisionBE.SG_AD_TB_RECETA_MEDICA, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("SG_AD_SP_S_RECETA_DET", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DR_IDRECETA", System.Data.SqlDbType.Int).Value = obe.RM_ID
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Function SEL02(ByVal obe As BE.AdmisionBE.SG_AD_TB_RECETA_MEDICA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_AD_SP_S_RECETA_MEDICA", obe.RM_IDHISTORIA, obe.RM_IDCITA).Tables(0)
        End Function

    End Class
End Class
