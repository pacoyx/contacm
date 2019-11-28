'Imports System.Data.Objects
'Imports System.Data.Objects.DataClasses

Public Class PL_RP_CtaCte

    'Private planillaContexto As DBCONTABLEEntities


    Private Sub PL_RP_CtaCte_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txt_cod_personal.ButtonsRight(0).Appearance.Image = My.Resources._104
        Call Cargar_Combos()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes

        Me.Cursor = Cursors.WaitCursor
        Dim dt_tmp As DataTable = reportesBL.get_Estado_CtaCte_x_Emp(IIf(txt_id_personal.Text.Trim.Length = 0, 0, txt_id_personal.Text.Trim), _
                                                                     uce_estado_pres.Value, uce_motivo_pres.Value, gInt_IdEmpresa)

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_22.rpt", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, "pFecha; ")
        End Using

        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Mostrar_Ayuda_Empleado()

        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.ShowDialog()
        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then

                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    txt_cod_personal.Text = empleado.PE_CODIGO
                    txt_nombres.Text = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                    txt_id_personal.Text = empleado.PE_ID
                Next
            End If
            matriz = Nothing

        End If
    End Sub

    Private Sub txt_cod_personal_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_personal.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub txt_cod_personal_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_personal.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Mostrar_Ayuda_Empleado()
        End If
    End Sub

    Private Sub Cargar_Combos()


        Dim estadoBL As New BL.PlanillaBL.SG_PL_TB_ESTADO_PRESTAMO
        Dim motivoBL As New BL.PlanillaBL.SG_PL_TB_MOTIVO_PRESTAMO

        Dim dt_tmp As DataTable = Nothing
        dt_tmp = estadoBL.get_Estados

        uce_estado_pres.Items.Clear()
        uce_estado_pres.Items.Add(0, "[Todos]")
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            uce_estado_pres.Items.Add(dt_tmp.Rows(i)("EP_ID"), dt_tmp.Rows(i)("EP_DESCRIPCION"))
        Next

        
        dt_tmp = motivoBL.get_Motivos
        uce_motivo_pres.Items.Clear()
        uce_motivo_pres.Items.Add(0, "[Todos]")
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            uce_motivo_pres.Items.Add(dt_tmp.Rows(i)("MP_ID"), dt_tmp.Rows(i)("MP_DESCRIPCION"))
        Next

        

        estadoBL = Nothing
        motivoBL = Nothing

        uce_estado_pres.SelectedIndex = 0
        uce_motivo_pres.SelectedIndex = 0


        'planillaContexto = New DBCONTABLEEntities()

        'Dim estadoQuery As ObjectQuery(Of SG_PL_TB_ESTADO_PRESTAMO) = _
        'From d In planillaContexto.SG_PL_TB_ESTADO_PRESTAMO
        'Order By d.EP_ID
        'Select d

        'uce_estado_pres.Items.Clear()
        'uce_estado_pres.Items.Add(0, "[Todos]")
        'For Each o In estadoQuery
        '    uce_estado_pres.Items.Add(o.EP_ID, o.EP_DESCRIPCION)
        'Next


        ''uce_estado_pres.DataSource = CType(estadoQuery, ObjectQuery).Execute(MergeOption.AppendOnly)
        ''uce_estado_pres.ValueMember = "EP_ID"
        ''uce_estado_pres.DisplayMember = "EP_DESCRIPCION"

        'Dim motivoQuery As ObjectQuery(Of SG_PL_TB_MOTIVO_PRESTAMO) = From m In planillaContexto.SG_PL_TB_MOTIVO_PRESTAMO
        '                                             Order By m.MP_ID Select m

        'uce_motivo_pres.Items.Clear()
        'uce_motivo_pres.Items.Add(0, "[Todos]")
        'For Each m In motivoQuery
        '    uce_motivo_pres.Items.Add(m.MP_ID, m.MP_DESCRIPCION)
        'Next

        'If uce_estado_pres.Items.Count > 0 Then uce_estado_pres.SelectedIndex = 0
        'If uce_motivo_pres.Items.Count > 0 Then uce_motivo_pres.SelectedIndex = 0

        ''uce_motivo_pres.DataSource = CType(motivoQuery, ObjectQuery).Execute(MergeOption.AppendOnly)
        ''uce_motivo_pres.ValueMember = "MP_ID"
        ''uce_motivo_pres.DisplayMember = "MP_DESCRIPCION"


    End Sub

    Private Sub txt_cod_personal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_cod_personal.ValueChanged
        If txt_cod_personal.Text.Trim.Length = 0 Then
            txt_id_personal.Text = String.Empty
            txt_nombres.Text = "[Todos]"
        End If
    End Sub
End Class