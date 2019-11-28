Imports Infragistics.Win.UltraWinGrid

Public Class PL_RP_Planilla_Mes

    Private Sub PL_RP_Planilla_Mes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        'uce_Mes.Value = gDat_Fecha_Sis.Month
        uce_Mes.SelectedIndex = -1

        Call Cargar_TipoPersonal()
        uce_TipoPersonal.SelectedIndex = 0

        UltraGridColumnChooser1.SourceGrid = ug_planilla
        UltraGridColumnChooser1.CurrentBand = ug_planilla.DisplayLayout.Bands(0)
        UltraGridColumnChooser1.Style = ColumnChooserStyle.AllColumnsWithCheckBoxes
        UltraGridColumnChooser1.MultipleBandSupport = MultipleBandSupport.SingleBandOnly

        Call Formatear_Grilla_Selector(ug_planilla)

        'Tool_Imprimir.Enabled = False
        Tool_Imprimir_Chico.Enabled = False

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_exportar.Click
        Dim str_nom_excel As String = "planilla_mes_" & Now.Second.ToString & ".xls"
        uge_planilla.Export(ug_planilla, str_nom_excel)
        Process.Start(str_nom_excel)
    End Sub

    'Private Sub Tool_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Me.Cursor = Cursors.WaitCursor

    '    UltraPrintPreviewDialog1.Document = ugpd_Planilla
    '    UltraPrintPreviewDialog1.ShowDialog()

    '    Me.Cursor = Cursors.Default
    'End Sub

    Private Sub Tool_VerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Cargar_Reporte()
    End Sub

    Private Sub Cargar_Reporte()

        If uce_Mes.SelectedIndex = -1 Then Exit Sub
        If uce_TipoPersonal.SelectedIndex = -1 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_reporte As DataTable = reportesBL.get_Planilla_mes_1(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, uce_TipoPersonal.Value)

        For i As Integer = 0 To dt_reporte.Rows.Count - 1
            For c As Integer = 7 To dt_reporte.Columns.Count - 1
                If dt_reporte.Rows(i)(c).ToString = "" Then
                    dt_reporte.Rows(i)(c) = 0
                End If
            Next
        Next


        ug_planilla.DataSource = Nothing
        ug_planilla.DataSource = dt_reporte
        reportesBL = Nothing


        For i As Integer = 3 To ug_planilla.DisplayLayout.Bands(0).Columns.Count - 1
            ug_planilla.DisplayLayout.Bands(0).Columns(i).Style = ColumnStyle.Double
            ug_planilla.DisplayLayout.Bands(0).Columns(i).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            ug_planilla.DisplayLayout.Bands(0).Columns(i).MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
            ug_planilla.DisplayLayout.Bands(0).Columns(i).Hidden = True
            ug_planilla.DisplayLayout.Bands(0).Columns(i).Width = 60
        Next


        ug_planilla.DisplayLayout.Bands(0).Columns("tot_ing").Width = 90
        ug_planilla.DisplayLayout.Bands(0).Columns("tot_des").Width = 90
        ug_planilla.DisplayLayout.Bands(0).Columns("saldo").Width = 90

        ug_planilla.DisplayLayout.Bands(0).Columns("tot_ing").CellAppearance.BackColor = Color.Azure
        ug_planilla.DisplayLayout.Bands(0).Columns("tot_des").CellAppearance.BackColor = Color.Beige
        ug_planilla.DisplayLayout.Bands(0).Columns("saldo").CellAppearance.BackColor = Color.SeaShell


        ug_planilla.DisplayLayout.UseFixedHeaders = True


        ug_planilla.DisplayLayout.Bands(0).Columns(1).Header.Fixed = True

        ug_planilla.DisplayLayout.Bands(0).Columns("NOMBRES").Width = 250
        ug_planilla.DisplayLayout.Bands(0).Columns("DIAS").Width = 40
        ug_planilla.DisplayLayout.Bands(0).Columns("HI_ID_PERSONAL").Hidden = True



        ug_planilla.DisplayLayout.Bands(0).Columns("tot_ing").Hidden = False
        ug_planilla.DisplayLayout.Bands(0).Columns("tot_des").Hidden = False
        ug_planilla.DisplayLayout.Bands(0).Columns("saldo").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Remuner.  Ordinaria").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Asig. Familiar").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Horas Extras 1.25").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Horas Extras 1.35").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Horas Extras 2").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Remuner. x Horas").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Vacaciones").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Gratificación").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("CTS").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Bon. Extr. Ley 29351").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Faltas y Tardanzas").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Sist. Nac. Pensiones").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("5ta. Categoria").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("Quincena").Hidden = False
        'ug_planilla.DisplayLayout.Bands(0).Columns("AFP Jubilación").Hidden = False
        ug_planilla.DisplayLayout.Bands(0).Columns("EsSalud").Hidden = False

        UltraGridColumnChooser1.ColumnDisplayOrder = ColumnDisplayOrder.SameAsGrid

        Tool_Imprimir_Chico.Enabled = True

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ug_planilla_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_planilla.InitializeLayout


        For i As Integer = 3 To ug_planilla.DisplayLayout.Bands(0).Columns.Count - 1

            Dim str_nom_cab As String = ug_planilla.DisplayLayout.Bands(0).Columns(i).Header.Caption

            If Not e.Layout.Bands(0).Summaries.Exists("sum_" & str_nom_cab) Then
                Dim tt As SummarySettings
                tt = e.Layout.Bands(0).Summaries.Add("sum_" & str_nom_cab, SummaryType.Sum, e.Layout.Bands(0).Columns(str_nom_cab), SummaryPosition.UseSummaryPositionColumn)
                tt.DisplayFormat = "{0:##,##0.00#}"
                tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
                e.Layout.Bands(0).SummaryFooterCaption = "Totales"
            End If

        Next

    End Sub

    Private Sub Tool_Imprimir_Chico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir_Chico.Click

        Me.Cursor = Cursors.WaitCursor

        If ug_planilla.Rows.Count = 0 Then Exit Sub

        Dim dt_tmp As DataTable = CType(ug_planilla.DataSource, DataTable)
        Dim ObjCrystal As New LR.ClsReporte


        '1=empleados
        '2=horas
        '3=contratos

        If uce_TipoPersonal.Value = 1 Then
            ObjCrystal.Muestra_Reporte(gStr_RutaRep & "\SG_PL_088.RPT", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & uce_Mes.Text & " " & une_Ayo.Value.ToString)
        Else
            ObjCrystal.Muestra_Reporte(gStr_RutaRep & "\SG_PL_088_B.RPT", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & uce_Mes.Text & " " & une_Ayo.Value.ToString)
        End If

        ObjCrystal.Dispose()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        Call Cargar_Reporte()
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Reporte()
    End Sub
End Class