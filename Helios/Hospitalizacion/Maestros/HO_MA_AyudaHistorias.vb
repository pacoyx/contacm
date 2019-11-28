Public Class HO_MA_AyudaHistorias
    Public Bol_Aceptar As Boolean = False
    Public lista_empleados As New List(Of BE.AdmisionBE.SG_AD_TB_HISTO_CLINI)

    Public ReadOnly Property Matriz()
        Get
            Return lista_empleados
        End Get
    End Property

    Private Sub Focus_Filtro()
        If ug_Listado_Historias.Rows.Count = 0 Then Exit Sub
        ug_Listado_Historias.Rows(0).Activate()
        ug_Listado_Historias.Rows.FilterRow.Cells("HC_NUM_HIST").Activate()
        ug_Listado_Historias.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub HO_MA_AyudaHistorias_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Call Focus_Filtro()
    End Sub

    Private Sub HO_MA_AyudaHistorias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim historiasBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        ug_Listado_Historias.DataSource = historiasBL.get_Historias_Ayuda(gInt_IdEmpresa)
        historiasBL = Nothing

    End Sub

    Private Sub Tool_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Aceptar.Click

        Dim empleado As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        lista_empleados.Clear()
        ug_Listado_Historias.UpdateData()

        If ug_Listado_Historias.ActiveRow.IsFilterRow Then Exit Sub
        If ug_Listado_Historias.ActiveRow Is Nothing Then Exit Sub

        empleado = New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI()

        empleado.HC_NUM_HIST = ug_Listado_Historias.ActiveRow.Cells("HC_NUM_HIST").Value.ToString
        empleado.HC_IDCLIENTE = ug_Listado_Historias.ActiveRow.Cells("HC_IDCLIENTE").Value.ToString
        empleado.HC_NDOC = ug_Listado_Historias.ActiveRow.Cells("HC_NDOC").Value.ToString
        empleado.HC_NOMBRE1 = ug_Listado_Historias.ActiveRow.Cells("NOMBRES").Value.ToString
        empleado.HC_APE_PAT = ug_Listado_Historias.ActiveRow.Cells("HC_APE_PAT").Value
        empleado.HC_APE_MAT = ug_Listado_Historias.ActiveRow.Cells("HC_APE_MAT").Value
        empleado.HC_APE_CASADA = ug_Listado_Historias.ActiveRow.Cells("HC_APE_CASADA").Value

        lista_empleados.Add(empleado)
        Bol_Aceptar = True
        Me.Close()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub ug_Listado_Historias_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Listado_Historias.DoubleClickRow
        If ug_Listado_Historias.ActiveRow.ListIndex = -1 Then Exit Sub
        Call Tool_Aceptar_Click(sender, e)
    End Sub
End Class