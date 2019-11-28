Public Class LO_MA_Articulos
    Dim Bol_Nuevo As Boolean = False
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub LO_MA_Articulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Articulos()
        Call Cargar_UMs()
        Call Cargar_Marca()
        Call Cargar_Fabricante()
        Call Cargar_Paises()
        Call Cargar_Ubicaciones()
        Call Cargar_Grupos()
        Call Cargar_Proveedores()
        Call Cargar_Monedas()

        Dim familiaBL As New BL.FacturacionBL.SG_FA_TB_FAMILIA_ARTI
        uce_Familia.DataSource = familiaBL.get_Familias_Combo(gInt_IdEmpresa)
        uce_Familia.DisplayMember = "FA_DESCRIPCION"
        uce_Familia.ValueMember = "FA_CODIGO"
        familiaBL = Nothing

        Dim GenericoBL As New BL.LogisticaBL.SG_LO_TB_GENERICO
        uce_Generico.DataSource = GenericoBL.SEL01(gInt_IdEmpresa)
        uce_Generico.DisplayMember = "GE_DESCRIPCION"
        uce_Generico.ValueMember = "GE_ID"
        GenericoBL = Nothing

        Dim FormaPBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PRESENTACION
        ucb_Forma_Presentacion.DataSource = FormaPBL.SEL01(gInt_IdEmpresa)
        ucb_Forma_Presentacion.DisplayMember = "FP_NOMBRE"
        ucb_Forma_Presentacion.ValueMember = "FP_ID"
        FormaPBL = Nothing

        Dim FormaFBL As New BL.LogisticaBL.SG_LO_TB_FORMA_FARMACEUTICA
        ucb_Forma_Farma.DataSource = FormaFBL.SEL01(gInt_IdEmpresa)
        ucb_Forma_Farma.DisplayMember = "FF_NOMBRE"
        ucb_Forma_Farma.ValueMember = "FF_ID"
        FormaFBL = Nothing

        Me.KeyPreview = True
        Call MostrarTabs(0, utc_articulos, 0)
    End Sub

    Private Sub uce_Familia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Familia.ValueChanged

        Dim categoriaBL As New BL.FacturacionBL.SG_FA_TB_CATEGORIA_ARTI
        Dim familiaBE As New BE.FacturacionBE.SG_FA_TB_FAMILIA_ARTI

        familiaBE.FA_CODIGO = uce_Familia.Value
        familiaBE.FA_IDEMPRESA = gInt_IdEmpresa

        uce_Categoria.DataSource = categoriaBL.get_Categorias_x_Familia(familiaBE)
        uce_Categoria.DisplayMember = "CA_DESCRIPCION"
        uce_Categoria.ValueMember = "CA_CODIGO"

        familiaBE = Nothing
        categoriaBL = Nothing

    End Sub

    Private Sub Cargar_Articulos()
        Dim articulosBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        ug_Lista.DataSource = articulosBL.get_Articulos(gInt_IdEmpresa)
        articulosBL = Nothing
    End Sub

    Private Sub Cargar_Proveedores()
        Dim proveedoresBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
        uce_proveedor.DataSource = proveedoresBL.get_Proveedores_cmb(gInt_IdEmpresa)
        uce_proveedor.DisplayMember = "PR_DESCRIPCION"
        uce_proveedor.ValueMember = "PR_ID"
        proveedoresBL = Nothing
    End Sub

    Private Sub Cargar_UMs()
        Dim uniMedBL As New BL.LogisticaBL.SG_LO_TB_UNI_MED

        uce_um_compra.DataSource = uniMedBL.getMedidas(gInt_IdEmpresa)
        uce_um_compra.DisplayMember = "UM_DESCRIPCION"
        uce_um_compra.ValueMember = "UM_ID"

        uce_um_venta.DataSource = uniMedBL.getMedidas(gInt_IdEmpresa)
        uce_um_venta.DisplayMember = "UM_DESCRIPCION"
        uce_um_venta.ValueMember = "UM_ID"

        uce_um_distri.DataSource = uniMedBL.getMedidas(gInt_IdEmpresa)
        uce_um_distri.DisplayMember = "UM_DESCRIPCION"
        uce_um_distri.ValueMember = "UM_ID"

        uce_um_peso.DataSource = uniMedBL.getMedidas(gInt_IdEmpresa)
        uce_um_peso.DisplayMember = "UM_DESCRIPCION"
        uce_um_peso.ValueMember = "UM_ID"

        uniMedBL = Nothing

    End Sub

    Private Sub Cargar_Marca()
        Dim marcaBL As New BL.LogisticaBL.SG_LO_TB_MARCA
        uce_marca.DataSource = marcaBL.getMarcas(gInt_IdEmpresa)
        uce_marca.DisplayMember = "MA_DESCRIPCION"
        uce_marca.ValueMember = "MA_ID"
        marcaBL = Nothing
    End Sub

    Private Sub Cargar_Fabricante()
        Dim fabriBL As New BL.LogisticaBL.SG_LO_TB_FABRICANTE
        uce_fabricante.DataSource = fabriBL.getFabricantes(gInt_IdEmpresa)
        uce_fabricante.DisplayMember = "FA_DESCRIPCION"
        uce_fabricante.ValueMember = "FA_ID"
        fabriBL = Nothing
    End Sub

    Private Sub Cargar_Paises()
        Dim paisBL As New BL.LogisticaBL.SG_LO_TB_PAIS
        uce_pais.DataSource = paisBL.getPaises(gInt_IdEmpresa)
        uce_pais.ValueMember = "PA_ID"
        uce_pais.DisplayMember = "PA_DESCRIPCION"
        paisBL = Nothing

    End Sub

    Private Sub Cargar_Ubicaciones()
        Dim ubiBL As New BL.LogisticaBL.SG_LO_TB_UBICACION_ART
        uce_Ubicaciones.DataSource = ubiBL.getUbicaciones(gInt_IdEmpresa)
        uce_Ubicaciones.DisplayMember = "UA_DESCRIPCION"
        uce_Ubicaciones.ValueMember = "UA_ID"
        ubiBL = Nothing
    End Sub

    Private Sub Cargar_Grupos()
        Dim grupoBL As New BL.LogisticaBL.SG_LO_TB_GRUPO_ARTICULO
        uce_GrupoArt.DataSource = grupoBL.getGrupos(gInt_IdEmpresa)
        uce_GrupoArt.DisplayMember = "GA_DESCRIPCION"
        uce_GrupoArt.ValueMember = "GA_ID"
        grupoBL = Nothing
    End Sub

    Private Sub Cargar_Monedas()
        Dim monedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA

        uce_moneda.DataSource = monedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_moneda.DisplayMember = "MO_ABREVIATURA"
        uce_moneda.ValueMember = "MO_ID"

        monedaBL = Nothing

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_datos1)
        Call MostrarTabs(1, utc_articulos, 2)
        utc_articulos.Tabs(3).Enabled = True
        Call LimpiaGrid(ug_Imgs, uds_imgs)
        upb_img.Image = Nothing
        Bol_Nuevo = True
        une_stock_min.Value = 0
        ume_peso.Value = 0
        ume_cant_um_compra.Value = 0
        uce_tipo_arti.SelectedIndex = 0
        uce_um_compra.SelectedIndex = 0
        uce_um_venta.SelectedIndex = 0
        uce_um_distri.SelectedIndex = 0
        uce_um_peso.SelectedIndex = 0
        uce_pais.SelectedIndex = 0
        txt_cod_alt.Focus()
        uce_Familia.SelectedIndex = 0
        uchk_incluyeIgv.Checked = True
        Dim origenBL As New BL.LogisticaBL.SG_LO_TB_ORIGEN
        ug_Origen.DataSource = origenBL.SEL02(0, gInt_IdEmpresa)
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub Obtener_Ult_Codigo_Articulo()

        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        txt_codigo.Text = articuloBL.get_Codigo_Articulo_Nuevo(gInt_IdEmpresa, uce_tipo_arti.Value)
        articuloBL = Nothing

    End Sub
    Private Function fValida() As Boolean
        pLostfocus(txt_descripcion, Nothing)
        pLostfocus(uce_GrupoArt, Nothing)

        uce_proveedor.BackColor = Color.White
        If uce_proveedor.Text <> "" And uce_proveedor.SelectedIndex = -1 Then
            uce_proveedor.BackColor = Color.LightPink
        End If
        uce_marca.BackColor = Color.White
        If uce_marca.Text <> "" And uce_marca.SelectedIndex = -1 Then
            uce_marca.BackColor = Color.LightPink
        End If
        uce_fabricante.BackColor = Color.White
        If uce_fabricante.Text <> "" And uce_fabricante.SelectedIndex = -1 Then
            uce_fabricante.BackColor = Color.LightPink
        End If

        If uce_GrupoArt.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_descripcion.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_proveedor.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_marca.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_fabricante.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        If txt_cta_conta.Text.Trim.Length > 0 Then
            lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
        End If
        If Val(ume_cant_um_compra.Value) <= 0 Then
            Avisar("La Cantidad de conversion no es correcta")
            Exit Sub
        End If


        'validamos
        If Not Bol_Nuevo Then
            If txt_codigo.Text.Trim = "" Then
                Avisar("El codigo no puede estar vacio")
                Exit Sub
            End If
        End If

        'Cargamos datos y grabamos
        Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        Dim articuloBE As New BE.LogisticaBE.SG_LO_TB_ARTICULO

        With articuloBE
            .AR_ID = Val(utxt_ID.Text.Trim)
            .AR_CODIGO = txt_codigo.Text.Trim
            .AR_CODIGO_ALT = txt_cod_alt.Text.Trim
            .AR_DESCRIPCION = txt_descripcion.Text.Trim
            .AR_PRECIO_VENTA = uce_PrecioVta.Value
            .AR_IDFAMILIA = uce_Familia.Value
            If uce_Familia.SelectedIndex = -1 Then .AR_IDFAMILIA = String.Empty
            .AR_IDCATEGORIA = uce_Categoria.Value
            If uce_Categoria.SelectedIndex = -1 Then .AR_IDCATEGORIA = String.Empty
            .AR_NUM_CTA_CONTA = txt_cta_conta.Text.Trim

            .AR_ESTADO = uos_Estado.Value
            .AR_IDEMPRESA = gInt_IdEmpresa
            .AR_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AR_TERMINAL = Environment.MachineName
            .AR_FECREG = Now
            .AR_TIPO_ARTI = uce_tipo_arti.Value
            .AR_INCLUYE_IGV = IIf(uchk_incluyeIgv.Checked, 1, 0)
            .AR_ING_RAP = IIf(uchk_ing_rap.Checked, 1, 0)
            .AR_MON_VTA = uce_moneda.Value
            .AR_CTRL_STOCK = uos_stock.Value


            .AR_IDPROVEEDOR = uce_proveedor.Value
            If uce_proveedor.SelectedIndex = -1 Then .AR_IDPROVEEDOR = 0
            .AR_IDGRUPO = uce_GrupoArt.Value
            If uce_GrupoArt.SelectedIndex = -1 Then .AR_IDGRUPO = 0
            .AR_IDUBICACION = uce_Ubicaciones.Value
            If uce_Ubicaciones.SelectedIndex = -1 Then .AR_IDUBICACION = 0
            .AR_IDPAIS = uce_pais.Value
            If uce_pais.SelectedIndex = -1 Then .AR_IDPAIS = 0
            .AR_IDFABRICANTE = uce_fabricante.Value
            If uce_fabricante.SelectedIndex = -1 Then .AR_IDFABRICANTE = 0
            .AR_MODELO = txt_modelo.Text.Trim
            .AR_MARCA = uce_marca.Value
            If uce_marca.SelectedIndex = -1 Then .AR_MARCA = 0
            .AR_UM_COMPRA = uce_um_compra.Value
            If uce_um_compra.SelectedIndex = -1 Then .AR_UM_COMPRA = String.Empty
            .AR_UM_VENTA = uce_um_venta.Value
            If uce_um_venta.SelectedIndex = -1 Then .AR_UM_VENTA = String.Empty
            .AR_UM_DISTRI = uce_um_distri.Value
            If uce_um_distri.SelectedIndex = -1 Then .AR_UM_DISTRI = String.Empty
            .AR_CANT_UMC = ume_cant_um_compra.Value
            .AR_COLOR = ucp_color_Arti.Value.ToString
            .AR_PESO = ume_peso.Value
            .AR_UM_PESO = uce_um_peso.Value
            If uce_um_peso.SelectedIndex = -1 Then .AR_UM_PESO = String.Empty
            .AR_STOCK_MIN = une_stock_min.Value

            .AR_PRECIO_COMPRA = uce_PrecioCompra.Value

            .AR_ORIGEN = IIf(ucb_Origen.SelectedIndex = -1, String.Empty, ucb_Origen.Value)
            .AR_IDGENERICO = IIf(uce_Generico.SelectedIndex = -1, 0, uce_Generico.Value)

            .AR_CUM = utxt_CUM.Text
            .AR_ATC = utxt_ATC.Text

            .AR_TIPO_MED = IIf(ucb_TipoMedicamento.SelectedIndex = -1, String.Empty, ucb_TipoMedicamento.Value)
            .AR_IDFORMA_F = IIf(ucb_Forma_Farma.SelectedIndex = -1, 0, ucb_Forma_Farma.Value)
            .AR_IDFORMA_P = IIf(ucb_Forma_Presentacion.SelectedIndex = -1, 0, ucb_Forma_Presentacion.Value)
            .AR_SIN_IGV = IIf(uchk_AfectoIGV.Checked, 1, 0)

        End With

        Dim ls_lista_img As New List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO_IMG)
        Dim ent_img As BE.LogisticaBE.SG_LO_TB_ARTICULO_IMG

        For i As Integer = 0 To ug_Imgs.Rows.Count - 1
            ent_img = New BE.LogisticaBE.SG_LO_TB_ARTICULO_IMG
            ent_img.AI_IDARTICULO = IIf(Bol_Nuevo, 0, articuloBE.AR_ID)
            ent_img.AI_ITEM = ug_Imgs.Rows(i).Cells("Item").Value
            ent_img.AI_DESCRIPCION = ug_Imgs.Rows(i).Cells("Descripcion").Value
            ent_img.AI_IMG = Image2Bytes(ug_Imgs.Rows(i).Cells("Img").Value)
            ls_lista_img.Add(ent_img)
        Next

        Dim ls_lista_ori As New List(Of BE.LogisticaBE.SG_LO_TB_ORIGEN)
        Dim ent_ori As BE.LogisticaBE.SG_LO_TB_ORIGEN

        ug_Origen.UpdateData()

        For i As Integer = 0 To ug_Origen.Rows.Count - 1
            If ug_Origen.Rows(i).Cells(2).Value = True Then
                ent_ori = New BE.LogisticaBE.SG_LO_TB_ORIGEN
                ent_ori.OR_ID = ug_Origen.Rows(i).Cells(0).Value
                ls_lista_ori.Add(ent_ori)
            End If
        Next

        Try
            If Bol_Nuevo Then
                articuloBL.Insert(articuloBE, ls_lista_img, ls_lista_ori)
            Else
                articuloBL.Update(articuloBE, ls_lista_img, ls_lista_ori)
            End If

        Catch ex As Exception
            Avisar("Error : " & ex.Message)
            articuloBE = Nothing
            articuloBL = Nothing
            Exit Sub
        End Try

        articuloBE = Nothing
        articuloBL = Nothing

        Call Cargar_Articulos()
        Call Avisar("Listo!")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_datos1)
        Call Limpiar_Controls_InGroupox(ugb_datos2)
        Call LimpiaGrid(ug_Imgs, uds_imgs)

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        Dim dt_tmp As DataTable = articuloBL.get_Articulos_x_id(ug_Lista.ActiveRow.Cells("AR_ID").Value, gInt_IdEmpresa)

        If dt_tmp.Rows.Count > 0 Then
            With dt_tmp
                utxt_ID.Text = ug_Lista.ActiveRow.Cells("AR_ID").Value
                uce_tipo_arti.Value = .Rows(0)("AR_TIPO_ARTI")
                txt_codigo.Text = .Rows(0)("AR_CODIGO")
                txt_cod_alt.Text = .Rows(0)("AR_CODIGO_ALT")
                txt_descripcion.Text = .Rows(0)("AR_DESCRIPCION")
                uce_PrecioVta.Value = .Rows(0)("AR_PRECIO_VENTA")
                uce_Familia.Value = .Rows(0)("AR_IDFAMILIA")
                uce_Categoria.Value = .Rows(0)("AR_IDCATEGORIA")
                txt_cta_conta.Text = .Rows(0)("AR_NUM_CTA_CONTA")
                If txt_cta_conta.Text.Trim.Length > 0 Then
                    lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
                Else
                    lbl_des_cta.Text = ""
                End If
                uos_Estado.Value = .Rows(0)("AR_ESTADO")
                uchk_incluyeIgv.Checked = IIf(.Rows(0)("AR_INCLUYE_IGV") = 1, True, False)
                uchk_ing_rap.Checked = IIf(.Rows(0)("AR_ING_RAP") = 1, True, False)
                uce_moneda.Value = .Rows(0)("AR_MON_VTA")
                uce_proveedor.Value = .Rows(0)("AR_IDPROVEEDOR")
                uce_GrupoArt.Value = .Rows(0)("AR_IDGRUPO")
                uce_Ubicaciones.Value = .Rows(0)("AR_IDUBICACION")
                uce_pais.Value = .Rows(0)("AR_IDPAIS")
                uce_fabricante.Value = .Rows(0)("AR_IDFABRICANTE")
                txt_modelo.Text = .Rows(0)("AR_MODELO").ToString
                uce_marca.Value = .Rows(0)("AR_MARCA")
                uce_um_compra.Value = .Rows(0)("AR_UM_COMPRA")
                uce_um_venta.Value = .Rows(0)("AR_UM_VENTA")
                uce_um_distri.Value = .Rows(0)("AR_UM_DISTRI")
                uce_um_peso.Value = .Rows(0)("AR_UM_PESO")
                ume_cant_um_compra.Value = .Rows(0)("AR_CANT_UMC")
                ucp_color_Arti.Value = .Rows(0)("AR_COLOR")
                ume_peso.Value = .Rows(0)("AR_PESO")
                une_stock_min.Value = .Rows(0)("AR_STOCK_MIN")
                uos_stock.Value = .Rows(0)("AR_CTRL_STOCK")

                ucb_Origen.Value = .Rows(0)("AR_ORIGEN")
                uce_Generico.Value = .Rows(0)("AR_IDGENERICO")
                utxt_CUM.Value = .Rows(0)("AR_CUM")
                utxt_ATC.Value = .Rows(0)("AR_ATC")
                ucb_TipoMedicamento.Value = .Rows(0)("AR_TIPO_MED")
                ucb_Forma_Farma.Value = .Rows(0)("AR_IDFORMA_F")
                ucb_Forma_Presentacion.Value = .Rows(0)("AR_IDFORMA_P")
                uchk_AfectoIGV.Checked = IIf(.Rows(0)("AR_SIN_IGV") = 1, True, False)
                uce_PrecioCompra.Value = Val(.Rows(0)("AR_PRECIO_COMPRA").ToString)

                Dim articulosBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
                Dim sss As DataTable
                sss = articulosBL.get_Articulos_IMG(ug_Lista.ActiveRow.Cells("AR_ID").Value)
                For x As Integer = 0 To sss.Rows.Count - 1


                    Dim valor As Byte() = CType(sss.Rows(x)(2), Byte())
                    Dim Memoria As New IO.MemoryStream(valor)
                    Dim mapabit As New Bitmap(Memoria)

                    ug_Imgs.DisplayLayout.Bands(0).AddNew()
                    ug_Imgs.Rows(ug_Imgs.Rows.Count - 1).Cells("item").Value = sss.Rows(x)(0)
                    ug_Imgs.Rows(ug_Imgs.Rows.Count - 1).Cells("descripcion").Value = sss.Rows(x)(1)
                    ug_Imgs.Rows(ug_Imgs.Rows.Count - 1).Cells("img").Value = mapabit
                    ug_Imgs.Update()
                Next

                Dim origenBL As New BL.LogisticaBL.SG_LO_TB_ORIGEN
                ug_Origen.DataSource = origenBL.SEL02(Val(utxt_ID.Text), gInt_IdEmpresa)

            End With
        End If
        dt_tmp.Dispose()
        articuloBL = Nothing

        Call MostrarTabs(1, utc_articulos, 2)
        utc_articulos.Tabs(3).Enabled = True
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        Bol_Nuevo = False
        txt_descripcion.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_articulos, 0)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_datos1)
        Call Limpiar_Controls_InGroupox(ugb_datos2)
        Call LimpiaGrid(ug_Imgs, uds_imgs)
        upb_img.Image = Nothing
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If Preguntar("seguro de eliminar?") Then

            Dim articuloBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO
            Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

            articuloBE.AR_ID = ug_Lista.ActiveRow.Cells("AR_ID").Value
            articuloBE.AR_IDEMPRESA = gInt_IdEmpresa

            articuloBL.Delete(articuloBE)

            articuloBL = Nothing
            articuloBE = Nothing

            'If ug_Lista.Rows.Count = 0 Then Exit Sub
            'If ug_Lista.ActiveRow Is Nothing Then Exit Sub

            ug_Lista.ActiveRow.Delete()
            'Cargar_Articulos()

            Call Avisar("Listo")

        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click

        Dim oFD As New OpenFileDialog
        oFD.Title = "Selecccionar la imagen"
        oFD.Filter = "(Archivos jpg)*.jpg|*.jpg"
        If oFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim i As Integer = 255
            If i < 0 Then i = 255
            ' El nombre del fichero Nos quedamos solo con el nombre, sin el path
            Dim sNombre As String = System.IO.Path.GetFileName(oFD.FileName)
            If sNombre.Length > i Then sNombre = sNombre.Substring(0, i) ' Si el nombre es más grande de lo permitido, lo cortamos
            Dim tam As Integer
            Dim archivo As IO.FileStream
            archivo = New IO.FileStream(oFD.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            tam = archivo.Length
            Dim imagen(tam) As Byte
            archivo.Read(imagen, 0, tam)
            archivo.Close()


            ug_Imgs.DisplayLayout.Bands(0).AddNew()
            ug_Imgs.Rows(ug_Imgs.Rows.Count - 1).Cells("item").Value = ug_Imgs.Rows.Count
            ug_Imgs.Rows(ug_Imgs.Rows.Count - 1).Cells("descripcion").Value = sNombre
            ug_Imgs.Rows(ug_Imgs.Rows.Count - 1).Cells("img").Value = imagen
            ug_Imgs.Update()

        End If
    End Sub

    Private Sub ubtn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_quitar.Click
        If ug_Imgs.Rows.Count = 0 Then Exit Sub
        If ug_Imgs.ActiveRow Is Nothing Then Exit Sub

        ug_Imgs.ActiveRow.Delete()

        For i As Integer = 0 To ug_Imgs.Rows.Count - 1
            ug_Imgs.Rows(i).Cells("Item").Value = i + 1
        Next
        ug_Imgs.UpdateData()

    End Sub

    Private Sub ug_Lista_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Lista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False
    End Sub

    Private Sub ug_Lista_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ug_Imgs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ug_Imgs.Click
        If ug_Imgs.Rows.Count = 0 Then Exit Sub
        If ug_Imgs.ActiveRow Is Nothing Then Exit Sub

        upb_img.Image = ug_Imgs.ActiveRow.Cells("img").Value
    End Sub

    Private Sub ug_Imgs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Imgs.KeyDown
        If ug_Imgs.Rows.Count = 0 Then Exit Sub
        If ug_Imgs.ActiveRow Is Nothing Then Exit Sub
        upb_img.Image = ug_Imgs.ActiveRow.Cells("img").Value
    End Sub

    Private Sub uce_tipo_arti_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_tipo_arti.ValueChanged
        Call Obtener_Ult_Codigo_Articulo()
    End Sub
    Private Sub txt_cta_conta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cta_conta.Leave
        lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
    End Sub
End Class