Public Class FE_RE_Cuentas

    Private obr As BL.FertilidadBL.SG_FA_Reportes
    Public Sub New()
        InitializeComponent()
        obr = New BL.FertilidadBL.SG_FA_Reportes
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub utxt_idCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles utxt_idCuenta.GotFocus

    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles utxt_idCuenta.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub Inicializa()
        Call LimpiaGrid(ug_detalle, uds_detalle)

        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Limpiar_Controls_InGroupox(ugb_Cuenta)

        uchk_GenerarCta.Checked = False
        utxt_idCuenta.Text = ""
    End Sub

    Private Sub FE_RE_Cuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obr = New BL.FertilidadBL.SG_FA_Reportes
        ubtn_BuscarP.Appearance.Image = My.Resources._104
        Me.KeyPreview = True

        Inicializa()

    End Sub

   
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obr = Nothing
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Inicializa()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub utxt_idCuenta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles utxt_idCuenta.Leave
      
        Dim ds_Cuenta As New DataSet
        ds_Cuenta = obr.get_Fertilidad_BusqCuenta(Val(utxt_idCuenta.Value))
        Call LimpiaGrid(ug_detalle, uds_detalle)
        ' Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Limpiar_Controls_InGroupox(ugb_Cuenta)

        If ds_Cuenta.Tables(0).Rows.Count > 0 Then
            With ds_Cuenta.Tables(0)

                utxt_idCuenta.Text = .Rows(0)("cuenta")
                txt_Paciente.Text = .Rows(0)("paciente")
                txt_idHistoria.Text = .Rows(0)("cf_codpac")

                Dim obj As New DataTable
                obr.get_Fertilidad_CuentaDetalle(Val(utxt_idCuenta.Value), 2, obj)
                ug_detalle.DataSource = obj

                Dim ds_Deuda As New DataSet
                ds_Deuda = obr.get_Fertilidad_Deudas(Val(utxt_idCuenta.Value), 2)
                If ds_Deuda.Tables(0).Rows.Count > 0 Then
                    With ds_Deuda.Tables(0)
                        txtDebe.Text = .Rows(0)("Debe")
                        udt_Fecha1.Value = .Rows(0)("Fecha1")
                        udt_Fecha2.Value = .Rows(0)("Fecha2")
                    End With
                Else
                    txtDebe.Text = 0
                    udt_Fecha1.Value = Nothing
                    udt_Fecha2.Value = Nothing
                    Avisar("La Congelacion a sido Descongelada")
                End If
            End With
        Else
            Avisar("Cuenta no Existe...")
        End If

    End Sub

    Private Sub Busqueda_Paciente()
        'FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FE_RE_BuscarPacienteC.ShowDialog()

        Dim matriz As List(Of String) = FE_RE_BuscarPacienteC.GetLista

        If matriz.Count > 0 Then
            uchk_GenerarCta.Checked = False
            utxt_idCuenta.Enabled = False

            txt_idHistoria.Text = matriz(0)
            utxt_idCuenta.Value = matriz(1)
            txt_Paciente.Value = matriz(2)

            If txt_idHistoria.Text.Trim = "" Then
                Avisar("El paciente no tiene Historia Clinica en el sistema, puede que ser que la informacion que vea no sea correcta")
            End If


            Dim obj As New DataTable
            obr.get_Fertilidad_CuentaDetalle(Val(txt_idHistoria.Text), 1, obj)
            ug_detalle.DataSource = obj

            Dim ds_Deuda As New DataSet
            ds_Deuda = obr.get_Fertilidad_Deudas(Val(txt_idHistoria.Text), 1)
            If ds_Deuda.Tables(0).Rows.Count > 0 Then
                With ds_Deuda.Tables(0)
                    txtDebe.Text = .Rows(0)("Debe")
                    udt_Fecha1.Value = .Rows(0)("Fecha1")
                    udt_Fecha2.Value = .Rows(0)("Fecha2")
                End With
            Else
                txtDebe.Text = 0
                udt_Fecha1.Value = Nothing
                udt_Fecha2.Value = Nothing
                Avisar("La Congelacion a sido Descongelada")
            End If
        End If

    End Sub

    Private Sub ug_detalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ug_detalle.DoubleClick
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        utxt_Cuenta.Value = ug_detalle.ActiveRow.Cells(0).Value
        utxt_Glosa.Value = ug_detalle.ActiveRow.Cells(1).Value
        utxt_Tipo.Value = ug_detalle.ActiveRow.Cells(2).Value
        utxt_Monto.Value = ug_detalle.ActiveRow.Cells(3).Value
        txt_Fecha.Value = ug_detalle.ActiveRow.Cells(4).Value
        utxt_Obs.Value = ug_detalle.ActiveRow.Cells(5).Value
    End Sub

    Private Sub ubtn_BuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_BuscarP.Click
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Limpiar_Controls_InGroupox(ugb_Cuenta)
        Call Busqueda_Paciente()
    End Sub

    Private Sub uchk_GenerarCta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_GenerarCta.CheckedChanged
        If uchk_GenerarCta.Checked = True Then
            Call LimpiaGrid(ug_detalle, uds_detalle)
            'Call Limpiar_Controls_InGroupox(ugb_Datos)
            txt_Paciente.Text = ""
            txt_idHistoria.Text = ""
            txtDebe.Text = ""
            udt_Fecha1.Value = ""
            udt_Fecha2.Value = Nothing
            utxt_idCuenta.Text = ""
            Call Limpiar_Controls_InGroupox(ugb_Cuenta)
            utxt_idCuenta.Enabled = True
        Else
            utxt_idCuenta.Enabled = False
        End If
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataSet
        If uchk_GenerarCta.Checked = True Then
            obr.get_Fertilidad_CuentaCrystl(Val(utxt_idCuenta.Value), 2, obj)
            obr.get_Fertilidad_CuentaDetalleCrystl(Val(utxt_idCuenta.Value), 2, obj)
        Else
            obr.get_Fertilidad_CuentaCrystl(Val(txt_idHistoria.Text), 1, obj)
            obr.get_Fertilidad_CuentaDetalleCrystl(Val(txt_idHistoria.Text), 1, obj)
        End If

        Dim nom_reporte As String = "SG_FE_01.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataSet
        dt_data = obj

        crystalBL.Muestra_Reporte_dataset(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pPaciente;" & txt_Paciente.Text)


        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

 
End Class