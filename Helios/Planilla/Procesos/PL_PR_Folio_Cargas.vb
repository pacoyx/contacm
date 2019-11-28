Public Class PL_PR_Folio_Cargas

    
    Public fecha_a As Date
    Public folio_destino As String

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click

        If uce_Folios_origen.SelectedIndex = -1 Then
            Avisar("Seleccione un folio")
            uce_Folios_origen.Focus()
            Exit Sub
        End If

        If une_porcentaje.Value = 0 Then
            Avisar("Ingrese un porcentaje mayor a cero")
            une_porcentaje.Focus()
            Exit Sub
        End If

        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        conceptoBL.Copiar_de_otro_Folio(CDate(udte_fecha.Value).Year, CDate(udte_fecha.Value).Month, fecha_a.Year, fecha_a.Month, uce_Folios_origen.Value, folio_destino, une_porcentaje.Value, gInt_IdEmpresa)
        conceptoBL = Nothing

        Call Avisar("Listo!")

        Me.Close()
    End Sub

    Private Sub PL_PR_Folio_Cargas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Folios()
        udte_fecha.Value = gDat_Fecha_Sis
        une_porcentaje.Value = 100

        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
        ubtn_previo.Appearance.Image = My.Resources._16__Db_previous_
        ubtn_siguiente.Appearance.Image = My.Resources._16__Db_next_

    End Sub

    Private Sub Cargar_Folios()
        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        uce_Folios_origen.DataSource = conceptoBL.get_Conceptos_Lista_Chica(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_Folios_origen.ValueMember = "CO_ID"
        uce_Folios_origen.DisplayMember = "CO_DESCRIPCION"
        conceptoBL = Nothing
    End Sub

    Private Sub ubtn_previo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_previo.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddMonths(-1)
    End Sub

    Private Sub ubtn_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_siguiente.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddMonths(1)
    End Sub

    Private Sub uce_Folios_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Folios_origen.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub une_porcentaje_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_porcentaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            If une_porcentaje.Value > 100 Then
                Avisar("El porcentaje no puede pasar de 100%")
            Else
                ubtn_Aceptar.Focus()
            End If
        End If
    End Sub

    Private Sub udte_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha.ValueChanged
        lbl_mensaje.Text = "La informacion del periodo " & Format(fecha_a, "MMMM  / yyyy") & " se eliminara"
    End Sub
End Class