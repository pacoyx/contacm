﻿Public Class SIG_RE_Aten_Seguros_Ambu
    Private obr As BL.FacturacionBL.SG_FA_Reportes
    Private Paciente As String
    Private Servicio As String
    Private Medico As String
    Public Sub New()
        InitializeComponent()
        obr = New BL.FacturacionBL.SG_FA_Reportes
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus

        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If

    End Sub
    Private Function fValida() As Boolean

        udte_fechaD.BackColor = Color.White
        udte_fechaH.BackColor = Color.White
        If udte_fechaD.Value = Nothing Then udte_fechaD.BackColor = Color.LightPink
        If udte_fechaH.Value = Nothing Then udte_fechaH.BackColor = Color.LightPink

        If udte_fechaD.BackColor = Color.LightPink Then GoTo Err_Valida
        If udte_fechaH.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False

    End Function


    Private Sub AD_RE_ConsultaCitasXfecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obr = New BL.FacturacionBL.SG_FA_Reportes

        Cancelar()

        Me.KeyPreview = True

        udte_fechaD.Focus()
    End Sub


    Private Sub Cancelar()
        'uck_Paciente.Checked = False
        'uck_Medico.Checked = False
        'uck_Servicio.Checked = False

        'txt_ruc_cliente.Enabled = False
        'uce_tip_doc.Enabled = False
        'uce_Medico.Enabled = False
        'uce_Servicio.Enabled = False

        udte_fechaD.Value = Now.Date
        udte_fechaH.Value = Now.Date

        'txt_ruc_cliente.Text = ""
        'uce_tip_doc.SelectedIndex = 0
        'uce_Medico.SelectedIndex = 0
        'uce_Servicio.SelectedIndex = 0

        Servicio = ""
        Paciente = ""
        Medico = ""

        uds_Lista.Rows.Clear()
        ug_Lista.DataSource = uds_Lista
    End Sub
    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cancelar()
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        'Dim obj As New DataTable
        ug_Lista.DataSource = obr.get_Atencion_Seguros_Ambu(gInt_IdEmpresa, udte_fechaD.Text, udte_fechaH.Text)
        ' ug_Lista.DataSource = obj
    End Sub

    Private Sub ug_Lista_InitializeGroupByRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_Lista.InitializeGroupByRow
        e.Row.Expanded = True
        If (e.Row.ChildBands.Count > 0) Then
            e.Row.ChildBands(0).Rows.ExpandAll(True)
            'e.Row.ChildBands(0).Rows.CollapseAll(True)
        End If

    End Sub


    'Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim obj As New DataTable
    '    obr.get_Atencion_Seguros_Ambu(udte_fechaD.Text, udte_fechaH.Text, gInt_IdEmpresa, Paciente, Servicio, Medico, obj)

    '    Dim nom_reporte As String = "SG_AD_04.RPT"
    '    Dim crystalBL As New LR.ClsReporte
    '    Dim dt_data As New DataTable
    '    dt_data = obj

    '    crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "")


    '    crystalBL = Nothing
    '    ' reportesBL = Nothing

    '    Me.Cursor = Cursors.Default
    'End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exportar.Click

        Dim str_nom_excel As String = "AtenSegAmbu_" & Now.Second.ToString & ".xls"

        Try

            uge1.Export(ug_Lista, str_nom_excel)
            Process.Start(str_nom_excel)

        Catch ex As Exception

            'Dim Obj_Funciones As New LR.ClsFunciones
            'Obj_Funciones.exportar_A_MS_Excel(dt_tmp, Str_titulo)
            'Obj_Funciones = Nothing
            'Process.Start("explorer.exe", Application.StartupPath)

        End Try
    End Sub
End Class