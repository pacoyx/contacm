Public Class AD_PR_Recetas_Medicas

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tomar.KeyPress, txt_cada.KeyPress, txt_duracion.KeyPress, utxt_Cantidad.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub AD_PR_Recetas_Medicas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim rm_categoria As New BL.AdmisionBL.SG_AD_TB_CATE_MEDI
        ug_categoria.DataSource = rm_categoria.get_categoria(gInt_IdEmpresa)
        ug_categoria.DisplayLayout.Bands(0).Columns(0).Hidden = True
        ug_categoria.DisplayLayout.Bands(0).Columns(1).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        rm_categoria = Nothing

        limpiar()

        Me.KeyPreview = True

        Dim obe As New BE.AdmisionBE.SG_AD_TB_RECETA_MEDICA
        Dim obr As New BL.AdmisionBL.SG_AD_TB_RECETA_MEDICA
        Dim obj As New DataTable
        'obr.SEL01(gInt_IdEmpresa, Paciente, Fecha, obj)
        obe.RM_IDHISTORIA = Val(txt_idHistoria.Text)
        obe.RM_IDCITA = Val(txt_idCita.Text)
        obj = obr.SEL02(obe)

        ug_Lista.DataSource = obj
        If ug_Lista.Rows.Count > 0 Then
            Dim obj2 As New DataTable
            obe.RM_ID = ug_Lista.Rows(0).Cells(0).Value
            obr.SEL01(obe, obj2)
            ug_ListaDet.DataSource = obj2
        Else
            uds_ListaDet.Rows.Clear()
            ug_ListaDet.DataSource = uds_ListaDet
        End If

    End Sub

    Private Sub ug_categoria_ClickCell(sender As Object, e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles ug_categoria.ClickCell, ug_receta.ClickCell
        Dim rm_medicamentos As New BL.AdmisionBL.SG_AD_TB_MEDICA_RE
        ug_medicamentos.DataSource = rm_medicamentos.get_medicamentos(ug_categoria.ActiveRow.Cells(0).Value, gInt_IdEmpresa)
        ug_medicamentos.DisplayLayout.Bands(0).Columns(0).Hidden = True
        ug_medicamentos.DisplayLayout.Bands(0).Columns(1).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_medicamentos.DisplayLayout.Bands(0).Columns(2).Hidden = True
        ug_medicamentos.DisplayLayout.Bands(0).Columns(2).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_medicamentos.DisplayLayout.Bands(0).Columns(3).Hidden = True
        rm_medicamentos = Nothing
    End Sub

    Private Sub ug_medicamentos_Click(sender As Object, e As System.EventArgs) Handles ug_medicamentos.Click
        txt_compogene.Text = ug_medicamentos.ActiveRow.Cells(2).Value
        txt_presentacion.Text = ug_medicamentos.ActiveRow.Cells(3).Value
        lbl_presentacion.Text = ug_medicamentos.ActiveRow.Cells(3).Value

        If lbl_presentacion.Text = "AMPOLLA" Then
            lbl_tomar.Text = "Colocar"
            uc_Intramuscular.Checked = False
            uc_Subcutaneo.Checked = True
            uc_Intramuscular.Enabled = True
            uc_Subcutaneo.Enabled = True
        Else
            lbl_tomar.Text = "Tomar"
            uc_Intramuscular.Checked = False
            uc_Subcutaneo.Checked = False
            uc_Intramuscular.Enabled = False
            uc_Subcutaneo.Enabled = False
        End If

    End Sub

    Private Function fValidaD() As Boolean
        pLostfocus(txt_tomar, Nothing)

        If txt_tomar.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Public Sub cargar_receta()

        If fValidaD() = False Then Exit Sub
        Dim texto As String
        Dim textoAmpollas As String = ""
        ug_receta.DisplayLayout.Bands(0).AddNew()
        ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("DR_IDMEDICAMENTO").Value = ug_medicamentos.ActiveRow.Cells(0).Value
        ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("Medicamentos").Value = ug_medicamentos.ActiveRow.Cells(1).Value.ToString
        ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("Composición Generica").Value = txt_compogene.Text
        ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("Presentación").Value = txt_presentacion.Text
        ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("DR_CANT_TOMA").Value = Val(utxt_Cantidad.Text)
        ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("IDCAT").Value = ug_categoria.ActiveRow.Cells(0).Value

        texto = ""
        If uc_ayunas.Checked = True Then texto = " en ayunas"
        If uc_antescomida.Checked = True Then texto = texto & " antes de la comida"
        If uc_despuescomida.Checked = True Then texto = texto & " despues de la comida"
        If uc_durantecomida.Checked = True Then texto = texto & " durante la comida"

        If uc_Subcutaneo.Checked = True Then textoAmpollas = textoAmpollas & " via subcutaneo"
        If uc_Intramuscular.Checked = True Then textoAmpollas = textoAmpollas & " intramuscular"

        If txt_presentacion.Text = "AMPOLLA" Then
            ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("Observación").Value = "Colocar " & txt_tomar.Text & " ampolla(s) con un disolvente " & textoAmpollas & " los dias del ciclo."
        Else
            ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("Observación").Value = "Tomar " & txt_tomar.Text & "  " & txt_presentacion.Text & " cada " & _
            txt_cada.Text & "  " & IIf(uc_horas.Checked = True, "horas ", "dia ") & "durante " & txt_duracion.Text & " " & IIf(uc_dias2.Checked = True, "dias ", " segun evolución clínica") & IIf(texto <> "", ", ", "") & _
            texto & "."
        End If

        ug_receta.Rows(ug_receta.Rows.Count - 1).Cells("obs2").Value = txt_Observacion.Text.Trim

        utxt_Cantidad.Text = ""
        txt_tomar.Text = ""
        txt_cada.Text = ""
        txt_duracion.Text = ""
        txt_Observacion.Text = ""

    End Sub

    Public Sub limpiar()
        txt_compogene.Text = ""
        txt_presentacion.Text = ""
        txt_tomar.Text = ""
        txt_cada.Text = ""
        txt_duracion.Text = ""
        txt_Observacion.Text = ""
        utxt_Cantidad.Text = ""
        utxt_idReceta.Text = ""
        uc_ayunas.Checked = False
        uc_antescomida.Checked = False
        uc_durantecomida.Checked = False
        uc_despuescomida.Checked = False

        uc_Intramuscular.Checked = False
        uc_Subcutaneo.Checked = False
        uc_Intramuscular.Enabled = False
        uc_Subcutaneo.Enabled = False
        LimpiaGrid(ug_receta, uds_receta)
        'utc_Datos .t
        ugb_Datos.Enabled = False
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Imprimir.Enabled = True
        Call MostrarTabs(0, utc_Datos, 1)

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click
        Call cargar_receta()
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call limpiar()
        Tool_Nuevo.Enabled = False
        Tool_Grabar.Enabled = True
        Tool_Imprimir.Enabled = False

        ugb_Datos.Enabled = True
        Call MostrarTabs(0, utc_Datos, 1)
    End Sub

    Private Function fValida() As Boolean
        pLostfocus(txt_idHistoria, Nothing)

        If txt_idHistoria.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        If ug_receta.Rows.Count = 0 Then
            Avisar("No hay productos en el detalle")
            Exit Sub
        End If
        Dim obe As New BE.AdmisionBE.SG_AD_TB_RECETA_MEDICA
        Dim obr As New BL.AdmisionBL.SG_AD_TB_RECETA_MEDICA

        Dim obeT As BE.AdmisionBE.SG_AD_TB_RECETA_DET

        With obe
            .RM_IDCITA = Val(txt_idCita.Text)
            .RM_IDHISTORIA = Val(txt_idHistoria.Text)
        End With


        Dim ls_detalles As New List(Of BE.AdmisionBE.SG_AD_TB_RECETA_DET)
        ug_receta.UpdateData()

        For i As Integer = 0 To ug_receta.Rows.Count - 1
            obeT = New BE.AdmisionBE.SG_AD_TB_RECETA_DET
            With obeT
                .DR_IDMEDICAMENTO = ug_receta.Rows(i).Cells("DR_IDMEDICAMENTO").Value
                .DR_RECETA = ug_receta.Rows(i).Cells("Observación").Value
                .DR_CANT_TOMA = ug_receta.Rows(i).Cells("DR_CANT_TOMA").Value
                .DR_OBS = ug_receta.Rows(i).Cells("obs2").Value
            End With
            ls_detalles.Add(obeT)
        Next
        Dim D As Integer
        D = obr.Insert(obe, ls_detalles)
        If D < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        utxt_idReceta.Text = D
        Call Avisar("Listo!")

        ugb_Datos.Enabled = False
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Imprimir.Enabled = True


        Dim obj As New DataTable
        'obr.SEL01(gInt_IdEmpresa, Paciente, Fecha, obj)
        obe.RM_IDHISTORIA = Val(txt_idHistoria.Text)
        obe.RM_IDCITA = Val(txt_idCita.Text)
        obj = obr.SEL02(obe)

        ug_Lista.DataSource = obj
        If ug_Lista.Rows.Count > 0 Then
            Dim obj2 As New DataTable
            obe.RM_ID = ug_Lista.Rows(0).Cells(0).Value
            obr.SEL01(obe, obj2)
            ug_ListaDet.DataSource = obj2
        Else
            uds_ListaDet.Rows.Clear()
            ug_ListaDet.DataSource = uds_ListaDet
        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imprimir.Click
        Dim dt_LISTA As New DataTable
        Dim obe As New BE.AdmisionBE.SG_AD_TB_RECETA_MEDICA
        Dim obr As New BL.AdmisionBL.SG_AD_TB_RECETA_MEDICA
        Dim NOta As String = ""
        If utc_Datos.Tabs(0).Selected = True Then
            obe.RM_ID = Val(utxt_idReceta.Text)
            For i As Integer = 0 To ug_receta.Rows.Count - 1
                If ug_receta.Rows(i).Cells("IDCAT").Value = 1 Then
                    NOta = "NOTA: El 1º día del ciclo es el 1º día de la regla"
                End If
            Next

        Else
            obe.RM_ID = ug_Lista.ActiveRow.Cells(0).Value
            For i As Integer = 0 To ug_ListaDet.Rows.Count - 1
                If ug_ListaDet.Rows(i).Cells("3").Value = 1 Then
                    NOta = "NOTA: El 1º día del ciclo es el 1º día de la regla"
                End If
            Next
        End If

        'Dim obj As New DataTable

        obr.SEL01(obe, dt_LISTA)
        'ug_detalle.DataSource = dt_comprobante

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_LISTA.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte

                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_AD_06.RPT", dt_LISTA, "", "pNota;" & NOta, "pPaciente;" & txt_Des_Cliente.Text)
                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ug_Lista_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Lista.AfterSelectChange
        Dim obe As New BE.AdmisionBE.SG_AD_TB_RECETA_MEDICA
        Dim obr As New BL.AdmisionBL.SG_AD_TB_RECETA_MEDICA
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub
        Dim obj As New DataTable
        obe.RM_ID = ug_Lista.ActiveRow.Cells(0).Value
        obr.SEL01(obe, obj)
        ug_ListaDet.DataSource = obj
    End Sub

    Private Sub ubt_Quitar_Click(sender As System.Object, e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_receta.Rows.Count = 0 Then Exit Sub
        If ug_receta.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro que deseas eliminar el registro?") Then
            ug_receta.ActiveRow.Delete()
        End If

    End Sub

    Private Sub ug_receta_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_receta.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub

    Private Sub uc_Intramuscular_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uc_Intramuscular.CheckedChanged
        If uc_Intramuscular.Checked Then
            uc_Subcutaneo.Checked = False
        End If
    End Sub

    Private Sub uc_Subcutaneo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uc_Subcutaneo.CheckedChanged
        If uc_Subcutaneo.Checked Then
            uc_Intramuscular.Checked = False
        End If
    End Sub
End Class