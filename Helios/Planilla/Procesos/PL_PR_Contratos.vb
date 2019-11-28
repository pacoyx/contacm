Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core


Public Class PL_PR_Contratos

    Dim bol_nuevo As Boolean = False

    Private Sub PL_PR_Contratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Lista_Personal_Contratos()
        Call Cargar_Tipo_Contrato()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Formatear_Grilla_Selector(ug_Detalle)
        Call MostrarTabs(0, utc_contrato, 0)

        Tool_Nuevo.Enabled = True
        Tool_Editar.Enabled = False
        Tool_Eliminar.Enabled = False
        Tool_Cancelar.Enabled = False

        ubtn_Generar_Contrato.Enabled = False

        ug_Lista.Visible = True
        ug_Detalle.Visible = False
        ubtn_atraz.Enabled = False

        txt_cod_personal.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubtn_Generar_Contrato.Appearance.Image = My.Resources._16__Doc_word_
        ubtn_atraz.Appearance.Image = My.Resources._16__Back_
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_contrato, 1)

        Call Limpiar_Controls_InGroupox(ugb_detalle)
        Call Limpiar_Controls_InGroupox_Nativo(gb1)

        If lbl_titulo.Text.Trim.Length > 3 Then
            txt_id_personal.Text = ug_Lista.ActiveRow.Cells("PE_ID").Value
            txt_cod_personal.Text = ug_Lista.ActiveRow.Cells("PE_CODIGO").Value
            txt_nombres.Text = ug_Lista.ActiveRow.Cells("APELLIDOS_NOMBRES").Value
        End If

        bol_nuevo = True
        une_id.Value = 0
        txt_cod_personal.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
        Dim contratoBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS

        With contratoBE
            .CO_ID = Val(une_id.Value)
            .CO_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_id_personal.Text.Trim}
            .CO_ID_TIPO_CONTRATO = New BE.PlanillaBE.SG_PL_TB_TIPO_CONTRATO With {.TC_ID = uce_tipoContrato.Value}
            .CO_FECHA_INI = udte_fec_ini.Value
            .CO_FECHA_FIN = udte_fec_ter.Value
            .CO_COMENTARIO = txt_comentario.Text.Trim
            .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CO_TERMINAL = Environment.MachineName
            .CO_FECREG = Date.Now
        End With

        If bol_nuevo Then
            contratoBL.Insert(contratoBE)
            Call Cargar_Contratos_Personal(txt_id_personal.Text.Trim)
            Call MostrarTabs(0, utc_contrato, 0)
        Else
            contratoBL.Update(contratoBE)
            Call Cargar_Contratos_Personal(txt_id_personal.Text.Trim)
            Call MostrarTabs(0, utc_contrato, 0)
        End If

        contratoBE = Nothing
        contratoBL = Nothing
        Call Tool_Cancelar_Click(sender, e)
        Call Avisar("Listo!")



    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Detalle.Rows.Count = 0 Then Exit Sub


        txt_id_personal.Text = ug_Lista.ActiveRow.Cells("PE_ID").Value
        txt_cod_personal.Text = ug_Lista.ActiveRow.Cells("PE_CODIGO").Value
        txt_nombres.Text = ug_Lista.ActiveRow.Cells("APELLIDOS_NOMBRES").Value

        une_id.Value = ug_Detalle.ActiveRow.Cells("CO_ID").Value
        uce_tipoContrato.Value = ug_Detalle.ActiveRow.Cells("CO_ID_TIPO_CONTRATO").Value
        udte_fec_ini.Value = ug_Detalle.ActiveRow.Cells("CO_FECHA_INI").Value
        udte_fec_ter.Value = ug_Detalle.ActiveRow.Cells("CO_FECHA_FIN").Value
        txt_comentario.Text = ug_Detalle.ActiveRow.Cells("CO_COMENTARIO").Value.ToString

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_contrato, 1)

        bol_nuevo = False

        uce_tipoContrato.Focus()


    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_contrato, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        ug_Detalle.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If Not Preguntar("Seguro de eliminar") Then
            Exit Sub
        End If

        Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
        Dim contratoBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS
        contratoBE.CO_ID = ug_Detalle.ActiveRow.Cells("CO_ID").Value
        contratoBL.Delete(contratoBE)
        contratoBL = Nothing

        Call Mostrar_Contratos_x_Personal()

    End Sub

    Private Sub Tool_Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Reporte.Click

    End Sub


    Private Sub Cargar_Lista_Personal_Contratos()
        Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
        ug_Lista.DataSource = contratoBL.get_Lista_Personal_Contrato(gInt_IdEmpresa)
        contratoBL = Nothing
    End Sub

    Private Sub Cargar_Contratos_Personal(ByVal IdPersonal As Integer)
        Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personalBE.PE_ID = IdPersonal
        Dim dt_contrato As DataTable = contratoBL.get_Contratos_x_IdPersonal(personalBE)

        Call LimpiaGrid(ug_Detalle, uds_Detalle)
        For i As Integer = 0 To dt_contrato.Rows.Count - 1
            ug_Detalle.DisplayLayout.Bands(0).AddNew()
            ug_Detalle.Rows(i).Cells("CO_ID").Value = dt_contrato.Rows(i)("CO_ID")
            ug_Detalle.Rows(i).Cells("CO_ID_TIPO_CONTRATO").Value = dt_contrato.Rows(i)("CO_ID_TIPO_CONTRATO")
            ug_Detalle.Rows(i).Cells("CO_FECHA_INI").Value = dt_contrato.Rows(i)("CO_FECHA_INI")
            ug_Detalle.Rows(i).Cells("CO_FECHA_FIN").Value = dt_contrato.Rows(i)("CO_FECHA_FIN")
            ug_Detalle.Rows(i).Cells("CO_COMENTARIO").Value = dt_contrato.Rows(i)("CO_COMENTARIO")
            ug_Detalle.Rows(i).Cells("ITEM").Value = i + 1
        Next

        ug_Detalle.UpdateData()

        If ug_Detalle.Rows.Count > 0 Then
            ug_Detalle.Rows(0).Activate()
        End If





        personalBE = Nothing
        contratoBL = Nothing
    End Sub

    Private Sub ubtn_Generar_Contrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Generar_Contrato.Click
        'Dim WordApp As New Word.ApplicationClass
        'Dim WordDoc As Word.Document
        'Dim Ruta As String = (gStr_RutaRep & "\Contrato_modelo_1.doc")
        'WordDoc = WordApp.Documents.Open(Ruta)

        'Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
        'Dim personaBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = ug_Lista.ActiveRow.Cells("PE_ID").Value}
        'Dim dt_datos As DataTable = contratoBL.get_Data_Generar_Contrato(personaBE)

        'If dt_datos.Rows.Count > 0 Then

        '    WordApp.Selection.GoTo(Name:="m_cargo")
        '    WordApp.Selection.TypeText(dt_datos.Rows(0)("CARGO"))

        '    WordApp.Selection.GoTo(Name:="m_dni")
        '    WordApp.Selection.TypeText(dt_datos.Rows(0)("DNI"))

        '    WordApp.Selection.GoTo(Name:="m_empresa")
        '    WordApp.Selection.TypeText(dt_datos.Rows(0)("EMPRESA"))

        '    WordApp.Selection.GoTo(Name:="m_estado_civil")
        '    WordApp.Selection.TypeText(dt_datos.Rows(0)("EST_CIVIL"))

        '    WordApp.Selection.GoTo(Name:="m_personal")
        '    WordApp.Selection.TypeText(dt_datos.Rows(0)("NOMBRE"))

        '    WordApp.Selection.GoTo(Name:="m_sueldo")
        '    WordApp.Selection.TypeText(dt_datos.Rows(0)("REMUNERACION"))

        '    WordDoc.SaveAs(Application.StartupPath & "\Contrato_modelo_1.doc")
        '    WordDoc.Close()

        '    Process.Start(Application.StartupPath & "\Contrato_modelo_1.doc")

        'End If

        'dt_datos.Dispose()

    End Sub

    Private Sub ug_Lista_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Mostrar_Contratos_x_Personal()

        ubtn_Generar_Contrato.Enabled = True
        ug_Detalle.Visible = True
        ug_Lista.Visible = False
        ubtn_atraz.Enabled = True
        lbl_titulo.Text = "Contratos de: " & ug_Lista.ActiveRow.Cells("APELLIDOS_NOMBRES").Value

        ug_Detalle.Focus()
    End Sub

    Private Sub Mostrar_Contratos_x_Personal()
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        Dim idpersonal As Integer = ug_Lista.ActiveRow.Cells("PE_ID").Value
        Call Cargar_Contratos_Personal(idpersonal)
    End Sub

    Private Sub Cargar_Tipo_Contrato()
        Dim tipoContratoBL As New BL.PlanillaBL.SG_PL_TB_TIPO_CONTRATO
        uce_tipoContrato.DataSource = tipoContratoBL.get_Tipos
        uce_tipoContrato.DisplayMember = "TC_DESCRIPCION"
        uce_tipoContrato.ValueMember = "TC_ID"


        Call CrearComboGrid("CO_ID_TIPO_CONTRATO", "TC_DESCRIPCION", ug_Detalle, tipoContratoBL.get_Tipos, True)

        tipoContratoBL = Nothing
    End Sub

    Private Sub ug_Detalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Detalle.KeyDown
        If e.KeyCode = Keys.Escape Then
            ug_Detalle.Visible = False
            ug_Lista.Visible = True

            Tool_Nuevo.Enabled = True
            Tool_Editar.Enabled = False
            Tool_Eliminar.Enabled = False
            Tool_Cancelar.Enabled = False
            ubtn_atraz.Enabled = False
            lbl_titulo.Text = ""

            ubtn_Generar_Contrato.Enabled = False

        End If
    End Sub

    Private Sub ug_Lista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_Lista.InitializeLayout
        e.Layout.Bands(0).ColHeaderLines = 2
    End Sub

    Private Sub txt_cod_personal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_personal.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Mostrar_Ayuda_Empleado()
        End If

        If e.KeyCode = Keys.Enter Then
            uce_tipoContrato.Focus()
        End If
    End Sub

    Private Sub Mostrar_Ayuda_Empleado()

        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
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

    Private Sub txt_cod_personal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_personal.Leave
        If txt_cod_personal.Text.Trim = String.Empty Then Exit Sub

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personalBE.PE_CODIGO = txt_cod_personal.Text.Trim
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBL.getPersonal_x_Codigo(personalBE)

        If personalBE.PE_ID = 0 Then
            Call Avisar("El codigo no existe")
            txt_nombres.Text = String.Empty
            txt_id_personal.Text = String.Empty
        Else
            txt_nombres.Text = personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG
            txt_id_personal.Text = personalBE.PE_ID
        End If

        personalBE = Nothing
        personalBL = Nothing

    End Sub

    Private Sub uce_tipoContrato_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_tipoContrato.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_fec_ini.Focus()
        End If
    End Sub

    Private Sub udte_fec_ini_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_ini.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_fec_ter.Focus()
        End If
    End Sub

    Private Sub udte_fec_ter_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_ter.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_comentario.Focus()
        End If
    End Sub

    Private Sub txt_cod_personal_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_personal.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub ubtn_atraz_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_atraz.Click
        ug_Detalle.Visible = False
        ug_Lista.Visible = True

        Tool_Nuevo.Enabled = True
        Tool_Editar.Enabled = False
        Tool_Eliminar.Enabled = False
        Tool_Cancelar.Enabled = False

        lbl_titulo.Text = ""
        ubtn_atraz.Enabled = False
        ubtn_Generar_Contrato.Enabled = False
    End Sub
End Class