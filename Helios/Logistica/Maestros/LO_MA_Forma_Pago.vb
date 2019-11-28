Public Class LO_MA_Forma_Pago
    Dim boton As Boolean = False
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_num_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod.KeyPress, txt_dia.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub LO_MA_Forma_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_forma_pago)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_forma_pago)
        Call limpiar_controles()
        txt_cod.Enabled = False
        Dim fpBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PAGO
        txt_cod.Text = fpBL.get_Ult_cod_forma_pago(gInt_IdEmpresa)
        fpBL = Nothing
        txt_des.Focus()
        boton = True
    End Sub
    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
        txt_dia.Text = ""
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_des.Text = "" Or txt_dia.Text = "" Then
            MsgBox("Falta completar")
            Exit Sub
        End If
        Dim fpBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PAGO
        Dim fpBE As New BE.LogisticaBE.SG_LO_TB_FORMA_PAGO
        If boton = True Then
            If fpBL.get_fpvali(gInt_IdEmpresa, Val(txt_cod.Text)).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With fpBE
            .id = Val(txt_cod.Text)
            .descripcion = txt_des.Text
            .dia = Val(txt_dia.Text)
            .empresa = gInt_IdEmpresa
        End With
        If boton = True Then
            fpBL.insert(fpBE)
        Else
            fpBL.update(fpBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_forma_pago)
        fpBE = Nothing
        fpBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim fpBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PAGO
        Dim fpBE As New BE.LogisticaBE.SG_LO_TB_FORMA_PAGO
        udg_tipo_fp.DataSource = fpBL.get_fpgrilla(gInt_IdEmpresa)
        udg_tipo_fp.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        udg_tipo_fp.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        udg_tipo_fp.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Dias"
        udg_tipo_fp.DisplayLayout.Bands(0).Columns(3).Hidden = True
        fpBE = Nothing
        fpBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udg_tipo_fp.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = udg_tipo_fp.ActiveRow.Cells(0).Value
            txt_des.Text = udg_tipo_fp.ActiveRow.Cells(1).Value
            txt_dia.Text = udg_tipo_fp.ActiveRow.Cells(2).Value
            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_forma_pago)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_forma_pago)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udg_tipo_fp.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim fpBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PAGO
            Dim fpBE As New BE.LogisticaBE.SG_LO_TB_FORMA_PAGO
            fpBE.id = udg_tipo_fp.ActiveRow.Cells("FP_ID").Value
            fpBE.empresa = gInt_IdEmpresa
            fpBL.delete(fpBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_forma_pago)
            fpBE = Nothing
            fpBL = Nothing
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

End Class