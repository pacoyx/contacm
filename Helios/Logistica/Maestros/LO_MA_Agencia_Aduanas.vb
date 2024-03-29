﻿Public Class LO_MA_Agencia_Aduanas
    Dim boton As Boolean = False
    Private Sub LO_MA_Agencia_Aduanas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_aa)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_aa)
        Call limpiar_controles()
        txt_cod.Enabled = True
        txt_cod.Focus()
        boton = True
    End Sub
    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
        txt_dir.Text = ""
        If rb_ac.Checked = False Then
            rb_ac.Checked = True
        End If
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_des.Text = "" Or txt_dir.Text = "" Then
            MsgBox("Falta completar")
            Exit Sub
        End If
        Dim aaBL As New BL.LogisticaBL.SG_LO_TB_AGENCIA_ADUANAS
        Dim aaBE As New BE.LogisticaBE.SG_LO_TB_AGENCIA_ADUANAS
        If boton = True Then
            If aaBL.get_aaval(gInt_IdEmpresa, txt_cod.Text).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With aaBE
            .id = txt_cod.Text
            .descripcion = txt_des.Text
            .direccion = txt_dir.Text
            If rb_ac.Checked = True Then
                .estado = 1
            Else
                .estado = 0
            End If
            .empresa = gInt_IdEmpresa
        End With
        If boton = True Then
            aaBL.insert(aaBE)
        Else
            aaBL.update(aaBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_aa)
        aaBE = Nothing
        aaBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim aaBL As New BL.LogisticaBL.SG_LO_TB_AGENCIA_ADUANAS
        Dim aaBE As New BE.LogisticaBE.SG_LO_TB_AGENCIA_ADUANAS
        ug_aa.DataSource = aaBL.get_aagrilla(gInt_IdEmpresa)
        ug_aa.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        ug_aa.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        ug_aa.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Direccion"
        ug_aa.DisplayLayout.Bands(0).Columns(3).Hidden = True
        ug_aa.DisplayLayout.Bands(0).Columns(4).Hidden = True
        aaBE = Nothing
        aaBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_aa.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = ug_aa.ActiveRow.Cells(0).Value
            txt_des.Text = ug_aa.ActiveRow.Cells(1).Value
            txt_dir.Text = ug_aa.ActiveRow.Cells(2).Value
            If ug_aa.ActiveRow.Cells(3).Value = 1 Then
                rb_ac.Checked = True
            Else
                rb_inac.Checked = True
            End If
            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_aa)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_aa)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_aa.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim aaBL As New BL.LogisticaBL.SG_LO_TB_AGENCIA_ADUANAS
            Dim aaBE As New BE.LogisticaBE.SG_LO_TB_AGENCIA_ADUANAS
            aaBE.id = ug_aa.ActiveRow.Cells("AA_ID").Value
            aaBE.empresa = gInt_IdEmpresa
            aaBL.delete(aaBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_aa)
            aaBE = Nothing
            aaBL = Nothing
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

End Class