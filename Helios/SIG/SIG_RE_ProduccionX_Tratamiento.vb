﻿Public Class SIG_RE_ProduccionX_Tratamiento
    Private obr As BL.FacturacionBL.SG_FA_Reportes
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
    Private Sub Cancelar()

        udte_fechaD.Value = Now.Date
        udte_fechaH.Value = Now.Date
        uck_Medico.Checked = False
        uce_Medico.Enabled = False
        ug_Lista.DataSource = Nothing
    End Sub
    Private Sub SIG_RE_ProduccionX_Tratamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obr = New BL.FacturacionBL.SG_FA_Reportes

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing
        Cancelar()

        Me.KeyPreview = True

        udte_fechaD.Focus()
    End Sub
    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cancelar()
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        'Dim obj As New DataTable
        Me.Cursor = Cursors.WaitCursor
        Dim obt As DataTable = obr.get_ProduccionTratamiento(gInt_IdEmpresa, udte_fechaD.Text, udte_fechaH.Text)
        ug_Lista.DataSource = obt
        ug_Lista.DisplayLayout.Bands(0).Columns(0).Width = 210
        ug_Lista.DisplayLayout.Bands(0).Columns(0).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        'ug_Lista.DisplayLayout.Bands(0).Columns.c()
        Formatear_Grilla_Selector(ug_Lista)

        Me.Cursor = Cursors.Default
        ' ug_Lista.DataSource = obj
    End Sub

    'Private Sub ug_Lista_InitializeGroupByRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_Lista.InitializeGroupByRow
    '    e.Row.Expanded = True
    '    If (e.Row.ChildBands.Count > 0) Then
    '        e.Row.ChildBands(0).Rows.ExpandAll(True)
    '        'e.Row.ChildBands(0).Rows.CollapseAll(True)
    '    End If
    'End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exportar.Click

        Dim str_nom_excel As String = "ProduccionTratamiento_" & Now.Second.ToString & ".xls"
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
    Private Sub uck_Medico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Medico.CheckedChanged
        If uck_Medico.Checked = True Then
            uce_Medico.Enabled = True
        Else
            uce_Medico.Enabled = False
        End If
    End Sub

End Class