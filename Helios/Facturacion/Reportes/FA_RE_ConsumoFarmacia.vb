Public Class FA_RE_ConsumoFarmacia
    Private obe As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
    Private obr As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    'Public Cuenta As Integer


    Private Sub FA_PR_ListaAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        uce_campos.SelectedIndex = 2

        obe = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obr = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

        Call Formatear_Grilla_Selector(ug_data)
        uck_Fecha.Checked = False
        udte_fechaD.Value = Now
        udte_fechaH.Value = Now
        udte_fechaD.Enabled = False
        udte_fechaH.Enabled = False

        ubtn_Consultar.Appearance.Image = My.Resources._16__Search_
        ubtn_Consultar.Appearance.ImageHAlign = Infragistics.Win.HAlign.Left
        'ubtn_Consultar.Appearance.TextHAlign = Infragistics.Win.HAlign.Right


        'obe.CC_IDEMPRESA = gInt_IdEmpresa
        'Dim obj As New DataTable
        'obr.SEL09(obe, uce_campos.Value, txt_filtro.Text, uck_Fecha.Checked, udte_fechaD.Text, udte_fechaH.Text, obj)
        'ug_data.DataSource = obj

        Me.KeyPreview = True

        ubtn_Consultar_Click(sender, e)

      

    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click

        Dim obj As New DataTable
        obe.CC_IDEMPRESA = gInt_IdEmpresa
        obr.SEL09(obe, uce_campos.Value, txt_filtro.Text, uck_Fecha.Checked, udte_fechaD.Text, udte_fechaH.Text, obj)
        ug_Lista.DataSource = obj

        If ug_Lista.Rows.Count > 0 Then
            Dim ReporteBL As New BL.FacturacionBL.SG_FA_Reportes
            'Dim dt_prog As DataTable
            ug_data.DataSource = ReporteBL.get_ConsumoFarmacia(ug_Lista.Rows(0).Cells("CC_ID").Value, ug_Lista.Rows(0).Cells("CC_IDTIPO_ORI").Value)

            '  ug_data.DataSource = ReporteBL.get_ConsumoFarmacia(ug_Lista.ActiveRow.Cells("CC_ID").Value)
            ReporteBL = Nothing
            Calcular_Totales()
        End If
    End Sub

    Private Sub uce_campos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_campos.KeyDown
        If e.KeyCode = Keys.Enter Then txt_filtro.Focus()
    End Sub

   
    Private Sub ug_data_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_data.InitializeRow
        If e.Row.Cells(7).Value = 1 Then
            e.Row.Appearance.BackColor = Color.FromArgb(255, 128, 128)
        Else
            e.Row.Appearance.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub uck_Fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Fecha.CheckedChanged
        If uck_Fecha.Checked = True Then
            udte_fechaD.Enabled = True
            udte_fechaH.Enabled = True
        Else
            udte_fechaD.Value = Now
            udte_fechaH.Value = Now
            udte_fechaD.Enabled = False
            udte_fechaH.Enabled = False
        End If
    End Sub

    Private Sub txt_filtro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_filtro.Leave
        ubtn_Consultar_Click(sender, e)
    End Sub

    'Private Sub Cargar_Detalle()
    '    Dim ReporteBL As New BL.FacturacionBL.SG_FA_Reportes
    '    'Dim dt_prog As DataTable
    '    ug_data.DataSource = ReporteBL.get_ConsumoFarmacia(ug_Lista.Rows(0).Cells("CC_ID").Value)

    '    ug_data.DataSource = ReporteBL.get_ConsumoFarmacia(ug_Lista.ActiveRow.Cells("CC_ID").Value)
    '    ReporteBL = Nothing
    '    Calcular_Totales()
    'End Sub
    Private Sub Calcular_Totales()

        txt_TotalC.Text = ""
        txt_TotalN.Text = ""

        Dim subtotalC As Decimal = "0.00"
        Dim subtotalN As Decimal = "0.00"

        For i As Integer = 0 To ug_data.Rows.Count - 1
            If ug_data.Rows(i).Cells(7).Value = 0 Then
                subtotalC = subtotalC + Val(ug_data.Rows(i).Cells(6).Value.ToString)
            Else
                subtotalN = subtotalN + Val(ug_data.Rows(i).Cells(6).Value.ToString)
            End If
        Next

        txt_TotalC.Value = Math.Round(subtotalC, 2)
        txt_TotalN.Value = Math.Round(subtotalN, 2)
    End Sub

    Private Sub ug_Lista_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Lista.AfterSelectChange
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

        Dim ReporteBL As New BL.FacturacionBL.SG_FA_Reportes
        'Dim dt_prog As DataTable
        'ug_data.DataSource = ReporteBL.get_ConsumoFarmacia(ug_Lista.Rows(0).Cells("CC_ID").Value)

        ug_data.DataSource = ReporteBL.get_ConsumoFarmacia(ug_Lista.ActiveRow.Cells("CC_ID").Value, ug_Lista.ActiveRow.Cells("CC_IDTIPO_ORI").Value)
        ReporteBL = Nothing
        Calcular_Totales()
    End Sub

    Private Sub ug_Lista_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ug_Lista.CellChange
     
    End Sub

    Private Sub ug_Lista_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles ug_Lista.ClickCell
       
    End Sub

    Private Sub txt_filtro_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_filtro.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Consultar.Focus()
        End If
    End Sub
End Class