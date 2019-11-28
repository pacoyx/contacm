Imports BE.ContabilidadBE
Imports Infragistics.Win.UltraWinGrid

Public Class CO_MT_Usuarios

    Dim Obj_Usu As New BL.ContabilidadBL.SG_CO_TB_USUARIO
    Dim Bol_Nuevo As Boolean

    Private Sub CO_MT_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Call CargarDatos()
        Call CargarDatosRapido()
        Call Cargar_Personal()
        Call Inicializar_Estado_Botones()
        Call Formatear_Grilla_Selector(ug_Lista_Usu)
        Call CargarCombos()
        Call MostrarTabs(2, utc_Usurios, 2)
    End Sub

    Private Sub Cargar_Personal()
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        uce_cod_per.DataSource = personalBL.getPersonal_Cmb_Login_02()
        uce_cod_per.DisplayMember = "NOMBRES"
        uce_cod_per.ValueMember = "PE_ID"
        personalBL = Nothing
    End Sub

    Private Sub CargarDatosRapido()
        ug_Lista_Rapida.DataSource = Obj_Usu.getUsuarios_dt
    End Sub

    Private Sub CargarDatos()
        Try
            Dim usuarios As New List(Of SG_CO_TB_USUARIO)
            Dim usuarioBE As SG_CO_TB_USUARIO
            usuarios = Obj_Usu.getUsuarios()

            Call LimpiaGrid(ug_Lista_Usu, uds_Lista_Usu)

            Dim i As Integer = 0
            For Each usuarioBE In usuarios
                ug_Lista_Usu.DisplayLayout.Bands(0).AddNew()
                ug_Lista_Usu.Rows(i).Cells("US_ID").Value = usuarioBE.US_ID
                ug_Lista_Usu.Rows(i).Cells("US_NOMBRE").Value = usuarioBE.US_NOMBRE
                ug_Lista_Usu.Rows(i).Cells("US_DESCRIPCION").Value = usuarioBE.US_DESCRIPCION
                ug_Lista_Usu.Rows(i).Cells("US_ISTATUS").Value = usuarioBE.US_ISTATUS
                ug_Lista_Usu.Rows(i).Cells("US_FOTO").Value = usuarioBE.US_FOTO
                ug_Lista_Usu.Rows(i).Cells("TU_DESCRIPCION").Value = usuarioBE.US_USUARIO
                ug_Lista_Usu.UpdateData()
                i += 1
            Next

            ug_Lista_Usu.DisplayLayout.Bands(0).Columns("US_FOTO").CellAppearance.ImageHAlign = Infragistics.Win.HAlign.Center

            Call MostrarTabs(0, utc_Usurios)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub CargarCombos()
        Dim obj_TipoUsu As New BL.ContabilidadBL.SG_CO_TB_TIPO_USUARIO
        uce_TipoUsu.DataSource = obj_TipoUsu.getTipos()
        uce_TipoUsu.DisplayMember = "TU_DESCRIPCION"
        uce_TipoUsu.ValueMember = "TU_CODIGO"
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones()
        Call MostrarTabs(1, utc_Usurios, 2)
        Call Limpiar_Controls_InGroupox(ugb_datos)
     
        Bol_Nuevo = True
        upb_img.Image = Nothing
        upb_img.Image = My.Resources.Desconocido
        uce_TipoUsu.SelectedIndex = 0
        txt_nombre.Enabled = True
        txt_nombre.Focus()

        
    End Sub

    Private Sub Inicializar_Estado_Botones()
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Editar.Enabled = True
        Tool_Salir.Enabled = True
        Tool_Eliminar.Enabled = True
    End Sub

    Private Sub Cambiar_Estado_Botones()
        Tool_Nuevo.Enabled = Not (Tool_Nuevo.Enabled)
        Tool_Grabar.Enabled = Not Tool_Grabar.Enabled
        Tool_Cancelar.Enabled = Not Tool_Cancelar.Enabled
        Tool_Editar.Enabled = Not Tool_Editar.Enabled
        Tool_Salir.Enabled = Not Tool_Salir.Enabled
        Tool_Eliminar.Enabled = Not Tool_Eliminar.Enabled
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click

        Call Cambiar_Estado_Botones()
        Call MostrarTabs(2, utc_Usurios, 2)
       
    End Sub

    Private Sub txt_nombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.Escape Then
            Tool_Cancelar_Click(sender, e)
        End If
    End Sub

    Private Sub txt_clave_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clave.KeyDown, txt_clave_web.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_des_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.Escape Then
            Tool_Cancelar_Click(sender, e)
        End If
    End Sub

    Private Sub uce_TipoUsu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoUsu.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uos_Estado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uos_Estado.KeyDown, uos_modo_acceso.KeyDown
        If e.KeyCode = Keys.Enter Then
            'grabamos
            If Preguntar("Desea Grabar los datos?") Then
                Tool_Grabar_Click(sender, e)
            End If
        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        ValidarDatos = False


        If txt_nombre.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar un nombre para la cuenta.")
            txt_nombre.Focus()
            Exit Function
        End If

        If txt_clave.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar una clave para la cuenta.")
            txt_clave.Focus()
            Exit Function
        End If

        Return True

    End Function

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If Not ValidarDatos() Then Exit Sub

        Dim E_Usuario As New SG_CO_TB_USUARIO

        With E_Usuario
            If Not Bol_Nuevo Then
                .US_ID = ug_Lista_Rapida.ActiveRow.Cells("US_ID").Value
            End If

            .US_NOMBRE = txt_nombre.Text.Trim
            .US_CLAVE = txt_clave.Text.Trim
            .US_DESCRIPCION = txt_des.Text.Trim
            .US_ISTATUS = uos_Estado.Value
            .US_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .US_TERMINAL = Environment.MachineName
            .US_FECREG = Date.Now
            .US_IDTIPO_USU = New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO With {.TU_CODIGO = uce_TipoUsu.Value}
            If upb_img.Image IsNot Nothing Then .US_FOTO = Image2Bytes(upb_img.Image)
            .US_TIPO_ACCESO = uos_modo_acceso.Value
            .US_IDPERSONAL = IIf(uce_cod_per.SelectedIndex = -1, 0, uce_cod_per.Value)
            .US_CLAVE_WEB = txt_clave_web.Text.Trim
            .US_ES_SUPER_FT = IIf(uchk_super_ft.Checked, 1, 0)
        End With


        If Bol_Nuevo Then
            Obj_Usu.Insert(E_Usuario)
        Else
            Obj_Usu.Update(E_Usuario)
        End If

        Avisar("    Listo!  ")

        Call CargarDatosRapido()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Lista_Rapida.ActiveRow.Cells("US_NOMBRE").Value.ToString.ToUpper = "ADMIN" Then
            Avisar("El usuario 'Admin' no se puede eliminar del sistema.")
            Exit Sub
        End If


        If Preguntar("Esta seguro que desea eliminar la cuenta?") Then

            Obj_Usu.Delete(New SG_CO_TB_USUARIO With {.US_ID = ug_Lista_Rapida.ActiveRow.Cells("US_ID").Value})

            Avisar("    Listo!      ")
            Call CargarDatos()
        End If

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Try

            Dim E_Usuario As New SG_CO_TB_USUARIO()

            If utc_Usurios.Tabs(0).Selected Then
                If ug_Lista_Usu.ActiveRow.Index = -1 Then Exit Sub
                E_Usuario.US_ID = ug_Lista_Usu.ActiveRow.Cells("US_ID").Value
            Else
                If ug_Lista_Rapida.ActiveRow.Index = -1 Then Exit Sub
                E_Usuario.US_ID = ug_Lista_Rapida.ActiveRow.Cells("US_ID").Value
            End If

            Obj_Usu.getUsuario(E_Usuario)

            Call Limpiar_Controls_InGroupox(ugb_datos)

            If E_Usuario.US_NOMBRE.Trim.Length > 0 Then
                With E_Usuario
                    txt_nombre.Text = .US_NOMBRE
                    txt_clave.Text = .US_CLAVE
                    txt_des.Text = .US_DESCRIPCION
                    uos_Estado.Value = .US_ISTATUS
                    uos_modo_acceso.Value = .US_TIPO_ACCESO
                    uce_TipoUsu.Value = .US_IDTIPO_USU.TU_CODIGO
                    uce_cod_per.Value = .US_IDPERSONAL
                    txt_clave_web.Text = .US_CLAVE_WEB
                    uchk_super_ft.Checked = IIf(.US_ES_SUPER_FT = 1, True, False)

                    upb_img.Image = Nothing
                    upb_img.Image = My.Resources.Desconocido

                    Try
                        upb_img.Image = Bytes2Image(.US_FOTO)
                    Catch ex As Exception
                    End Try

                End With
            End If

            Call MostrarTabs(1, utc_Usurios, 2)
            Call Cambiar_Estado_Botones()
            txt_nombre.Enabled = False
            txt_des.Focus()
            Bol_Nuevo = False

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ug_Lista_Usu_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista_Usu.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ug_Lista_Usu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Lista_Usu.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'Call CargarDatos_a_Editar()
                Call Tool_Editar_Click(sender, e)
            Case Keys.Up
                If ug_Lista_Usu.ActiveRow.Index = 0 Then
                    ug_Lista_Usu.Rows.FilterRow.Cells(0).Activate()
                    ug_Lista_Usu.PerformAction(UltraGridAction.EnterEditMode)
                    'SendKeys.Send("{TAB}")



                End If
            Case Keys.Down
                If ug_Lista_Usu.ActiveRow.Index = -1 Then
                    If ug_Lista_Usu.Rows.Count > 0 Then
                        ug_Lista_Usu.Rows(0).Activate()
                    End If
                End If
            Case Keys.Escape
                Dim band As Infragistics.Win.UltraWinGrid.UltraGridBand
                For Each band In Me.ug_Lista_Usu.DisplayLayout.Bands
                    band.ColumnFilters.ClearAllFilters()
                Next

        End Select
    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click

        ' Seleccionar la imagen
        Dim oFD As New OpenFileDialog
        oFD.Title = "Selecccionar la imagen"
        oFD.Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp"
        If oFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' La cantidad de caracteres máximo
            ' (por si el path es demasiado largo)
            Dim i As Integer = 255 'dt.Columns("Nombre").MaxLength
            If i < 0 Then i = 255
            ' El nombre del fichero
            ' Nos quedamos solo con el nombre, sin el path
            Dim sNombre As String = System.IO.Path.GetFileName(oFD.FileName)
            If sNombre.Length > i Then
                ' Si el nombre es más grande de lo permitido, lo cortamos
                sNombre = sNombre.Substring(0, i)
            End If

            'Me.txt_foto.Text = sNombre
            Me.upb_img.Image = Image.FromFile(oFD.FileName)
        End If

    End Sub

    Private Sub ubtn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Quitar.Click

        upb_img.Image = Nothing
        upb_img.Image = My.Resources.Desconocido

        
    End Sub

    Private Sub uos_modo_acceso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_modo_acceso.ValueChanged
        If uos_modo_acceso.Value = 2 Then
            uce_TipoUsu.Enabled = True
        Else
            uce_TipoUsu.Enabled = False
            uce_TipoUsu.Value = 0
        End If
    End Sub

    Private Sub uce_cod_per_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_cod_per.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.Delete Then
            uce_cod_per.SelectedIndex = -1
        End If
    End Sub

    Private Sub btn_vista_img_Click(sender As System.Object, e As System.EventArgs)
        Call MostrarTabs(1, utc_Usurios, 1)
    End Sub

    Private Sub btn_vista_rapida_Click(sender As System.Object, e As System.EventArgs)
        Call MostrarTabs(2, utc_Usurios, 2)
    End Sub
End Class