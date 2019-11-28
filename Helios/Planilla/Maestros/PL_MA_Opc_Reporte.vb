Public Class PL_MA_Opc_Reporte


    Public bol_salir As Boolean = False
    Public bol_listado As Boolean = False
    Public bol_ficha As Boolean = False
    Public bol_activos As Boolean = False

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        bol_ficha = False
        bol_listado = False
        bol_salir = True
    End Sub

    Private Sub ubtn_Listado_Gen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Listado_Gen.Click
        Me.Close()
        bol_activos = uchk_activos.Checked
        bol_listado = True
        bol_ficha = False
        bol_salir = False
    End Sub

    Private Sub ubtn_Ficha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Ficha.Click
        Me.Close()
        bol_ficha = True
        bol_listado = False
        bol_salir = False
    End Sub

    Private Sub PL_MA_Opc_Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class