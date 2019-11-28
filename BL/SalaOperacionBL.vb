Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class SalaOperacionBL

    Public Class SG_SO_TB_Reportes

        Inherits ClsBD

        Public Function get_PROGRAMACION(ByVal p_fec1 As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SO_SP_S_PROGRAMACION", p_fec1).Tables(0)
        End Function

    End Class
  
End Class
