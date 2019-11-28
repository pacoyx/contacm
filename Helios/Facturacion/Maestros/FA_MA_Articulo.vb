Public Class FA_MA_Articulo
    Dim Bol_Nuevo As Boolean = False
    Private obe As BE.FacturacionBE.SG_FA_TB_TARIFA_MEDICA
    Private obr As BL.FacturacionBL.SG_FA_TB_TARIFA_MEDICA
    Private obeT As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU
    Private obrT As BL.FacturacionBL.SG_FA_TB_ARTI_SEGU
    Public IGVTas As Double

    Public Sub New()
        InitializeComponent()
        obe = New BE.FacturacionBE.SG_FA_TB_TARIFA_MEDICA
        obr = New BL.FacturacionBL.SG_FA_TB_TARIFA_MEDICA

        obeT = New BE.FacturacionBE.SG_FA_TB_ARTI_SEGU
        obrT = New BL.FacturacionBL.SG_FA_TB_ARTI_SEGU
    End Sub

    Private Sub pKeyPressNumeroDec(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Unidad.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = Date.Now.Year
        impuestoBE.IM_MES = Date.Now.Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTas = impuestoBE.IM_TASA

        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub

    Private Sub FA_MA_Articulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call CargarDatos()
        Call Cargar_Combos()
        Call Cargar_Monedas()
        Call Cargar_Tipo_Articulo()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_TipoAne, 0)
        utc_TipoAne.Tabs(2).Enabled = False

        Cargar_Tasas_Impuestos()

        obe = New BE.FacturacionBE.SG_FA_TB_TARIFA_MEDICA
        obr = New BL.FacturacionBL.SG_FA_TB_TARIFA_MEDICA
        obeT = New BE.FacturacionBE.SG_FA_TB_ARTI_SEGU
        obrT = New BL.FacturacionBL.SG_FA_TB_ARTI_SEGU

    End Sub

    Private Sub CargarDatos()
        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        ug_Lista.DataSource = articuloBL.get_Articulos_FA(gInt_IdEmpresa)
        articuloBL = Nothing
    End Sub


    Private Sub Cargar_Combos()

        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_FAMILIA_ARTI
        uce_Familia.DataSource = familiaBL.get_Familias_Combo(gInt_IdEmpresa)
        uce_Familia.DisplayMember = "FA_DESCRIPCION"
        uce_Familia.ValueMember = "FA_CODIGO"
        familiaBL = Nothing

    End Sub

    Private Sub Cargar_Tipo_Articulo()

        Dim tipoArtBL As New BL.FacturacionBL.SG_FA_TB_TIPO_ARTICULO
        uce_tipo.DataSource = tipoArtBL.getTipos(gInt_IdEmpresa)
        uce_tipo.DisplayMember = "TA_DESCRIPCION"
        uce_tipo.ValueMember = "TA_ID"

        tipoArtBL = Nothing
    End Sub

    Private Sub Cargar_Monedas()
        Dim monedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA

        uce_moneda.DataSource = monedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_moneda.DisplayMember = "MO_ABREVIATURA"
        uce_moneda.ValueMember = "MO_ID"

        monedaBL = Nothing

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 2)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        Bol_Nuevo = True

        lbl_des_cta.Text = ""
        txt_codigo.Enabled = True
        uce_tipo.Enabled = True

        txt_codigo.Text = ""
        uce_PrecioVta.Value = 0
        uce_tipo.Value = "S"
        uce_moneda.SelectedIndex = 0
        uce_Familia.SelectedIndex = 0

        Call Obtener_Ult_Codigo_Articulo()

        Dim obj As New DataTable
        obe.TM_IDARTICULO = 0
        obr.SEL01(obe, obj)
        ug_intervalos.DataSource = obj

       
        Dim obj1 As New DataTable
        obeT.AS_IDEMPRESA = gInt_IdEmpresa
        obeT.AS_IDARTICULO = 0
        obrT.SEL01(obeT, obj1)
        ug_detalle.DataSource = obj1

        txt_codigo.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_cta_conta.Text.Trim.Length > 0 Then
            lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
        End If


        If txt_codigo.Text.Trim.Length = 0 Then
            Avisar("Ingrese el codigo")
            txt_codigo.Focus()
            Exit Sub
        End If


        If txt_descripcion.Text.Trim.Length = 0 Then
            Avisar("Ingrese la descripcion")
            txt_descripcion.Focus()
            Exit Sub
        End If

        If txt_cta_conta.Text.Length > 0 Then
            If lbl_des_cta.Text.StartsWith("*") Then
                Avisar("La cuenta no existe, ingrese una cuenta valida.")
                txt_cta_conta.Focus()
                Exit Sub
            End If
        End If

        Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO
        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

        With articuloBE
            .AR_ID = Val(txt_idArticulo.Text)
            .AR_CODIGO = txt_codigo.Text.Trim
            .AR_CODIGO_ALT = txt_cod_alt.Text.Trim
            .AR_DESCRIPCION = txt_descripcion.Text
            .AR_PRECIO_VENTA = uce_PrecioVta.Value
            .AR_IDFAMILIA = uce_Familia.Value
            .AR_IDCATEGORIA = uce_Categoria.Value
            .AR_NUM_CTA_CONTA = txt_cta_conta.Text.Trim
            .AR_ESTADO = uos_Estado.Value
            .AR_IDEMPRESA = gInt_IdEmpresa
            .AR_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AR_TERMINAL = Environment.MachineName
            .AR_FECREG = Now.Date
            .AR_TIPO_ARTI = uce_tipo.Value
            .AR_INCLUYE_IGV = IIf(uchk_incluyeIgv.Checked, 1, 0)
            .AR_ING_RAP = IIf(uchk_ing_rap.Checked, 1, 0)
            .AR_MON_VTA = uce_moneda.Value
            .AR_CTRL_STOCK = uos_stock.Value
            .AR_ORIGEN = ""
            .AR_FACTOR = IIf(uchk_Factor.Checked, 1, 0)
            .AR_UNIDAD = Val(txt_Unidad.Text)
        End With


        If Bol_Nuevo Then
            obe.TM_IDARTICULO = articuloBL.Insert(articuloBE)
            obeT.AS_IDARTICULO = obe.TM_IDARTICULO
        Else

            articuloBL.Update(articuloBE)

            obe.TM_IDARTICULO = Val(txt_idArticulo.Text)
            obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            obeT.AS_IDARTICULO = Val(txt_idArticulo.Text)
            obeT.AS_IDEMPRESA = gInt_IdEmpresa
            obrT.Delete(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        End If

        ug_intervalos.UpdateData()
        ug_detalle.UpdateData()
        For f As Integer = 0 To ug_intervalos.Rows.Count - 1

            If ug_intervalos.Rows(f).Cells("Sel").Value Then
                obe.TM_IDMEDICO = ug_intervalos.Rows(f).Cells(1).Value
                obe.TM_IDEMPRESA = ug_intervalos.Rows(f).Cells(3).Value
                obe.TM_PRECIO = ug_intervalos.Rows(f).Cells(4).Value

                obr.Insert(obe, IGVTas, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            End If
        Next

        obeT.AS_IDEMPRESA = gInt_IdEmpresa
        For f As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(f).Cells("Sel").Value Then
                obeT.AS_IDSEGURO = ug_detalle.Rows(f).Cells(1).Value
                obeT.AS_IMPORTE = IIf(ug_detalle.Rows(f).Cells(3).Value.ToString = "", 0.0, ug_detalle.Rows(f).Cells(3).Value)
                obrT.Insert(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            End If
        Next


        articuloBE = Nothing
        articuloBL = Nothing

        Call CargarDatos()
        Call Avisar("Listo")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(0, utc_TipoAne, 0)
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        Call Limpiar_Controls_InGroupox(ugb_datos)

        txt_descripcion.Text = ug_Lista.ActiveRow.Cells("AR_DESCRIPCION").Value
        uce_PrecioVta.Value = ug_Lista.ActiveRow.Cells("AR_PRECIO_VENTA").Value
        uce_Familia.Value = ug_Lista.ActiveRow.Cells("AR_IDFAMILIA").Value
        txt_cta_conta.Text = ug_Lista.ActiveRow.Cells("AR_NUM_CTA_CONTA").Value.ToString

        uce_moneda.Value = ug_Lista.ActiveRow.Cells("AR_MON_VTA").Value.ToString
        uos_stock.Value = ug_Lista.ActiveRow.Cells("AR_CTRL_STOCK").Value

        If txt_cta_conta.Text.Trim.Length > 0 Then
            lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
        Else
            lbl_des_cta.Text = ""
        End If

        uos_Estado.Value = IIf(ug_Lista.ActiveRow.Cells("AR_ESTADO").Value, 1, 0)

        uce_tipo.Value = ug_Lista.ActiveRow.Cells("AR_TIPO_ARTI").Value
        uce_Categoria.Value = ug_Lista.ActiveRow.Cells("AR_IDCATEGORIA").Value
        uchk_incluyeIgv.Checked = IIf(ug_Lista.ActiveRow.Cells("AR_INCLUYE_IGV").Value = 1, True, False)
        uchk_ing_rap.Checked = IIf(ug_Lista.ActiveRow.Cells("AR_ING_RAP").Value = 1, True, False)

        If ug_Lista.ActiveRow.Cells("AR_FACTOR").Value = 1 Then
            uchk_Factor.Checked = True
            txt_Unidad.Text = ug_Lista.ActiveRow.Cells("AR_UNIDAD").Value
            txt_Unidad.Enabled = True
        Else
            uchk_Factor.Checked = False
            txt_Unidad.Text = ""
            txt_Unidad.Enabled = False
        End If


        txt_codigo.Text = ug_Lista.ActiveRow.Cells("AR_CODIGO").Value
        txt_cod_alt.Text = ug_Lista.ActiveRow.Cells("AR_CODIGO_ALT").Value

        txt_idArticulo.Text = ug_Lista.ActiveRow.Cells("AR_ID").Value

        Bol_Nuevo = False
        ' txt_codigo.Enabled = False
        uce_tipo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_TipoAne, 1)

        If uce_Familia.Value = "050" Then
            utc_TipoAne.Tabs(2).Enabled = True
        Else
            utc_TipoAne.Tabs(2).Enabled = False
        End If

        Dim obj As New DataTable
        obe.TM_IDARTICULO = Val(txt_idArticulo.Text)
        obr.SEL01(obe, obj)
        ug_intervalos.DataSource = obj

        Dim obj1 As New DataTable
        obeT.AS_IDEMPRESA = gInt_IdEmpresa
        obeT.AS_IDARTICULO = Val(txt_idArticulo.Text)
        obrT.SEL01(obeT, obj1)
        ug_detalle.DataSource = obj1


        txt_descripcion.Focus()


    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If Preguntar("seguro de eliminar?") Then
            obe.TM_IDARTICULO = ug_Lista.ActiveRow.Cells("AR_ID").Value
            obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO
            Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

            articuloBE.AR_ID = ug_Lista.ActiveRow.Cells("AR_ID").Value
            articuloBE.AR_IDEMPRESA = gInt_IdEmpresa

            articuloBL.Delete(articuloBE)

            articuloBL = Nothing
            articuloBE = Nothing

            Call CargarDatos()

            Call Avisar("Listo")

        End If

    End Sub

    Private Sub txt_codigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cod_alt.Focus()
        End If
    End Sub

    Private Sub ug_Lista_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub uce_Familia_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Familia.ValueChanged

        Dim categoriaBL As New BL.FacturacionBL.SG_FA_TB_CATEGORIA_ARTI
        Dim familiaBE As New BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI

        familiaBE.FA_CODIGO = uce_Familia.Value
        familiaBE.FA_IDEMPRESA = gInt_IdEmpresa

        uce_Categoria.DataSource = categoriaBL.get_Categorias_x_Familia(familiaBE)
        uce_Categoria.DisplayMember = "CA_DESCRIPCION"
        uce_Categoria.ValueMember = "CA_CODIGO"

        familiaBE = Nothing
        categoriaBL = Nothing

        If uce_Familia.Value = "050" Then
            utc_TipoAne.Tabs(2).Enabled = True
        Else
            utc_TipoAne.Tabs(2).Enabled = False
        End If

    End Sub

    Private Sub txt_codigo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_codigo.ValueChanged
        txt_cod_alt.Text = txt_codigo.Text
    End Sub

    Private Sub txt_cod_alt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_alt.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_descripcion.Focus()
        End If
    End Sub

    Private Sub txt_descripcion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_descripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_PrecioVta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_PrecioVta.KeyDown
        If e.KeyCode = Keys.Enter Then uce_Familia.Focus()
    End Sub

    Private Sub uce_Categoria_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Categoria.KeyDown
        If e.KeyCode = Keys.Enter Then txt_cta_conta.Focus()
    End Sub


    Private Sub uchk_ing_rap_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_ing_rap.CheckedChanged

        'If uchk_ing_rap.Checked Then

        '    Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        '    Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO
        '    articuloBE.AR_CODIGO = txt_codigo.Text
        '    articuloBE.AR_IDEMPRESA = gInt_IdEmpresa

        '    If articuloBL.Existe_Arti_Ingreso_Rap(articuloBE) Then
        '        Call Avisar("ya existe un articulo con la opcion de 'Ingreso Rapido'")
        '        uchk_ing_rap.Checked = False
        '    End If

        '    articuloBE = Nothing
        '    articuloBL = Nothing

        'End If
    End Sub

    Private Sub txt_cta_conta_Leave(sender As System.Object, e As System.EventArgs) Handles txt_cta_conta.Leave
        lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
    End Sub

    Private Sub Obtener_Ult_Codigo_Articulo()

        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        txt_codigo.Text = articuloBL.get_Codigo_Articulo_Nuevo(gInt_IdEmpresa, uce_tipo.Value)
        articuloBL = Nothing

    End Sub

    Private Sub uce_Familia_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uce_tipo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_tipo.ValueChanged

        If Bol_Nuevo Then
            Call Obtener_Ult_Codigo_Articulo()
        End If

    End Sub

    Private Sub uce_moneda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ug_Lista_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Lista.InitializeRow
        If e.Row.Cells("AR_ESTADO").Value = False Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub uchk_Factor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Factor.CheckedChanged
        If uchk_Factor.Checked = True Then
            txt_Unidad.Enabled = True
        Else
            txt_Unidad.Text = ""
            txt_Unidad.Enabled = False
        End If
    End Sub

End Class