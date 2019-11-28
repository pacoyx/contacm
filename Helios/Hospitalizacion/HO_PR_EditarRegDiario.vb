Public Class HO_PR_EditarRegDiario
    Dim dv_Lista As New DataView
    Dim dt_Lista As New DataTable
    Dim str_AreaPersonal As String = String.Empty
    Dim ls_ultFecha As List(Of String)

    Private Sub HO_PR_EditarRegDiario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_mes)
        txt_ayo.Value = gDat_Fecha_Sis.Year
        uce_mes.SelectedIndex = gDat_Fecha_Sis.Month
        Call Cargar_Lista_personal()
        ug_ListaPer.Left = 76
        ug_ListaPer.Top = 102
        txt_Filtro.Focus()

    End Sub


    Private Sub Buscar_Area_Personal()

        Dim idpersonal As Integer = txt_idper.Text.Trim

        Dim marcacionBL As New BL.HospitalBL.Funciones
        str_AreaPersonal = marcacionBL.get_Area_Personal(idpersonal, gInt_IdEmpresa)

        If str_AreaPersonal = String.Empty Then
            MessageBox.Show("Falta establecer AREA para el personal, comunicarse con RRHH o con SISTEMAS")
            Exit Sub
        End If

        Select Case str_AreaPersonal
            Case "9" 'sala de bebes
                txt_Area.Text = "Sala de Bebes"
            Case "10" 'hospi
                txt_Area.Text = "Hospitalizacion"
        End Select

        marcacionBL = Nothing


    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Modificar.Click

        Try

            HO_PR_RegDiaPer.Close()

            Dim MarcacionBE As New BE.HospitalBE.SG_PL_TB_MARCA_ASIS
            With MarcacionBE
                .MA_IDPERSONAL = txt_idper.Text
                .MA_FECHA = ug_ListaMarcaciones.ActiveRow.Cells("MA_FECHA").Value.ToString
                .MA_HORA_ENT = ug_ListaMarcaciones.ActiveRow.Cells("MA_HORA_ENT").Value.ToString
                .MA_TM_ENT = ug_ListaMarcaciones.ActiveRow.Cells("MA_TM_ENT").Value.ToString
                .MA_HORA_SAL = ug_ListaMarcaciones.ActiveRow.Cells("MA_HORA_SAL").Value.ToString
                .MA_TM_SAL = ug_ListaMarcaciones.ActiveRow.Cells("MA_TM_SAL").Value.ToString
                .MA_TIEMPO = ug_ListaMarcaciones.ActiveRow.Cells("MA_TIEMPO").Value.ToString
                .MA_IDTIPO_REG = ug_ListaMarcaciones.ActiveRow.Cells("MA_IDTIPO_REG").Value
                .MA_OBS = ug_ListaMarcaciones.ActiveRow.Cells("MA_OBS").Value.ToString
                .MA_IDEMPRESA = gInt_IdEmpresa
                .MA_IDSERVICIO = ug_ListaMarcaciones.ActiveRow.Cells("MA_IDSERVICIO").Value
                .MA_ITEM = ug_ListaMarcaciones.ActiveRow.Cells("MA_ITEM").Value
                .MA_VACA_INI = ug_ListaMarcaciones.ActiveRow.Cells("MA_VACA_INI").Value.ToString
                .MA_VACA_FIN = ug_ListaMarcaciones.ActiveRow.Cells("MA_VACA_FIN").Value.ToString
                .MA_ES_REFRI = ug_ListaMarcaciones.ActiveRow.Cells("MA_ES_REFRI").Value.ToString
                .MA_ES_FERIADO = ug_ListaMarcaciones.ActiveRow.Cells("MA_ES_FERIADO").Value.ToString
            End With

            HO_PR_RegDiaPer.MarcacionBE = MarcacionBE
            HO_PR_RegDiaPer.nomper_ = txt_Filtro.Text.Trim
            HO_PR_RegDiaPer.codper_ = txt_codper.Text.Trim
            HO_PR_RegDiaPer.bol_edicion = True

            If ug_ListaMarcaciones.ActiveRow.Cells("MA_FECHA").Value.ToString = ls_ultFecha(0) Then
                If ug_ListaMarcaciones.ActiveRow.Cells("MA_ITEM").Value = ls_ultFecha(1) Then
                    HO_PR_RegDiaPer.dat_fecha_Ini = CDate(udte_fec_ini.Value).ToShortDateString
                    HO_PR_RegDiaPer.dat_fecha_Fin = CDate(udte_fec_fin.Value).ToShortDateString
                    HO_PR_RegDiaPer.bol_Ultimo_Dia = True
                End If
            End If

            HO_PR_RegDiaPer.ShowDialog()
            If HO_PR_RegDiaPer.bol_ok Then
                Call Cargar_Data_Lista()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub uce_mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_mes.ValueChanged
        Dim fecha_tmp As Date = "01/" & uce_mes.Value.ToString.PadLeft(2, "0") & "/" & txt_ayo.Text
        udte_fec_ini.Value = "25/" & fecha_tmp.AddMonths(-1).Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.AddMonths(-1).Year.ToString  'ObtenerPrimerDia(fecha_tmp)
        udte_fec_fin.Value = "24/" & fecha_tmp.Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.Year.ToString 'ObtenerUltimoDia(fecha_tmp)
    End Sub

    Private Sub Cargar_Lista_personal()
        Dim miFuncion As New BL.HospitalBL.Funciones
        dt_Lista = miFuncion.get_Personal_Asistencial_Horas(gInt_IdEmpresa)
        dt_Lista.TableName = "Lista"
        dv_Lista.Table = dt_Lista
        ug_ListaPer.DataSource = dv_Lista
        miFuncion = Nothing
    End Sub

    Private Sub txt_Filtro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Filtro.ValueChanged

        If txt_Filtro.Text.Trim.Length = 0 Then
            dv_Lista.RowFilter = ""
            ug_ListaPer.Visible = False
            txt_codper.Text = ""
            txt_idper.Text = ""
            txt_Area.Text = ""
        Else
            dv_Lista.RowFilter = "nombres  like '" & txt_Filtro.Text.Trim & "%'"
            ug_ListaPer.Visible = True
        End If

    End Sub

    Private Sub txt_Filtro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Filtro.KeyDown

        If e.KeyCode = Keys.Down Then
            ug_ListaPer.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            If ug_ListaPer.Visible Then
                uds_ListaMarcaciones.Rows.Clear()
                ug_ListaMarcaciones.DataSource = uds_ListaMarcaciones

                txt_Filtro.Text = ug_ListaPer.ActiveRow.Cells("NOMBRES").Value
                txt_codper.Text = ug_ListaPer.ActiveRow.Cells("PE_CODIGO").Value
                txt_idper.Text = ug_ListaPer.ActiveRow.Cells("PE_ID").Value
                ug_ListaPer.Visible = False
                ume_tot_hor_ext.Value = 0
                ume_tot_horas.Value = 0
                txt_Filtro.Focus()
            Else
                Call Buscar_Area_Personal()
                Call Cargar_Data_Lista()
            End If

        End If

    End Sub

    Private Sub ug_ListaPer_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ListaPer.DoubleClickRow

        txt_Filtro.Text = ug_ListaPer.ActiveRow.Cells("NOMBRES").Value
        txt_codper.Text = ug_ListaPer.ActiveRow.Cells("PE_CODIGO").Value
        txt_idper.Text = ug_ListaPer.ActiveRow.Cells("PE_ID").Value
        ug_ListaPer.Visible = False

        If txt_idper.Text.Trim.Length > 0 Then
            Call Buscar_Area_Personal()
            Call Cargar_Data_Lista()
        End If

        txt_Filtro.Focus()
    End Sub

    Private Sub ug_ListaPer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_ListaPer.KeyDown
        If e.KeyCode = Keys.Up Then
            If ug_ListaPer.ActiveRow.Index = 0 Then
                txt_Filtro.Focus()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            txt_Filtro.Text = ug_ListaPer.ActiveRow.Cells("NOMBRES").Value
            txt_codper.Text = ug_ListaPer.ActiveRow.Cells("PE_CODIGO").Value
            txt_idper.Text = ug_ListaPer.ActiveRow.Cells("PE_ID").Value
            ug_ListaPer.Visible = False
            Call Buscar_Area_Personal()
            txt_Filtro.Focus()
        End If

    End Sub

    Private Sub ubtn_Mostrar_Data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Mostrar_Data.Click
        Call Cargar_Data_Lista()
    End Sub

    Private Sub Cargar_Data_Lista()

        If txt_idper.Text.Trim.Length = 0 Then
            MessageBox.Show("Seleccione un Trabajador")
            txt_Filtro.Focus()
            Exit Sub
        End If

        Dim marcacionesBL As New BL.HospitalBL.Funciones
        ug_ListaMarcaciones.DataSource = marcacionesBL.get_Lista_marcacion_x_Personal(txt_idper.Text, udte_fec_ini.Value, udte_fec_fin.Value)
        ls_ultFecha = marcacionesBL.get_UltimoDiaMarcacion(txt_idper.Text, txt_ayo.Text, uce_mes.Value)
        marcacionesBL = Nothing

        Call Mostrar_Total_Horas()

    End Sub

    Private Sub ug_ListaMarcaciones_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ListaMarcaciones.DoubleClickRow
        Tool_Modificar_Click(sender, e)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If MessageBox.Show("Seguro de Eliminar?", "Cuiado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim MarcacionBE As New BE.HospitalBE.SG_PL_TB_MARCA_ASIS

            With MarcacionBE

                .MA_IDPERSONAL = txt_idper.Text
                If ug_ListaMarcaciones.ActiveRow.Cells("MA_VACA_INI").Value.ToString.Length > 0 Then
                    .MA_FECHA = ug_ListaMarcaciones.ActiveRow.Cells("MA_VACA_INI").Value
                    .MA_IDSERVICIO = 2
                Else
                    .MA_FECHA = ug_ListaMarcaciones.ActiveRow.Cells("MA_FECHA").Value
                    .MA_IDSERVICIO = 1
                End If

                .MA_IDEMPRESA = gInt_IdEmpresa

            End With


            Dim marcasBL As New BL.HospitalBL.Funciones
            marcasBL.Delete_Marcacion_Diaria(MarcacionBE)
            marcasBL = Nothing

            MarcacionBE = Nothing
            MessageBox.Show("Listo!")
            Call Cargar_Data_Lista()
        End If

    End Sub

    Private Sub txt_Filtro_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Filtro.Enter
        txt_Filtro.SelectAll()
    End Sub

    Private Sub Mostrar_Total_Horas()

        Dim marcacionBL As New BL.HospitalBL.Funciones

        Dim ayo As Integer = txt_ayo.Text.Trim
        Dim mes As Integer = uce_mes.Value

        Dim lista_horas As List(Of String)
        lista_horas = marcacionBL.get_Suma_Total_Horas(txt_idper.Text, ayo, mes, gInt_IdEmpresa)

        ume_tot_horas.Value = lista_horas(0)
        ume_tot_hor_ext.Value = lista_horas(1)

        Dim cont_Refri As Integer = 0
        Dim cont_Feriado As Integer = 0

        For i As Integer = 0 To ug_ListaMarcaciones.Rows.Count - 1
            If ug_ListaMarcaciones.Rows(i).Cells("MA_ES_REFRI").Value = 1 Then
                cont_Refri += 1
            End If

            If ug_ListaMarcaciones.Rows(i).Cells("MA_ES_FERIADO").Value = 1 Then
                cont_Feriado += 1
            End If
        Next
        ume_tot_refri.Value = cont_Refri
        ume_tot_feriado.Value = cont_Feriado

        marcacionBL = Nothing

    End Sub

    Private Sub uce_mes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_mes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Filtro.Focus()
        End If
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        HO_PR_RegDiaPer.MdiParent = CO_MN_MenuInicial
        HO_PR_RegDiaPer.bol_edicion = False
        HO_PR_RegDiaPer.Show()
    End Sub


End Class