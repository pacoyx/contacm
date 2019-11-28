Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core

Public Class PL_MA_Personal

    Dim Bol_Nuevo As Boolean = False
    Dim Lista_Doc As New Dictionary(Of Integer, Byte())

    Private Sub PL_MA_Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Cargar_Lista_Personal()
            Call Setear_Grilla_Telefono()
            Call Setear_Grilla_Contrato()
            Call Setear_Grilla_Conceptos()
            Call Cargar_Monedas()
            Call Cargar_Tipo_Doc_Personal()
            Call Cargar_Sexo()
            Call Cargar_Estado_Civil()
            Call Cargar_Tipo_Personal()
            Call Cargar_Nacionalidad()
            Call Cargar_Tipo_Via()
            Call Cargar_Tipo_Zona()
            Call Cargar_AFP()
            Call Cargar_Estado_Personal()
            Call Cargar_Cargos_Trabajador()
            Call Cargar_Tipo_Trabajador()
            Call Cargar_Nivel_Educativo()
            Call Cargar_Ocupaciones()
            Call Cargar_Regimen_Laboral()
            Call Cargar_Tipo_Remuneracion()
            Call Cargar_Tipo_Cuenta_Remuneracion()
            Call Cargar_Bancos()
            Call Cargar_Tipo_Cese()
            Call Cargar_SCTR_Salud()
            Call Cargar_SCTR_Pension()
            Call Cargar_Eps_Ser_Pro()
            Call Cargar_Periodo_Remunerativo()
            Call Cargar_Tipo_Pago()
            Call Cargar_Situacion_Especial()
            Call Cargar_Clasificacion_Personal()
            Call Cargar_Personal_Cli()
            Call Cargar_Areas()
            Call Cargar_GrupoSanguineo()
            Call Cargar_Lista_Tipo_Personal_Tarifa()
            Call Formatear_Grilla_Selector(ug_Listado)
            Call MostrarTabs(0, utc_Mante, 0)


            uce_IMP_REMU.ButtonsLeft(0).Appearance.Image = My.Resources._568
            txt_PE_UBIGEO.ButtonsRight(0).Appearance.Image = My.Resources._104
            uce_PE_ID_CARGO.ButtonsRight(0).Appearance.Image = My.Resources._16__File_new_2_
            uce_GRUPO_SANGUINEO.ButtonsRight(0).Appearance.Image = My.Resources._16__File_new_2_
            uce_ID_AREA.ButtonsRight(0).Appearance.Image = My.Resources._16__File_new_2_

            ubtn_ver_doc.Appearance.Image = My.Resources._16__Print_preview_
            ubtn_agregar_archivo.Appearance.Image = My.Resources._16__Card_edit_
            ubtn_Generar_Contrato.Appearance.Image = My.Resources._16__Doc_word_


        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Cargar_Lista_Tipo_Personal_Tarifa()
        Dim tipoPersonalTarifaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSO_TARIFA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA
        empresaBE.EM_ID = gInt_IdEmpresa
        uce_PE_ID_TIPO_PERSO_TARIFA.DataSource = tipoPersonalTarifaBL.get_Tipos(empresaBE)
        uce_PE_ID_TIPO_PERSO_TARIFA.ValueMember = "TT_ID"
        uce_PE_ID_TIPO_PERSO_TARIFA.DisplayMember = "TT_DESCRIPCION"
        tipoPersonalTarifaBL = Nothing
        empresaBE = Nothing
    End Sub

    Private Sub Cargar_Lista_Personal()
        Dim PersonalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim PersonalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        PersonalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        Dim dt_Personal As DataTable = PersonalBL.getPersonal_Lista_Mante(PersonalBE)
        ug_Listado.DataSource = dt_Personal
        PersonalBL = Nothing
        PersonalBE = Nothing
    End Sub

    Private Sub Cargar_GrupoSanguineo()
        Dim grupoBL As New BL.PlanillaBL.SG_PL_TB_GRUPO_SANGUINEO
        uce_GRUPO_SANGUINEO.DataSource = grupoBL.getGrupoSanguineo
        uce_GRUPO_SANGUINEO.ValueMember = "GS_ID"
        uce_GRUPO_SANGUINEO.DisplayMember = "GS_TIPO"
        grupoBL = Nothing
    End Sub

    Private Sub Cargar_Areas()
        Dim AreaBL As New BL.PlanillaBL.SG_PL_TB_AREA
        uce_ID_AREA.DataSource = AreaBL.getArea(New BE.PlanillaBE.SG_PL_TB_AREA With {.AR_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
        uce_ID_AREA.ValueMember = "AR_ID"
        uce_ID_AREA.DisplayMember = "AR_DESCRIPCION"
        AreaBL = Nothing
    End Sub

    Private Sub Cargar_Personal_Cli()
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL_CLI
        uce_PE_ID_PERSONAL.DataSource = personalBL.getTipos
        uce_PE_ID_PERSONAL.ValueMember = "TP_ID"
        uce_PE_ID_PERSONAL.DisplayMember = "TP_DESCRIPCION"
        personalBL = Nothing
    End Sub

    Private Sub Cargar_Clasificacion_Personal()
        Dim clasificacionBL As New BL.PlanillaBL.SG_PL_TB_CLASIFICACION_PERSONAL
        uce_PE_ID_CLASIFI_PER.DataSource = clasificacionBL.getClasificacion
        uce_PE_ID_CLASIFI_PER.ValueMember = "CP_ID"
        uce_PE_ID_CLASIFI_PER.DisplayMember = "CP_DESCRIPCION"
        clasificacionBL = Nothing
    End Sub

    Private Sub Cargar_Situacion_Especial()
        Dim situacionBL As New BL.PlanillaBL.SG_PL_TB_SITUACION_ESPECIAL
        uce_PE_ID_SITUACION_ESPECIAL.DataSource = situacionBL.getSituaciones
        uce_PE_ID_SITUACION_ESPECIAL.ValueMember = "SE_ID"
        uce_PE_ID_SITUACION_ESPECIAL.DisplayMember = "SE_DESCRIPCION"
        situacionBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Pago()
        Dim tipoPagoBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PAGO
        uce_PE_ID_TIPO_PAGO.DataSource = tipoPagoBL.getTipos
        uce_PE_ID_TIPO_PAGO.ValueMember = "TP_ID"
        uce_PE_ID_TIPO_PAGO.DisplayMember = "TP_DESCRIPCION"
        tipoPagoBL = Nothing
    End Sub

    Private Sub Cargar_Periodo_Remunerativo()
        Dim periodoRemuBL As New BL.PlanillaBL.SG_PL_TB_PERIODO_REMUNERATIVO
        uce_PE_ID_PERIODO_REMUNERA.DataSource = periodoRemuBL.getPeriodos
        uce_PE_ID_PERIODO_REMUNERA.ValueMember = "PR_ID"
        uce_PE_ID_PERIODO_REMUNERA.DisplayMember = "PR_DESCRIPCION"
        periodoRemuBL = Nothing
    End Sub

    Private Sub Cargar_Situacion_EPS(ByVal Int_afiliado As Integer)
        Dim situacionEpsBL As New BL.PlanillaBL.SG_PL_TB_SITUACION_EPS
        Dim situacionEpsBE As New BE.PlanillaBE.SG_PL_TB_SITUACION_EPS With {.SE_TIPO = Int_afiliado}
        uce_PE_ID_SITUACION_EPS.DataSource = situacionEpsBL.getSituaciones_x_Tipo(situacionEpsBE)
        uce_PE_ID_SITUACION_EPS.ValueMember = "SE_ID"
        uce_PE_ID_SITUACION_EPS.DisplayMember = "SE_DESCRIPCION"
        situacionEpsBL = Nothing
    End Sub

    Private Sub Cargar_Eps_Ser_Pro()
        Dim epsBL As New BL.PlanillaBL.SG_PL_TB_EPS_SERVICIO_PROPIO
        uce_PE_ID_COD_EPS_SER_PRO.DataSource = epsBL.getEPS()
        uce_PE_ID_COD_EPS_SER_PRO.ValueMember = "EP_ID"
        uce_PE_ID_COD_EPS_SER_PRO.DisplayMember = "EP_DESCRIPCION"
        epsBL = Nothing
    End Sub

    Public Sub Cargar_SCTR_Pension()
        Dim SctrBL As New BL.PlanillaBL.SG_PL_TB_SCTR_PENSION
        uce_PE_ID_SCTR_PENSION.DataSource = SctrBL.getSctr
        uce_PE_ID_SCTR_PENSION.ValueMember = "SP_ID"
        uce_PE_ID_SCTR_PENSION.DisplayMember = "SP_DESCRIPCION"
        SctrBL = Nothing
    End Sub

    Public Sub Cargar_SCTR_Salud()
        Dim SctrBL As New BL.PlanillaBL.SG_PL_TB_SCTR_SALUD
        uce_PE_ID_SCTR_SALUD.DataSource = SctrBL.getSctr
        uce_PE_ID_SCTR_SALUD.ValueMember = "SS_ID"
        uce_PE_ID_SCTR_SALUD.DisplayMember = "SS_DESCRIPCION"
        SctrBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Cese()
        Dim tipoCeseBL As New BL.PlanillaBL.SG_PL_TB_TIPO_CESE
        uce_PE_ID_TIPO_CESE.DataSource = tipoCeseBL.getTipos
        uce_PE_ID_TIPO_CESE.ValueMember = "TC_ID"
        uce_PE_ID_TIPO_CESE.DisplayMember = "TC_DESCRIPCION"
        tipoCeseBL = Nothing
    End Sub

    Private Sub Cargar_Bancos()
        Dim bancosBL As New BL.ContabilidadBL.SG_CO_TB_BANCO
        uce_PE_ID_BANCO_CTS.DataSource = bancosBL.getBancos(New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
        uce_PE_ID_BANCO_CTS.ValueMember = "BA_ID"
        uce_PE_ID_BANCO_CTS.DisplayMember = "BA_NOMBRE"
        bancosBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Cuenta_Remuneracion()
        Dim tipoCuentaRemuBL As New BL.PlanillaBL.SG_PL_TB_TIPO_CTA_BANCO
        uce_PE_ID_TIPO_CUENTA_REMU.DataSource = tipoCuentaRemuBL.getTipos
        uce_PE_ID_TIPO_CUENTA_REMU.ValueMember = "TC_ID"
        uce_PE_ID_TIPO_CUENTA_REMU.DisplayMember = "TC_DESCRIPCION"

        uce_PE_ID_TIPO_CUENTA_CTS.DataSource = tipoCuentaRemuBL.getTipos
        uce_PE_ID_TIPO_CUENTA_CTS.ValueMember = "TC_ID"
        uce_PE_ID_TIPO_CUENTA_CTS.DisplayMember = "TC_DESCRIPCION"

        tipoCuentaRemuBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Remuneracion()
        Dim tipoRemuBL As New BL.PlanillaBL.SG_PL_TB_TIPO_REMUNERACION
        uce_PE_ID_TIPO_REMU.DataSource = tipoRemuBL.getTipos
        uce_PE_ID_TIPO_REMU.ValueMember = "TR_ID"
        uce_PE_ID_TIPO_REMU.DisplayMember = "TR_DESCRIPCION"
        tipoRemuBL = Nothing
    End Sub

    Private Sub Cargar_Regimen_Laboral()
        Dim regimenLaboralBL As New BL.PlanillaBL.SG_PL_TB_REGIMEN_LABORAL
        uce_PE_ID_REGIMEN_LABORAL.DataSource = regimenLaboralBL.getRegimenes
        uce_PE_ID_REGIMEN_LABORAL.ValueMember = "RL_ID"
        uce_PE_ID_REGIMEN_LABORAL.DisplayMember = "RL_DESCRIPCION"
        regimenLaboralBL = Nothing
    End Sub

    Private Sub Cargar_Ocupaciones()
        Dim ocupacionBL As New BL.PlanillaBL.SG_PL_TB_OCUPACION
        uce_PE_ID_OCUPACION.DataSource = ocupacionBL.getOcupaciones
        uce_PE_ID_OCUPACION.ValueMember = "OC_ID"
        uce_PE_ID_OCUPACION.DisplayMember = "OC_DESCRIPCION"
        ocupacionBL = Nothing
    End Sub

    Private Sub Cargar_Nivel_Educativo()
        Dim nivelEducativoBL As New BL.PlanillaBL.SG_PL_TB_NIVEL_EDUCATIVO
        uce_PE_ID_NIVEL_EDU.DataSource = nivelEducativoBL.getNiveles
        uce_PE_ID_NIVEL_EDU.ValueMember = "NE_ID"
        uce_PE_ID_NIVEL_EDU.DisplayMember = "NE_DESCRIPCION"
        nivelEducativoBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Trabajador()
        Dim tipoTrabajadorBL As New BL.PlanillaBL.SG_PL_TB_TIPO_TRABAJADOR
        uce_PE_ID_TIPO_TRABAJADOR.DataSource = tipoTrabajadorBL.getTipos
        uce_PE_ID_TIPO_TRABAJADOR.ValueMember = "TT_ID"
        uce_PE_ID_TIPO_TRABAJADOR.DisplayMember = "TT_DESCRIPCION"
        tipoTrabajadorBL = Nothing
    End Sub

    Private Sub Cargar_Cargos_Trabajador()
        Dim cargoBL As New BL.PlanillaBL.SG_PL_TB_CARGO
        uce_PE_ID_CARGO.DataSource = cargoBL.getCargos(New BE.PlanillaBE.SG_PL_TB_CARGO With {.EC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}})
        uce_PE_ID_CARGO.ValueMember = "EC_ID"
        uce_PE_ID_CARGO.DisplayMember = "EC_CARGO"
        cargoBL = Nothing
    End Sub

    Private Sub Cargar_Estado_Personal()
        Dim estadoPersonalBL As New BL.PlanillaBL.SG_PL_TB_ESTADO_TRABAJADOR
        uce_PE_ID_EST_TRABAJADOR.DataSource = estadoPersonalBL.getEstados
        uce_PE_ID_EST_TRABAJADOR.ValueMember = "ET_ID"
        uce_PE_ID_EST_TRABAJADOR.DisplayMember = "ET_DESCRIPCION"
        estadoPersonalBL = Nothing
    End Sub

    Private Sub Cargar_AFP()
        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        uce_PE_ID_AFP.DataSource = afpBL.getAfp(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_PE_ID_AFP.ValueMember = "AF_ID"
        uce_PE_ID_AFP.DisplayMember = "AF_NOMBRE"
        afpBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Zona()
        Dim tipoZonaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_ZONA
        uce_PE_ID_TIPO_ZONA.DataSource = tipoZonaBL.getZonas
        uce_PE_ID_TIPO_ZONA.ValueMember = "TZ_ID"
        uce_PE_ID_TIPO_ZONA.DisplayMember = "TZ_DESCRIPCION"
        tipoZonaBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Via()
        Dim tipoViaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_VIA
        uce_PE_ID_TIPO_VIA.DataSource = tipoViaBL.getVias
        uce_PE_ID_TIPO_VIA.ValueMember = "TV_ID"
        uce_PE_ID_TIPO_VIA.DisplayMember = "TV_DESCRIPCION"
        tipoViaBL = Nothing
    End Sub

    Private Sub Cargar_Nacionalidad()
        Dim nacionalidadBL As New BL.PlanillaBL.SG_PL_TB_NACIONALIDAD
        uce_PE_ID_NACIONALIDAD.DataSource = nacionalidadBL.getNacionalidades
        uce_PE_ID_NACIONALIDAD.ValueMember = "NA_ID"
        uce_PE_ID_NACIONALIDAD.DisplayMember = "NA_DESCRIPCION"
        nacionalidadBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Personal()
        Dim tipoTrabajadorBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_PE_ID_TIPO_PER.DataSource = tipoTrabajadorBL.getTipos
        uce_PE_ID_TIPO_PER.DisplayMember = "TP_DESCRIPCION"
        uce_PE_ID_TIPO_PER.ValueMember = "TP_ID"
        tipoTrabajadorBL = Nothing
    End Sub

    Private Sub Cargar_Estado_Civil()
        Dim estadoCivilBL As New BL.PlanillaBL.SG_PL_TB_ESTADO_VICIL
        uce_PE_ID_EST_CIVIL.DataSource = estadoCivilBL.getEstados
        uce_PE_ID_EST_CIVIL.DisplayMember = "EC_DESCRIPCION"
        uce_PE_ID_EST_CIVIL.ValueMember = "EC_ID"
        estadoCivilBL = Nothing
    End Sub

    Private Sub Cargar_Sexo()
        Dim sexoBL As New BL.PlanillaBL.SG_PL_TB_SEXO
        uos_PE_ID_SEXO.DataSource = sexoBL.getSexos
        uos_PE_ID_SEXO.DisplayMember = "SE_DESCRIPCION"
        uos_PE_ID_SEXO.ValueMember = "SE_ID"
        sexoBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Doc_Personal()
        Dim documentoBL As New BL.PlanillaBL.SG_PL_TB_DOCUMENTO_PERSONAL
        uce_PE_ID_TIPO_DOC_PER.DataSource = documentoBL.getDocumentos
        uce_PE_ID_TIPO_DOC_PER.DisplayMember = "DP_DESCRIPCION"
        uce_PE_ID_TIPO_DOC_PER.ValueMember = "DP_ID"
        documentoBL = Nothing
    End Sub

    Private Sub Cargar_Monedas()
        Dim monedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
        uce_PE_ID_MONEDA_REMU.DataSource = monedaBL.getMonedas()
        uce_PE_ID_MONEDA_REMU.DisplayMember = "MO_DESCRIPCION"
        uce_PE_ID_MONEDA_REMU.ValueMember = "MO_CODIGO"

        uce_PE_ID_MONEDA_CTS.DataSource = monedaBL.getMonedas()
        uce_PE_ID_MONEDA_CTS.DisplayMember = "MO_DESCRIPCION"
        uce_PE_ID_MONEDA_CTS.ValueMember = "MO_CODIGO"

        uce_PE_ID_MONEDA_CUENTA.DataSource = monedaBL.getMonedas()
        uce_PE_ID_MONEDA_CUENTA.DisplayMember = "MO_DESCRIPCION"
        uce_PE_ID_MONEDA_CUENTA.ValueMember = "MO_CODIGO"

        monedaBL = Nothing
    End Sub

    Private Sub Setear_Grilla_Telefono()
        Dim ComunicacionBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_COMUNICACION
        Call CrearComboGrid("TC_DESCRIPCION", "TC_DESCRIPCION", ug_comunicacion_persona, ComunicacionBL.getTipos_DT, True)
        ComunicacionBL = Nothing
    End Sub

    Private Sub Setear_Grilla_Contrato()
        Dim tipoContratoBL As New BL.PlanillaBL.SG_PL_TB_TIPO_CONTRATO
        Call CrearComboGrid("CO_ID_TIPO_CONTRATO", "TC_DESCRIPCION", ug_Contratos, tipoContratoBL.get_Tipos, True)
        tipoContratoBL = Nothing
    End Sub

    Private Sub Setear_Grilla_Conceptos()
        Dim conceptosBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Call CrearComboGrid("PC_ID_CONCEPTO", "CO_DESCRIPCION", ug_Conceptos, conceptosBL.get_Conceptos_Lista_Chica(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}), True)
        conceptosBL = Nothing
    End Sub

    Private Sub uce_PE_AFILIADO_EPS_SER_PRO_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_PE_AFILIADO_EPS_SER_PRO.ValueChanged
        Call Cargar_Situacion_EPS(uce_PE_AFILIADO_EPS_SER_PRO.Value)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_PE_UBIGEO_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_PE_UBIGEO.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ayuda"
                PL_MA_Ubigeo.ShowDialog()
                If PL_MA_Ubigeo.Bol_Aceptar Then
                    txt_PE_UBIGEO.Text = PL_MA_Ubigeo.Str_Ubigeo.ToString
                End If
        End Select
    End Sub

    Private Sub ubtn_editar_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_editar_img.Click
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

    Private Sub ubtn_eliminar_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_eliminar_img.Click
        upb_img.Image = Nothing
        upb_img.Image = My.Resources.Desconocido
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Bol_Nuevo = True
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox_Nativo(gb_DatosPersonales)
        Call Limpiar_Controls_InGroupox(ugb_codigo)
        Call Limpiar_Controls_InGroupox(ugb_datos_personales)
        Call Limpiar_Controls_InGroupox(ugb_direccion)
        Call Limpiar_Controls_InGroupox(ugb_telefonos)

        Call Limpiar_Controls_InGroupox_Nativo(gb_DatosLaborales)
        Call Limpiar_Controls_InGroupox_Nativo(gb_DatosAdicioanles)
        Call Limpiar_Controls_InGroupox_Nativo(gb_remuneracion)
        Call Limpiar_Controls_InGroupox_Nativo(gb_cts)
        Call Limpiar_Controls_InGroupox_Nativo(gb_afp)
        Call Limpiar_Controls_InGroupox_Nativo(gb_otros)
        Call Limpiar_Controls_InGroupox_Nativo(gb_otro1)
        Call Limpiar_Controls_InGroupox_Nativo(gb_otros2)
        Call Limpiar_Controls_InGroupox_Nativo(gb_cese)

        Call LimpiaGrid(ug_comunicacion_persona, uds_Comunicacion)
        Call LimpiaGrid(ug_Documentos, uds_Documentos)
        Call LimpiaGrid(ug_Contratos, uds_Contratos)
        Call LimpiaGrid(ug_Conceptos, uds_Conceptos)
        Call Generar_Codigo_Personal()
        Call Cargar_CentroCostos()
        Call Iniciar_Controles()

        udte_PE_FEC_NAC.Value = Nothing
        txt_PE_APE_PAT.Focus()

    End Sub

    Private Sub Cargar_CentroCostos()
        Dim ccostoBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccostoBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
        ccostoBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_tmp As DataTable = ccostoBL.getCentroCostos(ccostoBE)
        Call LimpiaGrid(ug_ccosto, uds_Ccosto)
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_ccosto.DisplayLayout.Bands(0).AddNew()
            ug_ccosto.Rows(i).Cells("CC_CODIGO").Value = dt_tmp.Rows(i)("CC_CODIGO")
            ug_ccosto.Rows(i).Cells("CC_DESCRIPCION").Value = dt_tmp.Rows(i)("CC_DESCRIPCION")
            ug_ccosto.Rows(i).Cells("PORCENTAJE").Value = 0
        Next
        ug_ccosto.UpdateData()



    End Sub

    Private Sub Iniciar_Controles()
        uce_PE_ID_TIPO_DOC_PER.Value = 1
        uce_PE_ID_TIPO_PER.Value = 1
        uce_PE_ID_NACIONALIDAD.Value = 9589
        uos_PE_ID_SEXO.Value = 1
        uce_PE_ID_EST_CIVIL.Value = 1
        uce_PE_ID_TIPO_VIA.Value = "01"
        uce_PE_ID_TIPO_ZONA.Value = "01"
        uce_PE_ID_EST_TRABAJADOR.Value = 1
        uce_PE_ID_TIPO_TRABAJADOR.Value = "21"
        uce_PE_ID_REGIMEN_LABORAL.Value = 1
        uce_PE_ID_MONEDA_REMU.Value = 1
        uce_PE_ID_MONEDA_CUENTA.Value = 1
        uce_PE_ID_MONEDA_CTS.Value = 1
        uce_PE_ID_TIPO_REMU.Value = 1
        uce_PE_ID_TIPO_CUENTA_REMU.Value = 1
        uce_PE_ID_PERIODO_REMUNERA.Value = 1
        uce_PE_ID_TIPO_PAGO.Value = 2
        uce_PE_ID_CLASIFI_PER.Value = 1
        uce_PE_ID_PERSONAL.Value = 1
        uce_PE_ID_SITUACION_ESPECIAL.Value = 0
        uce_IMP_REMU.Value = 0
        Lista_Doc.Clear()

        utc_Mante.Tabs(0).Enabled = False
        ubtn_ver_doc.Enabled = False
        uchk_PE_AFECTO_QUINTA.Checked = True
        ume_PE_FEC_INSCRIP_REG_PEN.Value = Nothing
        ume_PE_FEC_CESE.Value = Nothing
        uce_PE_ID_SCTR_SALUD.Value = 0
        uce_PE_ID_SCTR_PENSION.Value = 0
        uce_PE_AFILIADO_EPS_SER_PRO.Value = 2
        uchart_cc.Visible = False
        txt_ficha.Text = String.Empty
        upb_img.Image = Nothing
        upb_img.Image = My.Resources.Desconocido

        txt_total_porce_cc.Text = "0"

        For i As Integer = 1 To utc_Mante.Tabs.Count - 1
            utc_Mante.Tabs(i).Enabled = True
        Next

        ume_quinta_ant.Value = 0
        utc_Mante.Tabs(1).Selected = True



    End Sub

    Private Sub Generar_Codigo_Personal()
        Dim PersonalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim parametrosBL As New BL.ContabilidadBL.SG_CO_TB_PARAMETROSGENERALES
        Dim dt_tmp As DataTable = parametrosBL.getParametros

        'codigo principal
        txt_PE_CODIGO.Text = String.Empty
        txt_PE_CODIGO.Text = PersonalBL.get_Nuevo_Codigo_Personal(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})



        'codigo alterno

        If dt_tmp.Rows(0)("PG_TIP_COD_ALT") = "1" Then
            txt_PE_CODIGO_ALT.ReadOnly = True
            txt_PE_CODIGO_ALT.Text = String.Empty
            txt_PE_CODIGO_ALT.Text = txt_PE_CODIGO.Text
        End If

        If dt_tmp.Rows(0)("PG_TIP_COD_ALT") = "2" Then
            txt_PE_CODIGO_ALT.Text = String.Empty
            txt_PE_CODIGO_ALT.ReadOnly = True

            If dt_tmp.Rows(0)("PG_TIP_COD_ALT").ToString = String.Empty Then
                Avisar("Falta ingresar la variable para generar el codigo alterno")
                txt_PE_CODIGO_ALT.Text = "XXX" & Microsoft.VisualBasic.Right(txt_PE_CODIGO.Text, 4)
                Exit Sub
            End If

            txt_PE_CODIGO_ALT.Text = dt_tmp.Rows(0)("PG_VAR_COD_ALT").ToString & Microsoft.VisualBasic.Right(txt_PE_CODIGO.Text, 4)
        End If


        If dt_tmp.Rows(0)("PG_TIP_COD_ALT") = "3" Then
            txt_PE_CODIGO_ALT.Text = String.Empty
            txt_PE_CODIGO_ALT.Text = PersonalBL.get_Nuevo_Codigo_Alterno_Personal(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})

        End If

        If dt_tmp.Rows(0)("PG_TIP_COD_ALT") = "4" Then
            txt_PE_CODIGO_ALT.ReadOnly = False
            txt_PE_CODIGO_ALT.Text = String.Empty
        End If


        PersonalBL = Nothing
        parametrosBL = Nothing
        dt_tmp = Nothing


    End Sub

    Private Sub uchk_PE_ASIGNACION_FAM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_PE_ASIGNACION_FAM.CheckedChanged
        une_PE_NUM_HIJOS.Enabled = uchk_PE_ASIGNACION_FAM.Checked
    End Sub

    Private Sub ug_comunicacion_persona_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_comunicacion_persona.AfterRowUpdate

        If Not Bol_Nuevo Then 'edicion
            Dim comuBL As New BL.PlanillaBL.SG_PL_TB_PERSONA_COMUNICACION
            Dim comuBE As New BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION
            With comuBE
                .PC_ID = Val(e.Row.Cells("PC_ID").Value.ToString)
                .PC_ID_PERSONA = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_id_personal.Text.Trim}
                .PC_ID_COMUNICACION = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION With {.TC_ID = e.Row.Cells("TC_DESCRIPCION").Value}
                .PC_NUMERO = e.Row.Cells("PC_NUMERO").Value.ToString
                .PC_DESCRIPCION = e.Row.Cells("PC_DESCRIPCION").Value.ToString
                If e.Row.Cells("PC_ISTATUS").Value.ToString = "" Then
                    .PC_ISTATUS = 1
                Else
                    .PC_ISTATUS = IIf(e.Row.Cells("PC_ISTATUS").Value, 1, 0)
                End If

                .PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .PC_TERMINAL = Environment.MachineName
                .PC_FECREG = Date.Now
            End With

            If ug_comunicacion_persona.ActiveRow.Cells("PC_ID").Text.Trim <> String.Empty Then
                comuBL.Update(comuBE)
            Else
                comuBL.Insert(comuBE)
                ug_comunicacion_persona.ActiveRow.Cells("PC_ID").Value = comuBE.PC_ID
            End If
            ug_comunicacion_persona.Update()
        End If
    End Sub

    Private Sub Cargar_Foto_Personal(ByVal IdPersonal As Integer)
        Dim fotoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_FOTO
        upb_img.Image = Bytes2Image(fotoBL.get_Foto_x_IdPersonal(IdPersonal))

        'If .PE_FOTO Is Nothing Then
        '    upb_img.Image = My.Resources.Desconocido
        'Else
        '    upb_img.Image = Bytes2Image(.PE_FOTO)
        'End If

        fotoBL = Nothing
    End Sub

    Private Sub Cargar_Comunicacion_Personal(ByVal IdPersonal As Integer)
        Dim comunicacionBL As New BL.PlanillaBL.SG_PL_TB_PERSONA_COMUNICACION
        Dim personaBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personaBE.PE_ID = IdPersonal
        ug_comunicacion_persona.DataSource = comunicacionBL.getComunicaciones_x_IdPersona(personaBE)
        personaBE = Nothing
        comunicacionBL = Nothing
    End Sub

    Private Sub Cargar_Ccostos_Personal(ByVal IdPersonal As Integer)
        Dim ccostoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CCOSTO
        Dim personalBL As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personalBL.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBL.PE_ID = IdPersonal
        ug_ccosto.DataSource = ccostoBL.get_CCostosPersonal_x_IdPersonal(personalBL)
        personalBL = Nothing
        ccostoBL = Nothing

        Call Sumar_Porcentaje()
        Call Mostrar_Chart_CC()

    End Sub

    Private Sub Cargar_Documentos_Personal(ByVal IdPersonal As Integer)
        Dim documentoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_DOCUMENTOS
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim dt_tmp As DataTable
        personalBE.PE_ID = IdPersonal
        dt_tmp = documentoBL.get_Documentos_X_IdPersona(personalBE)
        Lista_Doc.Clear()
        Call LimpiaGrid(ug_Documentos, uds_Documentos)
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Documentos.DisplayLayout.Bands(0).AddNew()
            ug_Documentos.Rows(i).Cells("DO_ID").Value = dt_tmp.Rows(i)("DO_ID")
            ug_Documentos.Rows(i).Cells("DO_NOMBRE_ARCHIVO").Value = dt_tmp.Rows(i)("DO_NOMBRE_ARCHIVO")
            ug_Documentos.Rows(i).Cells("DO_DESCRIPCION").Value = dt_tmp.Rows(i)("DO_DESCRIPCION")
            Lista_Doc.Add(dt_tmp.Rows(i)("DO_ID"), dt_tmp.Rows(i)("DO_FILE"))
        Next
        ug_Documentos.Update()
        'ug_Documentos.DataSource = documentoBL.get_Documentos_X_IdPersona(personalBE)

        dt_tmp.Dispose()
        personalBE = Nothing
        documentoBL = Nothing
    End Sub

    Private Sub Cargar_Contratos_Personal(ByVal IdPersonal As Integer)
        Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personalBE.PE_ID = IdPersonal
        ug_Contratos.DataSource = contratoBL.get_Contratos_x_IdPersonal(personalBE)
        personalBE = Nothing
        contratoBL = Nothing
    End Sub

    Private Sub Cargar_Concepto_Personal(ByVal IdPersonal As Integer)
        Dim PerConceptoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONCEPTO
        Dim dt_tmp As DataTable = PerConceptoBL.get_Conceptos(New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = IdPersonal})

        Call LimpiaGrid(ug_Conceptos, uds_Conceptos)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Conceptos.DisplayLayout.Bands(0).AddNew()
            ug_Conceptos.Rows(i).Cells("PC_ID_PERSONAL").Value = dt_tmp.Rows(i)("PC_ID_PERSONAL")
            ug_Conceptos.Rows(i).Cells("PC_ID_CONCEPTO").Value = dt_tmp.Rows(i)("PC_ID_CONCEPTO")
            ug_Conceptos.Rows(i).Cells("PC_VALOR").Value = dt_tmp.Rows(i)("PC_VALOR")
            ug_Conceptos.Rows(i).Cells("PC_ID_EMPRESA").Value = dt_tmp.Rows(i)("PC_ID_EMPRESA")
        Next

        ug_Conceptos.UpdateData()

        ug_Conceptos.DisplayLayout.Bands(0).AddNew()

        dt_tmp.Dispose()
        PerConceptoBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Listado.ActiveRow.Cells("PE_ID").Value.ToString = "" Then Exit Sub
        Call Editar_Datos()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Editar_Datos()

        Me.Cursor = Cursors.WaitCursor

        Bol_Nuevo = False
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        personalBE.PE_ID = ug_Listado.ActiveRow.Cells("PE_ID").Value
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBL.getPersonal_x_Id(personalBE)

        With personalBE
            txt_id_personal.Text = .PE_ID
            txt_PE_CODIGO.Text = .PE_CODIGO
            txt_PE_CODIGO_ALT.Text = .PE_CODIGO_ALT
            uce_PE_ID_TIPO_PER.Value = .PE_ID_TIPO_PER
            txt_PE_APE_PAT.Text = .PE_APE_PAT
            txt_PE_APE_MAT.Text = .PE_APE_MAT
            txt_PE_NOM_PRI.Text = .PE_NOM_PRI
            txt_PE_NOM_SEG.Text = .PE_NOM_SEG
            uce_PE_ID_TIPO_DOC_PER.Value = .PE_ID_TIPO_DOC_PER
            txt_PE_NUM_DOC_PER.Text = .PE_NUM_DOC_PER
            udte_PE_FEC_NAC.Value = .PE_FEC_NAC
            uce_PE_ID_EST_CIVIL.Value = .PE_ID_EST_CIVIL
            uce_PE_ID_CARGO.Value = .PE_ID_CARGO
            txt_PE_NUM_IPSS.Text = .PE_NUM_IPSS
            uce_PE_ID_AFP.Value = .PE_ID_AFP
            txt_PE_NUM_AFP.Text = .PE_NUM_AFP
            uce_PE_ID_EST_TRABAJADOR.Value = .PE_ID_EST_TRABAJADOR
            uce_IMP_REMU.Value = .PE_IMPORTE_REMUNERACION
            uce_PE_ID_MONEDA_REMU.Value = .PE_ID_MONEDA_REMU
            uce_PE_ID_TIPO_REMU.Value = .PE_ID_TIPO_REMU
            uce_PE_ID_TIPO_CUENTA_REMU.Value = .PE_ID_TIPO_CUENTA_REMU
            uce_PE_ID_MONEDA_CUENTA.Value = .PE_ID_MONEDA_CUENTA
            txt_PE_NUM_CUENTA.Text = .PE_NUM_CUENTA
            uos_PE_ID_SEXO.Value = .PE_ID_SEXO
            uce_PE_ID_NACIONALIDAD.Value = .PE_ID_NACIONALIDAD
            txt_PE_ID_ANEXO_CONTA.Text = .PE_ID_ANEXO_CONTA
            uce_GRUPO_SANGUINEO.Value = .PE_ID_GRUPO_SANGUINEO
            txt_PE_HORAS_TRABAJO.Text = .PE_HORAS_TRABAJO
            uchk_PE_DOMICILIADO.Checked = IIf(.PE_DOMICILIADO = 1, True, False)
            uce_PE_ID_TIPO_VIA.Value = .PE_ID_TIPO_VIA
            txt_PE_NOMBRE_VIA.Text = .PE_NOMBRE_VIA
            txt_PE_NUMERO_VIA.Text = .PE_NUMERO_VIA
            txt_PE_INTERIOR.Text = .PE_INTERIOR
            uce_PE_ID_TIPO_ZONA.Value = .PE_ID_TIPO_ZONA
            txt_PE_NOMBRE_ZONA.Text = .PE_NOMBRE_ZONA
            txt_PE_REFERENCIA.Text = .PE_REFERENCIA
            txt_PE_UBIGEO.Text = .PE_UBIGEO
            uce_PE_ID_TIPO_TRABAJADOR.Value = .PE_ID_TIPO_TRABAJADOR
            uce_PE_ID_NIVEL_EDU.Value = .PE_ID_NIVEL_EDU
            uce_PE_ID_OCUPACION.Value = .PE_ID_OCUPACION
            uchk_PE_DISCAPACIDAD.Checked = IIf(.PE_DISCAPACIDAD = 1, True, False)
            ume_PE_FEC_INSCRIP_REG_PEN.Value = .PE_FEC_INSCRIP_REG_PEN
            uce_PE_ID_REGIMEN_LABORAL.Value = .PE_ID_REGIMEN_LABORAL
            uchk_PE_SUJETO_JOR_MAX.Checked = IIf(.PE_SUJETO_JOR_MAX = 1, True, False)
            uchk_PE_SUJETO_REG_ALT.Checked = IIf(.PE_SUJETO_REG_ALT = 1, True, False)
            udte_PE_FEC_ING.Value = .PE_FEC_ING
            ume_PE_FEC_CESE.Value = .PE_FEC_CESE
            uce_PE_ID_TIPO_CESE.Value = .PE_ID_TIPO_CESE
            uce_PE_ID_SCTR_SALUD.Value = .PE_ID_SCTR_SALUD
            uce_PE_ID_SCTR_PENSION.Value = .PE_ID_SCTR_PENSION
            uchk_PE_SUJETO_HORA_NOC.Checked = IIf(.PE_SUJETO_HORA_NOC = 1, True, False)
            uchk_PE_OTRO_ING_5TA.Checked = IIf(.PE_OTRO_ING_5TA = 1, True, False)
            uchk_PE_ES_SINDICALIZADO.Checked = IIf(.PE_ES_SINDICALIZADO = 1, True, False)
            uce_PE_ID_PERIODO_REMUNERA.Value = .PE_ID_PERIODO_REMUNERA
            uce_PE_AFILIADO_EPS_SER_PRO.Value = .PE_AFILIADO_EPS_SER_PRO
            uce_PE_ID_COD_EPS_SER_PRO.Value = .PE_ID_COD_EPS_SER_PRO
            uce_PE_ID_SITUACION_EPS.Value = .PE_ID_SITUACION_EPS
            uce_PE_ID_TIPO_PAGO.Value = .PE_ID_TIPO_PAGO
            uce_PE_ID_SITUACION_ESPECIAL.Value = .PE_ID_SITUACION_ESPECIAL
            uce_PE_ID_CLASIFI_PER.Value = .PE_ID_CLASIFI_PER
            uce_PE_ID_PERSONAL.Value = .PE_ID_PERSONAL
            uce_ID_AREA.Value = .PE_ID_AREA
            uchk_PE_ASIGNACION_FAM.Checked = IIf(.PE_ASIGNACION_FAM = 1, True, False)
            une_PE_NUM_HIJOS.Value = .PE_NUM_HIJOS
            uce_PE_ID_BANCO_CTS.Value = .PE_ID_BANCO_CTS
            uce_PE_ID_TIPO_CUENTA_CTS.Value = .PE_ID_TIPO_CUENTA_CTS
            txt_PE_NUM_CUENTA_CTS.Text = .PE_NUM_CUENTA_CTS
            uce_PE_ID_MONEDA_CTS.Value = .PE_ID_MONEDA_CTS
            uchk_PE_AFECTO_QUINTA.Checked = IIf(.PE_AFECTO_QUINTA = 1, True, False)

            txt_ficha.Text = .PE_FICHA
            uchk_PE_CONSIDERA_FT.Checked = IIf(.PE_CONSIDERA_FT = 1, True, False)
            uchk_Calcular_cts.Checked = IIf(.PE_CALCULAR_CTS = 1, True, False)

            txt_cod_interbancario.Text = .PE_COD_INTERBANCA.ToString
            ume_quinta_ant.Value = .PE_QUINTA_ANT

            uchk_EsRia.Checked = IIf(.PE_ES_RIA = 1, True, False)
            If Not .PE_ID_TIPO_PERSO_TARIFA Is Nothing Then
                uce_PE_ID_TIPO_PERSO_TARIFA.Value = .PE_ID_TIPO_PERSO_TARIFA.TT_ID
            End If

            uos_tipo_comi.Value = .PE_IDCOMISION

        End With


        Call Cargar_Foto_Personal(ug_Listado.ActiveRow.Cells("PE_ID").Value)
        Call Cargar_Comunicacion_Personal(ug_Listado.ActiveRow.Cells("PE_ID").Value)
        Call Cargar_Ccostos_Personal(ug_Listado.ActiveRow.Cells("PE_ID").Value)
        Call Cargar_Documentos_Personal(ug_Listado.ActiveRow.Cells("PE_ID").Value)
        Call Cargar_Contratos_Personal(ug_Listado.ActiveRow.Cells("PE_ID").Value)
        Call Cargar_Concepto_Personal(ug_Listado.ActiveRow.Cells("PE_ID").Value)

        ubtn_ver_doc.Enabled = True
        ubtn_Generar_Contrato.Enabled = True

        For i As Integer = 1 To utc_Mante.Tabs.Count - 1
            utc_Mante.Tabs(i).Enabled = True
        Next
        utc_Mante.Tabs(0).Enabled = False
        utc_Mante.Tabs(1).Selected = True


        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ug_comunicacion_persona_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_comunicacion_persona.BeforeRowsDeleted
        If Not Bol_Nuevo Then 'edicion

            If ug_comunicacion_persona.ActiveRow.Cells("PC_ID").Value.ToString = "" Then Exit Sub

            e.DisplayPromptMsg = False
            Dim comuBL As New BL.PlanillaBL.SG_PL_TB_PERSONA_COMUNICACION
            Dim comuBE As New BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION
            comuBE.PC_ID = ug_comunicacion_persona.ActiveRow.Cells("PC_ID").Value
            comuBL.Delete(comuBE)
            comuBE = Nothing
            comuBL = Nothing
        End If
    End Sub

    Private Sub ug_ccosto_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ug_ccosto.AfterCellUpdate
        Call Sumar_Porcentaje()
        Call Mostrar_Chart_CC()
    End Sub

    Private Sub UG_CCOSTO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_ccosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Sumar_Porcentaje()
            Call Mostrar_Chart_CC()
            With ug_ccosto
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
            End With
        End If
    End Sub

    Private Sub Sumar_Porcentaje()
        Dim Dbl_Porcentaje As Double = 0
        ug_ccosto.UpdateData()
        For i As Integer = 0 To ug_ccosto.Rows.Count - 1
            If ug_ccosto.Rows(i).Cells("PORCENTAJE").Value.ToString <> String.Empty Then
                Dbl_Porcentaje += ug_ccosto.Rows(i).Cells("PORCENTAJE").Value
            End If
        Next

        txt_total_porce_cc.Text = Dbl_Porcentaje.ToString
        If Dbl_Porcentaje > 100 Then
            Avisar("La suma sobre pasa el limite de 100%  revise!")
        End If
    End Sub

    Private Sub Mostrar_Chart_CC()
        Dim dt_ccostos As New DataTable
        dt_ccostos.Columns.Add("CC", Type.GetType("System.String"))

        For z As Integer = 0 To ug_ccosto.Rows.Count - 1
            dt_ccostos.Columns.Add("C" & ug_ccosto.Rows(z).Cells("CC_CODIGO").Value.ToString, Type.GetType("System.Double"))
        Next


        Dim FILA As DataRow = dt_ccostos.NewRow
        FILA("CC") = txt_PE_NOM_PRI.Text & " " & txt_PE_APE_PAT.Text & " " & txt_PE_APE_MAT.Text


        For i As Integer = 0 To ug_ccosto.Rows.Count - 1
            FILA("C" & ug_ccosto.Rows(i).Cells("CC_CODIGO").Value.ToString) = ug_ccosto.Rows(i).Cells("PORCENTAJE").Value
        Next


        dt_ccostos.Rows.Add(FILA)
        uchart_cc.TitleTop.Text = "Distribución Asiento Planilla"
        uchart_cc.Data.DataSource = dt_ccostos
        uchart_cc.Data.DataBind()
        uchart_cc.Visible = True
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar_archivo.Click
        Dim oFD As New OpenFileDialog
        oFD.Title = "Selecccionar la imagen"
        'oFD.Filter = "*.*"
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


            ug_Documentos.DisplayLayout.Bands(0).AddNew()
            Dim fila As Integer = ug_Documentos.Rows.Count - 1
            Dim id_lista As Integer = fila

            If Bol_Nuevo Then 'Grabamos en el array temporal
deNuevo:
                id_lista += 1
                Try
                    Lista_Doc.Add(id_lista, imagen)
                Catch ex As Exception
                    GoTo deNuevo
                End Try

            Else
                'Grabamos a la BD de frente
                Dim docuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_DOCUMENTOS
                Dim docuBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS
                With docuBE
                    .DO_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_id_personal.Text.Trim}
                    .DO_NOMBRE_ARCHIVO = sNombre
                    .DO_DESCRIPCION = "..."
                    .DO_FILE = imagen
                    .DO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .DO_TERMINAL = Environment.MachineName
                    .DO_FECREG = Date.Now
                End With
                docuBL.Insert(docuBE)

                id_lista = docuBE.DO_ID

                docuBE = Nothing
                docuBL = Nothing

            End If

            ug_Documentos.Rows(fila).Cells("DO_ID").Value = id_lista
            ug_Documentos.Rows(fila).Cells("DO_NOMBRE_ARCHIVO").Value = sNombre
            ug_Documentos.Rows(fila).Cells("DO_DESCRIPCION").Value = "..."
            ug_Documentos.Update()

        End If

    End Sub

    Private Sub ug_Documentos_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Documentos.AfterRowUpdate
        If Not Bol_Nuevo Then
            Dim docuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_DOCUMENTOS
            Dim docuBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS
            docuBE.DO_ID = Val(e.Row.Cells("DO_ID").Value.ToString)
            docuBE.DO_DESCRIPCION = e.Row.Cells("DO_DESCRIPCION").Value.ToString
            docuBL.Update(docuBE)
            docuBE = Nothing
            docuBL = Nothing
        End If
    End Sub

    Private Sub ug_Documentos_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Documentos.BeforeRowsDeleted
        e.DisplayPromptMsg = False

        Dim key As Integer = ug_Documentos.ActiveRow.Cells("DO_ID").Value
        If Bol_Nuevo Then
            Lista_Doc.Remove(key)
        Else
            Dim docuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_DOCUMENTOS
            Dim docuBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS
            docuBE.DO_ID = key
            docuBL.Delete(docuBE)
            docuBE = Nothing
            docuBL = Nothing
        End If
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        '___________________________________________________Validar________________________________________________



        'Aqui hay que validar el codigo alterno


        Me.Cursor = Cursors.WaitCursor



        If txt_PE_APE_PAT.Text.Trim = String.Empty Then
            Avisar("Ingrese el apellido paterno")
            txt_PE_APE_PAT.Focus()
            Exit Sub
        End If

        If txt_PE_APE_MAT.Text.Trim = String.Empty Then
            Avisar("Ingrese el apellido materno")
            txt_PE_APE_MAT.Focus()
            Exit Sub
        End If

        If txt_PE_NOM_PRI.Text.Trim = String.Empty Then
            Avisar("Ingrese el primer nombre")
            txt_PE_NOM_PRI.Focus()
            Exit Sub
        End If

        If uce_PE_ID_TIPO_PER.Value = 1 Then
            If txt_PE_HORAS_TRABAJO.Text.Trim = String.Empty Then
                Avisar("Ingrese las Horas de Trabajo")
                txt_PE_HORAS_TRABAJO.Focus()
                Exit Sub
            End If
        End If

        '1=empleados
        '2=por horas
        If uce_PE_ID_TIPO_PER.Value = 1 Then
            If uce_IMP_REMU.Value = 0 Then
                Avisar("Ingrese la Remuneracion")
                uce_IMP_REMU.Focus()
                Exit Sub
            End If
        End If



        If Val(txt_total_porce_cc.Text.Trim) = 0 Then
            If Not Preguntar("Porcentaje de Centro de Costo es cero. Desea Continuar?") Then
                Exit Sub
            End If

        End If

        'If uce_PE_ID_TIPO_PER.Value = 2 Then
        '    If uce_PE_ID_TIPO_PERSO_TARIFA.SelectedIndex = -1 Then
        '        Avisar("Seleccione el tipo de personal para la Tarifa de las Horas")
        '        uce_PE_ID_TIPO_PERSO_TARIFA.Focus()
        '        Exit Sub
        '    End If
        'End If

        '___________________________________________________Cargar Datos__________________________________________
        Dim personaBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personaBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL

        With personaBE
            .PE_ID = IIf(Bol_Nuevo, 0, txt_id_personal.Text.Trim)
            .PE_CODIGO = txt_PE_CODIGO.Text.Trim
            .PE_CODIGO_ALT = txt_PE_CODIGO_ALT.Text.Trim
            .PE_ID_TIPO_PER = uce_PE_ID_TIPO_PER.Value
            .PE_APE_PAT = txt_PE_APE_PAT.Text.Trim
            .PE_APE_MAT = txt_PE_APE_MAT.Text.Trim
            .PE_NOM_PRI = txt_PE_NOM_PRI.Text.Trim
            .PE_NOM_SEG = txt_PE_NOM_SEG.Text.Trim
            .PE_ID_TIPO_DOC_PER = uce_PE_ID_TIPO_DOC_PER.Value
            .PE_NUM_DOC_PER = txt_PE_NUM_DOC_PER.Text.Trim
            .PE_FEC_NAC = CDate(udte_PE_FEC_NAC.Value).Date
            .PE_ID_EST_CIVIL = uce_PE_ID_EST_CIVIL.Value
            .PE_ID_CARGO = uce_PE_ID_CARGO.Value
            .PE_NUM_IPSS = txt_PE_NUM_IPSS.Text
            .PE_ID_AFP = uce_PE_ID_AFP.Value
            .PE_NUM_AFP = txt_PE_NUM_AFP.Text.Trim
            .PE_ID_EST_TRABAJADOR = uce_PE_ID_EST_TRABAJADOR.Value
            .PE_IMPORTE_REMUNERACION = uce_IMP_REMU.Value
            .PE_ID_MONEDA_REMU = uce_PE_ID_MONEDA_REMU.Value
            .PE_ID_TIPO_REMU = uce_PE_ID_TIPO_REMU.Value
            .PE_ID_TIPO_CUENTA_REMU = uce_PE_ID_TIPO_CUENTA_REMU.Value
            .PE_ID_MONEDA_CUENTA = uce_PE_ID_MONEDA_CUENTA.Value
            .PE_NUM_CUENTA = txt_PE_NUM_CUENTA.Text
            .PE_ID_SEXO = uos_PE_ID_SEXO.Value
            .PE_ID_NACIONALIDAD = uce_PE_ID_NACIONALIDAD.Value
            .PE_ID_ANEXO_CONTA = Val(txt_PE_ID_ANEXO_CONTA.Text.Trim)
            .PE_ID_GRUPO_SANGUINEO = uce_GRUPO_SANGUINEO.Value
            .PE_HORAS_TRABAJO = Val(txt_PE_HORAS_TRABAJO.Text.Trim)
            .PE_DOMICILIADO = IIf(uchk_PE_DOMICILIADO.Checked, 1, 0)
            .PE_ID_TIPO_VIA = uce_PE_ID_TIPO_VIA.Value
            .PE_NOMBRE_VIA = txt_PE_NOMBRE_VIA.Text.Trim
            .PE_NUMERO_VIA = txt_PE_NUMERO_VIA.Text.Trim
            .PE_INTERIOR = txt_PE_INTERIOR.Text.Trim
            .PE_ID_TIPO_ZONA = uce_PE_ID_TIPO_ZONA.Value
            .PE_NOMBRE_ZONA = txt_PE_NOMBRE_ZONA.Text.Trim
            .PE_REFERENCIA = txt_PE_REFERENCIA.Text.Trim
            .PE_UBIGEO = txt_PE_UBIGEO.Text.Trim
            .PE_ID_TIPO_TRABAJADOR = uce_PE_ID_TIPO_TRABAJADOR.Value
            .PE_ID_NIVEL_EDU = uce_PE_ID_NIVEL_EDU.Value
            .PE_ID_OCUPACION = uce_PE_ID_OCUPACION.Value
            .PE_DISCAPACIDAD = IIf(uchk_PE_DISCAPACIDAD.Checked, 1, 0)

            If ume_PE_FEC_INSCRIP_REG_PEN.Value.ToString = "" Then
                .PE_FEC_INSCRIP_REG_PEN = ""
            Else
                .PE_FEC_INSCRIP_REG_PEN = CDate(ume_PE_FEC_INSCRIP_REG_PEN.Value).ToShortDateString
            End If

            .PE_ID_REGIMEN_LABORAL = uce_PE_ID_REGIMEN_LABORAL.Value
            .PE_SUJETO_JOR_MAX = IIf(uchk_PE_SUJETO_JOR_MAX.Checked, 1, 0)
            .PE_SUJETO_REG_ALT = IIf(uchk_PE_SUJETO_REG_ALT.Checked, 1, 0)
            .PE_FEC_ING = CDate(udte_PE_FEC_ING.Value).ToShortDateString
            If ume_PE_FEC_CESE.Value.ToString = String.Empty Then
                .PE_FEC_CESE = String.Empty
            Else
                .PE_FEC_CESE = CDate(ume_PE_FEC_CESE.Value).ToShortDateString
            End If

            .PE_ID_TIPO_CESE = uce_PE_ID_TIPO_CESE.Value
            .PE_ID_SCTR_SALUD = uce_PE_ID_SCTR_SALUD.Value
            .PE_ID_SCTR_PENSION = uce_PE_ID_SCTR_PENSION.Value
            .PE_SUJETO_HORA_NOC = IIf(uchk_PE_SUJETO_HORA_NOC.Checked, 1, 0)
            .PE_OTRO_ING_5TA = IIf(uchk_PE_OTRO_ING_5TA.Checked, 1, 0)
            .PE_ES_SINDICALIZADO = IIf(uchk_PE_ES_SINDICALIZADO.Checked, 1, 0)
            .PE_ID_PERIODO_REMUNERA = uce_PE_ID_PERIODO_REMUNERA.Value
            .PE_AFILIADO_EPS_SER_PRO = uce_PE_AFILIADO_EPS_SER_PRO.Value
            .PE_ID_COD_EPS_SER_PRO = uce_PE_ID_COD_EPS_SER_PRO.Value
            .PE_ID_SITUACION_EPS = uce_PE_ID_SITUACION_EPS.Value
            .PE_ID_TIPO_PAGO = uce_PE_ID_TIPO_PAGO.Value
            .PE_ID_SITUACION_ESPECIAL = uce_PE_ID_SITUACION_ESPECIAL.Value
            .PE_ID_CLASIFI_PER = uce_PE_ID_CLASIFI_PER.Value
            .PE_ID_PERSONAL = uce_PE_ID_PERSONAL.Value
            .PE_ID_AREA = uce_ID_AREA.Value
            .PE_ASIGNACION_FAM = IIf(uchk_PE_ASIGNACION_FAM.Checked, 1, 0)
            .PE_NUM_HIJOS = une_PE_NUM_HIJOS.Value
            .PE_ID_BANCO_CTS = uce_PE_ID_BANCO_CTS.Value
            .PE_ID_TIPO_CUENTA_CTS = uce_PE_ID_TIPO_CUENTA_CTS.Value
            .PE_NUM_CUENTA_CTS = txt_PE_NUM_CUENTA_CTS.Text.Trim
            .PE_ID_MONEDA_CTS = uce_PE_ID_MONEDA_CTS.Value
            .PE_AFECTO_QUINTA = IIf(uchk_PE_AFECTO_QUINTA.Checked, 1, 0)
            .PE_ID_EMPRESA = gInt_IdEmpresa
            .PE_FICHA = txt_ficha.Text.Trim
            .PE_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PE_TERMINAL = Environment.MachineName
            .PE_FECREG = Date.Now
            .PE_ID_TIPO_PERSO_TARIFA = New BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA With {.TT_ID = uce_PE_ID_TIPO_PERSO_TARIFA.Value}
            .PE_CONSIDERA_FT = IIf(uchk_PE_CONSIDERA_FT.Checked, 1, 0)
            .PE_CALCULAR_CTS = IIf(uchk_Calcular_cts.Checked, 1, 0)
            .PE_COD_INTERBANCA = txt_cod_interbancario.Text.Trim
            .PE_QUINTA_ANT = ume_quinta_ant.Value
            .PE_ES_RIA = IIf(uchk_EsRia.Checked, 1, 0)
            .PE_IDCOMISION = uos_tipo_comi.Value
        End With



        'Cargamos los centro de costos
        Dim lista_ccosto As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO)
        Dim ccostoPersonaBE As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO

        ug_ccosto.UpdateData()
        For i As Integer = 0 To ug_ccosto.Rows.Count - 1
            ccostoPersonaBE = New BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO
            ccostoPersonaBE.CC_CC = New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO With {.CC_CODIGO = ug_ccosto.Rows(i).Cells("CC_CODIGO").Value}
            ccostoPersonaBE.CC_ID_PERSONA = Nothing
            ccostoPersonaBE.CC_PORCENTAJE = ug_ccosto.Rows(i).Cells("PORCENTAJE").Value
            ccostoPersonaBE.CC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            ccostoPersonaBE.CC_TERMINAL = Environment.MachineName
            ccostoPersonaBE.CC_FECREG = Date.Now
            lista_ccosto.Add(ccostoPersonaBE)
        Next



        'Cargamos los contratos
        Dim lista_contratos As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS)
        Dim contrato As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS

        ug_Contratos.UpdateData()
        For i As Integer = 0 To ug_Contratos.Rows.Count - 1
            contrato = New BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS()
            With contrato
                .CO_ID_PERSONAL = Nothing
                .CO_ID_TIPO_CONTRATO = New BE.PlanillaBE.SG_PL_TB_TIPO_CONTRATO With {.TC_ID = ug_Contratos.Rows(i).Cells("CO_ID_TIPO_CONTRATO").Value}
                .CO_FECHA_INI = ug_Contratos.Rows(i).Cells("CO_FECHA_INI").Value
                .CO_FECHA_FIN = ug_Contratos.Rows(i).Cells("CO_FECHA_FIN").Value
                .CO_COMENTARIO = ug_Contratos.Rows(i).Cells("CO_COMENTARIO").Value
                .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .CO_TERMINAL = Environment.MachineName
                .CO_FECREG = Date.Now
            End With
            lista_contratos.Add(contrato)
        Next



        'Cargamos la lista de Conceptos
        Dim lista_conceptos As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO)
        Dim concepto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO

        ug_Conceptos.UpdateData()
        For i As Integer = 0 To ug_Conceptos.Rows.Count - 1
            If Not ug_Conceptos.Rows(i).Cells("PC_ID_CONCEPTO").Value.ToString = "" Then
                concepto = New BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO()
                With concepto
                    .PC_ID_PERSONAL = Nothing
                    .PC_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_Conceptos.Rows(i).Cells("PC_ID_CONCEPTO").Value}
                    .PC_VALOR = ug_Conceptos.Rows(i).Cells("PC_VALOR").Value
                    .PC_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                End With
                lista_conceptos.Add(concepto)
            End If
        Next

        'para guardar la foto
        Dim fotoBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_FOTO
        fotoBE.PF_IDPERSONAL = personaBE.PE_ID
        fotoBE.PF_FOTO = Image2Bytes(upb_img.Image)


      

        If Bol_Nuevo Then

            Dim lista_Telefonos As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION)
            Dim telefono As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION

            'Cargamos los Telefonos
            For i As Integer = 0 To ug_comunicacion_persona.Rows.Count - 1
                telefono = New BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION()
                With telefono
                    .PC_ID = 0
                    .PC_ID_PERSONA = Nothing
                    .PC_ID_COMUNICACION = New BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION With {.TC_ID = ug_comunicacion_persona.Rows(i).Cells("TC_DESCRIPCION").Value}
                    .PC_NUMERO = ug_comunicacion_persona.Rows(i).Cells("PC_NUMERO").Value
                    .PC_DESCRIPCION = ug_comunicacion_persona.Rows(i).Cells("PC_DESCRIPCION").Value
                    .PC_ISTATUS = IIf(ug_comunicacion_persona.Rows(i).Cells("PC_ISTATUS").Value, 1, 0)
                    .PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .PC_TERMINAL = Environment.MachineName
                    .PC_FECREG = Date.Now
                End With
                lista_Telefonos.Add(telefono)
            Next

            'Cargamos los documentos
            Dim lista_documentos As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            Dim documento As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS

            For i As Integer = 0 To ug_Documentos.Rows.Count - 1
                documento = New BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS()
                With documento
                    .DO_ID_PERSONAL = Nothing
                    .DO_NOMBRE_ARCHIVO = ug_Documentos.Rows(i).Cells("DO_NOMBRE_ARCHIVO").Value
                    .DO_DESCRIPCION = ug_Documentos.Rows(i).Cells("DO_DESCRIPCION").Value
                    .DO_FILE = Lista_Doc(ug_Documentos.Rows(i).Cells("DO_ID").Value)
                    .DO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .DO_TERMINAL = Environment.MachineName
                    .DO_FECREG = Date.Now
                End With
                lista_documentos.Add(documento)
            Next

            personaBL.Insert(personaBE, lista_Telefonos, lista_ccosto, lista_documentos, lista_contratos, lista_conceptos, fotoBE)
        Else
            personaBL.Update(personaBE, lista_ccosto, lista_conceptos, fotoBE)
        End If


        fotoBE = Nothing

        Call Avisar("    Listo!      ")
        Call Cargar_Lista_Personal()
        Call Tool_Cancelar_Click(sender, e)


        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        utc_Mante.Tabs(0).Enabled = True
        utc_Mante.Tabs(0).Selected = True
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        For i As Integer = 1 To utc_Mante.Tabs.Count - 1
            utc_Mante.Tabs(i).Enabled = False
        Next

    End Sub

    Private Sub ubtn_ver_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_ver_doc.Click
        If ug_Documentos.ActiveRow Is Nothing Then Exit Sub
        If ug_Documentos.Rows.Count = 0 Then Exit Sub

        Dim docuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_DOCUMENTOS
        Dim docuBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS
        docuBE.DO_ID = ug_Documentos.ActiveRow.Cells("DO_ID").Value
        docuBE.DO_NOMBRE_ARCHIVO = ug_Documentos.ActiveRow.Cells("DO_NOMBRE_ARCHIVO").Value.ToString
        docuBL.Recuperar_Documento_Almacenado(docuBE)
        docuBE = Nothing
        docuBL = Nothing

    End Sub

    Private Sub ug_Contratos_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Contratos.AfterRowUpdate
        If Not Bol_Nuevo Then
            Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
            Dim contratoBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS

            With contratoBE
                .CO_ID = Val(ug_Contratos.ActiveRow.Cells("CO_ID").Value.ToString)
                .CO_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_id_personal.Text.Trim}
                .CO_ID_TIPO_CONTRATO = New BE.PlanillaBE.SG_PL_TB_TIPO_CONTRATO With {.TC_ID = e.Row.Cells("CO_ID_TIPO_CONTRATO").Value}
                .CO_FECHA_INI = e.Row.Cells("CO_FECHA_INI").Value
                .CO_FECHA_FIN = e.Row.Cells("CO_FECHA_FIN").Value
                .CO_COMENTARIO = e.Row.Cells("CO_COMENTARIO").Value
                .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .CO_TERMINAL = Environment.MachineName
                .CO_FECREG = Date.Now
            End With

            If ug_Contratos.ActiveRow.Cells("CO_ID").Text.Trim <> String.Empty Then
                contratoBL.Update(contratoBE)
            Else
                contratoBL.Insert(contratoBE)
                ug_Contratos.ActiveRow.Cells("CO_ID").Value = contratoBE.CO_ID
            End If

            contratoBE = Nothing
            contratoBL = Nothing

        End If
    End Sub

    Private Sub ubtn_Generar_Contrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Generar_Contrato.Click

        Try

            Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
            Dim personaBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_id_personal.Text.Trim}
            Dim dt_datos As DataTable = contratoBL.get_Data_Generar_Contrato(personaBE)
            Dim nombre_modelo As String = ""

            If dt_datos.Rows.Count = 0 Then
                Avisar("No se encontro datos registrados.")
                Exit Sub
            End If

            If dt_datos.Rows(0)("PE_ID_TIPO_PER") = 1 Then 'empleado indeterminado
                nombre_modelo = "Modelo_indefinido"
            End If

            If dt_datos.Rows(0)("PE_ID_TIPO_PER") = 2 Then 'empleado por horas
                nombre_modelo = "Modelo_parcial"
            End If


            ' CARGOS
            '32: ENFERMERA(NEONATOLOGIA)
            '36: TECNICA(NEONATOLOGIA)

            If dt_datos.Rows(0)("PE_ID_CARGO") = 32 Or dt_datos.Rows(0)("PE_ID_CARGO") = 36 Then 'Enfermera/Tecnica Neonatologia
                nombre_modelo = "Modelo_indefinido_Neo"
            End If

            

            Dim Ruta As String = (gStr_RutaRep & "\" & nombre_modelo & ".doc")

            Dim WordApp As Object
            Dim WordDoc As Object

            WordApp = CreateObject("Word.Application")

            WordDoc = WordApp.Documents.Open(Ruta)


            If dt_datos.Rows.Count > 0 Then

                WordApp.Selection.GoTo(Name:="m_cargo")
                WordApp.Selection.TypeText(dt_datos.Rows(0)("CARGO"))

                WordApp.Selection.GoTo(Name:="m_dni")
                WordApp.Selection.TypeText(dt_datos.Rows(0)("DNI"))

                'WordApp.Selection.GoTo(Name:="m_empresa")
                'WordApp.Selection.TypeText(dt_datos.Rows(0)("EMPRESA"))


                WordApp.Selection.GoTo(Name:="m_personal")
                WordApp.Selection.TypeText(dt_datos.Rows(0)("NOMBRE"))

                WordApp.Selection.GoTo(Name:="m_firma")
                WordApp.Selection.TypeText(dt_datos.Rows(0)("NOMBRE"))

                WordApp.Selection.GoTo(Name:="m_direccion")
                WordApp.Selection.TypeText(dt_datos.Rows(0)("DIRECCION"))


                Select Case dt_datos.Rows(0)("PE_ID_CARGO")
                    Case 32 'Enfermera Neonatologia
                        WordApp.Selection.GoTo(Name:="m_sueldo_t")
                        WordApp.Selection.TypeText(Letras(11))

                        WordApp.Selection.GoTo(Name:="m_sueldo")
                        WordApp.Selection.TypeText("11.00")

                    Case 36 'Tecnica Neonatologia
                        WordApp.Selection.GoTo(Name:="m_sueldo_t")
                        WordApp.Selection.TypeText(Letras(6))

                        WordApp.Selection.GoTo(Name:="m_sueldo")
                        WordApp.Selection.TypeText("6.00")

                    Case Else 'otros normales
                        WordApp.Selection.GoTo(Name:="m_sueldo_t")
                        WordApp.Selection.TypeText(Letras(dt_datos.Rows(0)("REMUNERACION")))

                        WordApp.Selection.GoTo(Name:="m_sueldo")
                        WordApp.Selection.TypeText(dt_datos.Rows(0)("REMUNERACION").ToString)
                End Select


                WordApp.Selection.GoTo(Name:="m_dia")
                WordApp.Selection.TypeText(Now.Date.Day.ToString.PadLeft(2, "0"))

                WordApp.Selection.GoTo(Name:="m_mes")
                WordApp.Selection.TypeText(get_Nombre_Mes(Now.Date.Month))

                WordApp.Selection.GoTo(Name:="m_ayo")
                WordApp.Selection.TypeText(Now.Date.Year.ToString)

                If Not (dt_datos.Rows(0)("PE_ID_CARGO") = 32 Or dt_datos.Rows(0)("PE_ID_CARGO") = 36) Then 'Enfermera/Tecnica Neonatologia
                    WordApp.Selection.GoTo(Name:="m_fec_ing")
                    WordApp.Selection.TypeText(CDate(dt_datos.Rows(0)("PE_FEC_ING")).ToShortDateString)
                End If


                Dim nombre_nuevo As String = Now.Date.Day.ToString & Now.Date.Month.ToString & Now.Date.Year.ToString & Now.Second.ToString & Now.Minute.ToString & Now.Hour.ToString & ".doc"

                WordDoc.SaveAs(Application.StartupPath & "\" & nombre_nuevo)
                WordDoc.Close()
                WordDoc = Nothing
                Process.Start(Application.StartupPath & "\" & nombre_nuevo)

            End If

            dt_datos.Dispose()

        Catch ex As Exception
            Avisar(ex.Message & Chr(13) & "El problema puede ser por la version del Office, revise su instalacion.")
        End Try
    End Sub

    Private Sub txt_PE_CODIGO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PE_CODIGO.KeyDown, txt_PE_CODIGO_ALT.KeyDown, txt_PE_APE_PAT.KeyDown, udte_PE_FEC_NAC.KeyDown, uce_PE_ID_TIPO_ZONA.KeyDown, uce_PE_ID_TIPO_VIA.KeyDown, uce_PE_ID_TIPO_DOC_PER.KeyDown, uce_PE_ID_NACIONALIDAD.KeyDown, uce_PE_ID_EST_CIVIL.KeyDown, txt_PE_REFERENCIA.KeyDown, txt_PE_NUMERO_VIA.KeyDown, txt_PE_NUM_DOC_PER.KeyDown, txt_PE_NOMBRE_ZONA.KeyDown, txt_PE_NOMBRE_VIA.KeyDown, txt_PE_NOM_SEG.KeyDown, txt_PE_NOM_PRI.KeyDown, txt_PE_INTERIOR.KeyDown, txt_PE_APE_MAT.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_PE_UBIGEO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PE_UBIGEO.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
        If e.KeyCode = Keys.F2 Then
            PL_MA_Ubigeo.ShowDialog()
            If PL_MA_Ubigeo.Bol_Aceptar Then
                txt_PE_UBIGEO.Text = PL_MA_Ubigeo.Str_Ubigeo.ToString
            End If
        End If
    End Sub

    Private Sub ug_Contratos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Contratos.BeforeRowsDeleted

        If Not Bol_Nuevo Then
            e.DisplayPromptMsg = False
            Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
            Dim contratoBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS
            contratoBE.CO_ID = ug_Contratos.ActiveRow.Cells("CO_ID").Value
            contratoBL.Delete(contratoBE)
            contratoBL = Nothing
        End If

    End Sub

    Private Sub uce_PE_ID_TIPO_PER_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_PE_ID_TIPO_PER.ValueChanged
        If uce_PE_ID_TIPO_PER.Value = 1 Then
            uce_PE_ID_TIPO_PERSO_TARIFA.SelectedIndex = -1
            uce_PE_ID_TIPO_PERSO_TARIFA.Enabled = False
            'txt_PE_HORAS_TRABAJO.Enabled = True
        End If

        If uce_PE_ID_TIPO_PER.Value = 2 Then
            uce_PE_ID_TIPO_PERSO_TARIFA.Enabled = True
            uce_PE_ID_TIPO_PERSO_TARIFA.SelectedIndex = -1
            uchk_Calcular_cts.Checked = False
            'txt_PE_HORAS_TRABAJO.Enabled = False
            'txt_PE_HORAS_TRABAJO.Text = String.Empty
        End If

    End Sub

    Private Sub ug_Conceptos_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ug_Conceptos.AfterCellUpdate

        If e.Cell.Column.Index = 1 Then
            Dim cod_concepto As String = e.Cell.Row.Cells("PC_ID_CONCEPTO").Value
            Dim tipoConcetoBL As New BL.PlanillaBL.SG_PL_TB_TIPO_CONCEPTO
            ug_Conceptos.ActiveRow.Cells("TIPO").Value = tipoConcetoBL.get_Tipo_X_Concepto(cod_concepto, gInt_IdEmpresa)
            tipoConcetoBL = Nothing
        End If

    End Sub

    Private Sub uce_PE_ID_TIPO_CESE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            uce_PE_ID_TIPO_CESE.SelectedIndex = -1
        End If
    End Sub

    Private Sub uce_PE_ID_AFP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_PE_ID_AFP.KeyDown, ume_PE_FEC_INSCRIP_REG_PEN.KeyDown, ume_PE_FEC_CESE.KeyDown, udte_PE_FEC_ING.KeyDown, uce_IMP_REMU.KeyDown, uce_PE_ID_TIPO_TRABAJADOR.KeyDown, uce_PE_ID_TIPO_REMU.KeyDown, uce_PE_ID_TIPO_PER.KeyDown, uce_PE_ID_TIPO_CUENTA_REMU.KeyDown, uce_PE_ID_TIPO_CUENTA_CTS.KeyDown, uce_PE_ID_REGIMEN_LABORAL.KeyDown, uce_PE_ID_PERSONAL.KeyDown, uce_PE_ID_OCUPACION.KeyDown, uce_PE_ID_NIVEL_EDU.KeyDown, uce_PE_ID_MONEDA_REMU.KeyDown, uce_PE_ID_MONEDA_CUENTA.KeyDown, uce_PE_ID_MONEDA_CTS.KeyDown, uce_PE_ID_EST_TRABAJADOR.KeyDown, uce_PE_ID_CARGO.KeyDown, uce_PE_ID_BANCO_CTS.KeyDown, txt_PE_NUM_IPSS.KeyDown, txt_PE_NUM_CUENTA_CTS.KeyDown, txt_PE_NUM_CUENTA.KeyDown, txt_PE_NUM_AFP.KeyDown, txt_PE_HORAS_TRABAJO.KeyDown

        If e.KeyCode = Keys.Delete Then sender.SelectedIndex = -1
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)

    End Sub

    Private Sub uce_PE_ID_AFP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_PE_ID_AFP.ValueChanged

        If uce_PE_ID_AFP.SelectedIndex = -1 Then
            'txt_PE_NUM_AFP.Enabled = False
            'txt_PE_NUM_AFP.Text = String.Empty
        Else
            txt_PE_NUM_AFP.Enabled = True
        End If

    End Sub

    Private Sub uce_PE_ID_TIPO_CESE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_PE_ID_TIPO_CESE.ValueChanged

        If uce_PE_ID_TIPO_CESE.SelectedIndex = -1 Then
            ume_PE_FEC_CESE.Enabled = False
            ume_PE_FEC_CESE.Value = Nothing
        Else
            ume_PE_FEC_CESE.Enabled = True
        End If


    End Sub

    Private Sub uce_PE_ID_EST_TRABAJADOR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_PE_ID_EST_TRABAJADOR.ValueChanged

        '1=activo
        '2=cesante

        If uce_PE_ID_EST_TRABAJADOR.Value = "1" Then
            uce_PE_ID_TIPO_CESE.SelectedIndex = -1
            uce_PE_ID_TIPO_CESE.Enabled = False
        Else
            uce_PE_ID_TIPO_CESE.Enabled = True
        End If
    End Sub

    Private Sub ug_Listado_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Listado.DoubleClickRow
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub
        If ug_Listado.ActiveRow.Cells("PE_ID").Value.ToString = "" Then Exit Sub
        Call Editar_Datos()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub uce_PE_ID_CARGO_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_PE_ID_CARGO.EditorButtonClick
        PL_MA_Cargo.ShowDialog()
        Call Cargar_Cargos_Trabajador()
    End Sub

    Private Sub uce_PE_ID_AREA_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_ID_AREA.EditorButtonClick
        PL_MA_Area.ShowDialog()
        Call Cargar_Areas()
    End Sub

    Private Sub uce_PE_ID_GRUPO_SANGUINEO_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_GRUPO_SANGUINEO.EditorButtonClick
        PL_MA_GrupoSanguineo.ShowDialog()
        Call Cargar_GrupoSanguineo()
    End Sub

    Private Sub uce_PE_ID_TIPO_PERSO_TARIFA_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_PE_ID_TIPO_PERSO_TARIFA.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

        If e.KeyCode = Keys.Delete Then
            uce_PE_ID_TIPO_PERSO_TARIFA.SelectedIndex = -1
        End If

    End Sub

    Private Sub uce_PE_ID_TIPO_CESE_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_PE_ID_TIPO_CESE.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

        If e.KeyCode = Keys.Delete Then
            uce_PE_ID_TIPO_CESE.SelectedIndex = -1
        End If
    End Sub

    Private Sub uos_PE_ID_SEXO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uos_PE_ID_SEXO.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_PE_ID_TIPO_VIA.Focus()
        End If
    End Sub

    Private Sub Tool_Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Reporte.Click
        PL_MA_Opc_Reporte.ShowDialog()

        If PL_MA_Opc_Reporte.bol_salir Then
            Exit Sub
        End If

        If PL_MA_Opc_Reporte.bol_listado Then
            Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
            Dim crystalBL As New LR.ClsReporte
            Dim dt_data As DataTable = reportesBL.getPersonal_Rep_Lista(gInt_IdEmpresa, IIf(PL_MA_Opc_Reporte.bol_activos, 1, 0))

            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_06.rpt", dt_data, "", "pEmpresa;" & gStr_NomEmpresa)

            crystalBL.Dispose()
            reportesBL = Nothing
        End If

        If PL_MA_Opc_Reporte.bol_ficha Then

            Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
            Dim crystalBL As New LR.ClsReporte
            Dim dt_data As DataTable = reportesBL.getPersonal_Rep_Ficha(ug_Listado.ActiveRow.Cells("PE_ID").Value)

            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_07.rpt", dt_data, "", "pEmpresa;" & gStr_NomEmpresa)

            crystalBL.Dispose()
            reportesBL = Nothing
        End If
    End Sub

    Private Sub uce_PE_IMPORTE_REMUNERACION_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_IMP_REMU.EditorButtonClick

        If txt_id_personal.Text.Trim.Length = 0 Then Exit Sub

        PL_MA_Personal_Remu.int_idpersonal = txt_id_personal.Text.Trim

        If Val(uce_IMP_REMU.Value.ToString) = 0 Then
            PL_MA_Personal_Remu.dbl_sueldo_inicial = 0
        Else
            PL_MA_Personal_Remu.dbl_sueldo_inicial = uce_IMP_REMU.Value
        End If

        PL_MA_Personal_Remu.dat_fecha_inicial = udte_PE_FEC_ING.Value
        PL_MA_Personal_Remu.ShowDialog()

        Dim remuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_REMUNERACION
        uce_IMP_REMU.Value = remuBL.get_Ultima_Remuneracion(New BE.PlanillaBE.SG_PL_TB_PERSONAL_REMUNERACION _
                                                                           With {.PR_IDPERSONAL = txt_id_personal.Text.Trim})
        remuBL = Nothing

    End Sub

    Private Sub ug_Listado_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Listado.InitializeRow
        If e.Row.Cells("ESTADO").Value = "C" Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

End Class

