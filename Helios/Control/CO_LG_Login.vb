Imports System.Threading

Public Class CO_LG_Login

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        Try

            If udte_fecha.Value Is Nothing Then
                Avisar("Ingrese la fecha de trabajo")
                udte_fecha.Focus()
                Exit Sub
            End If

            'verificamos que el periodo no este cerrado
            Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
            If AdmMesBL.Es_Periodo_Cerrado(CDate(udte_fecha.Value).Year, gInt_IdEmpresa) Then
                Avisar("El año de ingreso esta cerrado, intente con periodo")
                udte_fecha.Focus()
                AdmMesBL = Nothing
                Exit Sub
            End If
            AdmMesBL = Nothing

            Call Loguear_Usuario(txt_Usuario.Text.Trim, txt_Contra.Text.Trim)

            'Dim UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            'Dim UsuarioBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO
            'Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO_EMPRESA

            'UsuarioBE.US_CLAVE = txt_Contra.Text.Trim
            'UsuarioBE.US_NOMBRE = txt_Usuario.Text.Trim
            'EmpresaBE.UE_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            'If UsuarioBL.Validar_Usuario_Sistema(UsuarioBE, EmpresaBE) Then
            '    gDat_Fecha_Sis = CDate(udte_fecha.Value)
            '    gStr_Usuario_Sis = txt_Usuario.Text.Trim
            '    gInt_IdUsuario_Sis = UsuarioBE.US_ID

            '    Call Grabar_Log_Ingreso()
            '    Call Setear_BarraEstado()
            '    Call Actualizar_Tipo_Cambio_delDia()

            '    'CO_MN_MenuPrincipal.Show()
            '    CO_MT_TCamb_Web.Close()
            '    CO_MN_MenuInicial.Text = "Sistema Integrado - " & ugb_login.Text
            '    CO_MN_MenuInicial.Show()
            '    Me.Hide()
            'Else
            '    Avisar("Usuario y/o Contraseña incorrecta")
            '    txt_Usuario.Focus()
            'End If


        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub


    Private Sub Loguear_Usuario(usuario_ As String, passsword_ As String)

        Dim UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        Dim UsuarioBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO
        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO_EMPRESA

        UsuarioBE.US_CLAVE = passsword_
        UsuarioBE.US_NOMBRE = usuario_
        EmpresaBE.UE_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If UsuarioBL.Validar_Usuario_Sistema(UsuarioBE, EmpresaBE) Then
            gDat_Fecha_Sis = CDate(udte_fecha.Value)
            gStr_Usuario_Sis = usuario_
            gInt_IdUsuario_Sis = UsuarioBE.US_ID

            Call Grabar_Log_Ingreso()
            Call Setear_BarraEstado()
            Call Actualizar_Tipo_Cambio_delDia()

            'CO_MN_MenuPrincipal.Show()
            CO_MT_TCamb_Web.Close()
            CO_MN_MenuInicial.Text = "Sistema Integrado - " & ugb_login.Text
            CO_MN_MenuInicial.Show()
            Me.Hide()
        Else
            Avisar("Usuario y/o Contraseña incorrecta")
            txt_Usuario.Focus()
        End If

        UsuarioBL = Nothing
        UsuarioBE = Nothing
        EmpresaBE = Nothing

    End Sub

    Private Sub Setear_BarraEstado()
        Try
            Dim Datos As New BL.ClsBD

            With CO_MN_MenuPrincipal_Pru.usb_menu
                .Panels("usb_usuario").Text = String.Format("Usuario : {0}", gStr_Usuario_Sis)
                .Panels("usb_fecha").Text = String.Format("Fecha : {0}", CDate(udte_fecha.Value).ToShortDateString)
                .Panels("usb_servidor").Text = String.Format("Servidor : {0}", Datos.Str_Servidor)
                .Panels("usb_BD").Text = String.Format("BD : {0}", Datos.Str_Base)
                .Panels("usb_Rep").Text = String.Format("Rep : {0}", Datos.Str_Reportes)
                gStr_RutaRep = Datos.Str_Reportes
            End With


            With CO_MN_MenuInicial.usb_menu
                .Panels("usb_usuario").Text = String.Format("Usuario : {0}", gStr_Usuario_Sis)
                .Panels("usb_fecha").Text = String.Format("Fecha : {0}", CDate(udte_fecha.Value).ToShortDateString)
                .Panels("usb_servidor").Text = String.Format("Servidor : {0}", Datos.Str_Servidor)
                .Panels("usb_BD").Text = String.Format("BD : {0}", Datos.Str_Base)
                .Panels("usb_Rep").Text = String.Format("Rep : {0}", Datos.Str_Reportes)
                gStr_RutaRep = Datos.Str_Reportes
            End With

            Datos = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Grabar_Log_Ingreso()
        Try

            Dim ip As System.Net.IPHostEntry
            ip = Net.Dns.GetHostEntry(My.Computer.Name)

            Dim valorIp As String

            valorIp = ""

            For Each valor As Net.IPAddress In ip.AddressList
                valorIp = valor.ToString()
            Next



            Dim LogBL As New BL.ContabilidadBL.SG_CO_TB_LOG_SIS
            Dim LogBE As New BE.ContabilidadBE.SG_CO_TB_LOG_SIS

            With LogBE
                .LS_USU_DOM = Environment.UserName
                .LS_USU_SIS = gStr_Usuario_Sis
                .LS_TERMINAL = Environment.MachineName
                .LS_MODULO = 2 'Contabilidad
                .LS_FEC_ING = Date.Now
                .LS_IP = valorIp
            End With

            gInt_IdLog = LogBL.Insert(LogBE)

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        End
    End Sub

    Private Sub txt_Usuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Usuario.KeyDown
        If e.KeyCode = Keys.Enter Then

            'buscamos el login por empresa

            Dim Hilo_tmp As New Thread(AddressOf Hilo_Cargar_ImagenLogin)
            Hilo_tmp.IsBackground = True
            Hilo_tmp.Start()

            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub Hilo_Cargar_ImagenLogin()

        upb_login.Image = My.Resources.Desconocido

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        Dim usuarioBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO

        Try
            usuarioBE = usuarioBL.getUsuarios_x_Login(txt_Usuario.Text.Trim)
            If usuarioBE.US_FOTO Is Nothing Then
                upb_login.Image = My.Resources.Desconocido
            Else
                upb_login.Image = Bytes2Image(usuarioBE.US_FOTO)
            End If

            usuarioBE = Nothing
            usuarioBL = Nothing

        Catch ex As Exception
            upb_login.Image = My.Resources.Desconocido
            usuarioBE = Nothing
            usuarioBL = Nothing

        End Try
    End Sub

    Private Sub txt_Contra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Contra.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub udte_fecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub CO_LG_Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


        Dim Datos As New BL.ClsBD
        If Datos.Str_lgn = "2" Then 'login de personal asistencial
            If Datos.Str_usu_def <> "" Then
                Call Loguear_Usuario(Datos.Str_usu_def, Datos.Str_usu_def)
            End If
            Datos = Nothing
            ubtn_regresar.Visible = False
            txt_Usuario.Focus()
        Else
            ubtn_regresar.Visible = True
            txt_Usuario.Focus()
        End If

    End Sub

    Private Sub CO_LG_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        udte_fecha.Value = Nothing
        udte_fecha.Value = Date.Now
        Call Cargar_Tipo_Cambio_delDia()
        upb_usu_ok.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
    End Sub

    Private Sub Cargar_Tipo_Cambio_delDia()
        Try
            Dim TcambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim TcambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
            TcambioBE.TC_FECHA = CDate(udte_fecha.Value).ToShortDateString
            TcambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            TcambioBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            TcambioBL.getTipoCambio(TcambioBE)
            ume_tc_compra.Value = TcambioBE.TC_COMPRA
            ume_tc_venta.Value = TcambioBE.TC_VENTA

            TcambioBE = Nothing
            TcambioBL = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Actualizar_Tipo_Cambio_delDia()
        Try
            Dim TcambioBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim TcambioBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
            TcambioBE.TC_FECHA = CDate(udte_fecha.Value).ToShortDateString
            TcambioBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            TcambioBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            TcambioBE.TC_COMPRA = ume_tc_compra.Value
            TcambioBE.TC_VENTA = ume_tc_venta.Value
            TcambioBE.TC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            TcambioBE.TC_TERMINAL = Environment.MachineName
            TcambioBE.TC_FECREG = Date.Now

            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Dim lista As New List(Of BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            lista = empresaBL.getEmpresas_1()

            For i As Integer = 0 To lista.Count - 1
                TcambioBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = lista(i).EM_ID}
                TcambioBL.Update(TcambioBE)
            Next

            empresaBL = Nothing
            lista = Nothing

            TcambioBE = Nothing
            TcambioBL = Nothing


            'Grabamos tipo de cambio de la  tabla de facturacion de la empresa de los doctores
            Dim tcBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
            Dim tcBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

            tcBE.PA_COMPRA = ume_tc_compra.Value
            tcBE.PA_VENTA = ume_tc_venta.Value
            tcBE.PA_FECHA = CDate(udte_fecha.Value).ToShortDateString
            tcBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tcBE.PA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            tcBE.PA_TERMINAL = Environment.MachineName
            tcBE.PA_FECREG = Now.Date
            tcBE.PA_IDMONEDA = New BE.FacturacionBE.SG_FA_TB_MONEDA With {.MO_ID = "02"}

            tcBL.Insert_AllEmpresas_desdeConta(tcBE)

            tcBE = Nothing
            tcBL = Nothing

        Catch ex As Exception
            ' ShowError(ex.Message)
        End Try
    End Sub

    Private Sub ubtn_regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_regresar.Click
        'Application.Restart()
        Me.Close()
        CO_LG_Empresas.Show()
        'CO_LG_Empresas_v2.Show()
    End Sub

    Private Sub ume_tc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_tc_compra.KeyDown, ume_tc_venta.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub udte_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha.ValueChanged
        Call Cargar_Tipo_Cambio_delDia()
    End Sub

    Private Sub ugb_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ugb_login.Click

    End Sub

    Private Sub ume_tc_compra_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles ume_tc_compra.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_VerSunat"
                CO_MT_TCamb_Web.Show()
            Case ""
        End Select
    End Sub

    Private Sub udte_fecha_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha.Enter
        udte_fecha.SelectAll()
    End Sub
End Class