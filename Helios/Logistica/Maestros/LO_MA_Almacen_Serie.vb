Public Class LO_MA_Almacen_Serie
    Private obe As BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE
    Private obr As BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE
        obr = New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub LO_MA_Almacen_Serie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Almacen()
        Cargar_TipoDOC()
        obe = New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE
        obr = New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
        Me.KeyPreview = True
    End Sub
    Private Sub Cargar_Serie_x_Almacen()

        obe.AS_IDEMPRESA = gInt_IdEmpresa
        obe.AS_IDALMACEN = uce_Almacen.Value

        ug_Lista.DataSource = obr.SEL01(obe)
    End Sub

    Private Sub Cargar_TipoDOC()

        Dim documentosBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCUMENTO
        uce_TipoDoc.DataSource = documentosBL.get_ListaDoc(gInt_IdEmpresa)
        uce_TipoDoc.DisplayMember = "TD_DESCRIPCION"
        uce_TipoDoc.ValueMember = "TD_ID"
        documentosBL = Nothing

    End Sub

    Private Sub Cargar_Almacen()

        Dim ABL As New BL.LogisticaBL.SG_LO_TB_ALMACEN

        uce_Almacen.DataSource = ABL.get_almacen_3(gInt_IdEmpresa)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        ABL = Nothing
    End Sub

    Private Sub ubtn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Agregar.Click
        If uce_Almacen.Value = "" Then Exit Sub

        For i As Integer = 0 To ug_Lista.Rows.Count - 1
            If ug_Lista.Rows(i).Cells(0).Value = uce_TipoDoc.Value And ug_Lista.Rows(i).Cells(2).Value = uce_Serie.Value Then
                Avisar("Ya existe la serie en la lista")
                Exit Sub
            End If
        Next

        obe.AS_IDEMPRESA = gInt_IdEmpresa
        obe.AS_IDALMACEN = uce_Almacen.Value
        obe.AS_TDOC = uce_TipoDoc.Value
        obe.AS_SERIE = uce_Serie.Value

        If obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call Cargar_Serie_x_Almacen()

    End Sub

    Private Sub ubtn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_eliminar.Click
        obe.AS_IDEMPRESA = gInt_IdEmpresa
        obe.AS_IDALMACEN = uce_Almacen.Value
        obe.AS_TDOC = ug_Lista.ActiveRow.Cells("AS_TDOC").Value
        obe.AS_SERIE = ug_Lista.ActiveRow.Cells("AS_SERIE").Value

        If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Call Cargar_Serie_x_Almacen()
    End Sub
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obe = Nothing
        obr = Nothing
        e.Cancel = False
    End Sub

    Private Sub uce_TipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.ValueChanged

        Dim numBL As New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
        Dim numBE As New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO

        numBE.NC_IDTIPO = uce_TipoDoc.Value
        numBE.NC_IDEMPRESA = gInt_IdEmpresa

        uce_Serie.DataSource = numBL.SEL03(numBE)
        uce_Serie.DisplayMember = "NC_SERIE"
        uce_Serie.ValueMember = "NC_SERIE"

        numBL = Nothing
        numBE = Nothing

    End Sub

    Private Sub uce_Almacen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Almacen.ValueChanged
        Cargar_Serie_x_Almacen()
    End Sub

    Private Sub Tool_Salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class