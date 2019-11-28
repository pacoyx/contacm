<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_MA_HistoClini_DatGen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NUM_HIST")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_id")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_NOMBRE")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_APE_PAT")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_APE_MAT")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_APE_CASADA")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NOMBRE1")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NOMBRE2")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_TDOC")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NDOC")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_FNAC")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_FING")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_SEXO")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_EST_CIVIL")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_DIR")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_OCUPACION")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDNACIONALIDAD")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_UBIGEO")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDGRUPO_S")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDCONDICION")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDRECOMENDACION")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDMEDICO")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_FNAC_TITU")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_TITULAR")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_UBICACION")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_ALERGIAS")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_TIPO_H_C")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_EDAD_REG")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_DetRecom")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NUM_HIST")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_id")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_NOMBRE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_APE_PAT")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_APE_MAT")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_APE_CASADA")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NOMBRE1")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NOMBRE2")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_TDOC")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NDOC")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_FNAC")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_FING")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_SEXO")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_EST_CIVIL")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_DIR")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_OCUPACION")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDNACIONALIDAD")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_UBIGEO")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDGRUPO_S")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDCONDICION")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDRECOMENDACION")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDMEDICO")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_FNAC_TITU")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_TITULAR")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_UBICACION")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_ALERGIAS")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_TIPO_H_C")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_EDAD_REG")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_DetRecom")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Comunicacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Comunicaciones = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.utxt_Documento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_Historia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_Nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_ApeCas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_ApeMat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uck_Doc = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Historia = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Nombres = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_ApeCas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_ApeMat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_ApePat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_ApePat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.ug_Lista_Hist_Clin = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_ListaHC = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utxt_Detalle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubt_Reniec = New Infragistics.Win.Misc.UltraButton()
        Me.utxtEdad = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.utxt_Ubicacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.utxt_Alergias = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucb_GrupoS = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucb_MedicoT = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fec_NacTitular = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.utxt_Titular = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucb_Condicion = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucb_recomendado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_NombreC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.uce_Ubigeo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Provincia = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Departamento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_ocupacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_dir = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_fec_reg = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_fec_nac = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uos_sexo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Nacionalidad = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_est_civil = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_ape_pat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ape_cas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ape_mat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_nom1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_nom2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel65 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_codigos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.lbl_estado = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucb_TipoHC = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_cod_id = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_histo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.utc_historia = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.ug_Comunicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Comunicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.utxt_Documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Historia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_ApeCas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_ApeMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ApePat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista_Hist_Clin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ListaHC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.utxt_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxtEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Ubicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Alergias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucb_GrupoS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucb_MedicoT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_NacTitular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Titular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucb_Condicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucb_recomendado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NombreC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.uce_Ubigeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Provincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Departamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ocupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_nac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_sexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Nacionalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_est_civil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ape_pat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ape_cas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ape_mat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_codigos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_codigos.SuspendLayout()
        CType(Me.ucb_TipoHC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_histo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_historia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_historia.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.ug_Comunicacion)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(396, 155)
        '
        'ug_Comunicacion
        '
        Me.ug_Comunicacion.DataSource = Me.uds_Comunicaciones
        Me.ug_Comunicacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 128
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 219
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ug_Comunicacion.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Comunicacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Comunicacion.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Comunicacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Comunicacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_Comunicacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Comunicacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Comunicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Comunicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Comunicacion.Location = New System.Drawing.Point(0, 0)
        Me.ug_Comunicacion.Name = "ug_Comunicacion"
        Me.ug_Comunicacion.Size = New System.Drawing.Size(396, 155)
        Me.ug_Comunicacion.TabIndex = 26
        Me.ug_Comunicacion.Text = "UltraGrid1"
        '
        'uds_Comunicaciones
        '
        Me.uds_Comunicaciones.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.utxt_Documento)
        Me.UltraTabPageControl1.Controls.Add(Me.utxt_Historia)
        Me.UltraTabPageControl1.Controls.Add(Me.utxt_Nombres)
        Me.UltraTabPageControl1.Controls.Add(Me.utxt_ApeCas)
        Me.UltraTabPageControl1.Controls.Add(Me.utxt_ApeMat)
        Me.UltraTabPageControl1.Controls.Add(Me.uck_Doc)
        Me.UltraTabPageControl1.Controls.Add(Me.uck_Historia)
        Me.UltraTabPageControl1.Controls.Add(Me.uck_Nombres)
        Me.UltraTabPageControl1.Controls.Add(Me.uck_ApeCas)
        Me.UltraTabPageControl1.Controls.Add(Me.uck_ApeMat)
        Me.UltraTabPageControl1.Controls.Add(Me.uck_ApePat)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_ApePat)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Consultar)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista_Hist_Clin)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(892, 447)
        '
        'utxt_Documento
        '
        Me.utxt_Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Documento.Location = New System.Drawing.Point(618, 38)
        Me.utxt_Documento.MaxLength = 50
        Me.utxt_Documento.Name = "utxt_Documento"
        Me.utxt_Documento.Size = New System.Drawing.Size(124, 21)
        Me.utxt_Documento.TabIndex = 23
        '
        'utxt_Historia
        '
        Me.utxt_Historia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Historia.Location = New System.Drawing.Point(618, 11)
        Me.utxt_Historia.MaxLength = 50
        Me.utxt_Historia.Name = "utxt_Historia"
        Me.utxt_Historia.Size = New System.Drawing.Size(124, 21)
        Me.utxt_Historia.TabIndex = 21
        '
        'utxt_Nombres
        '
        Me.utxt_Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Nombres.Location = New System.Drawing.Point(347, 38)
        Me.utxt_Nombres.MaxLength = 50
        Me.utxt_Nombres.Name = "utxt_Nombres"
        Me.utxt_Nombres.Size = New System.Drawing.Size(164, 21)
        Me.utxt_Nombres.TabIndex = 19
        '
        'utxt_ApeCas
        '
        Me.utxt_ApeCas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_ApeCas.Location = New System.Drawing.Point(378, 11)
        Me.utxt_ApeCas.MaxLength = 50
        Me.utxt_ApeCas.Name = "utxt_ApeCas"
        Me.utxt_ApeCas.Size = New System.Drawing.Size(133, 21)
        Me.utxt_ApeCas.TabIndex = 17
        '
        'utxt_ApeMat
        '
        Me.utxt_ApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_ApeMat.Location = New System.Drawing.Point(118, 38)
        Me.utxt_ApeMat.MaxLength = 50
        Me.utxt_ApeMat.Name = "utxt_ApeMat"
        Me.utxt_ApeMat.Size = New System.Drawing.Size(133, 21)
        Me.utxt_ApeMat.TabIndex = 15
        '
        'uck_Doc
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uck_Doc.Appearance = Appearance5
        Me.uck_Doc.BackColor = System.Drawing.Color.Transparent
        Me.uck_Doc.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Doc.Location = New System.Drawing.Point(535, 39)
        Me.uck_Doc.Name = "uck_Doc"
        Me.uck_Doc.Size = New System.Drawing.Size(86, 22)
        Me.uck_Doc.TabIndex = 22
        Me.uck_Doc.Text = "Nº Doc"
        '
        'uck_Historia
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.uck_Historia.Appearance = Appearance2
        Me.uck_Historia.BackColor = System.Drawing.Color.Transparent
        Me.uck_Historia.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Historia.Location = New System.Drawing.Point(535, 11)
        Me.uck_Historia.Name = "uck_Historia"
        Me.uck_Historia.Size = New System.Drawing.Size(86, 22)
        Me.uck_Historia.TabIndex = 20
        Me.uck_Historia.Text = "Nº Historia"
        '
        'uck_Nombres
        '
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.uck_Nombres.Appearance = Appearance7
        Me.uck_Nombres.BackColor = System.Drawing.Color.Transparent
        Me.uck_Nombres.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Nombres.Location = New System.Drawing.Point(272, 39)
        Me.uck_Nombres.Name = "uck_Nombres"
        Me.uck_Nombres.Size = New System.Drawing.Size(107, 22)
        Me.uck_Nombres.TabIndex = 18
        Me.uck_Nombres.Text = "Nombres"
        '
        'uck_ApeCas
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.uck_ApeCas.Appearance = Appearance6
        Me.uck_ApeCas.BackColor = System.Drawing.Color.Transparent
        Me.uck_ApeCas.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_ApeCas.Location = New System.Drawing.Point(272, 11)
        Me.uck_ApeCas.Name = "uck_ApeCas"
        Me.uck_ApeCas.Size = New System.Drawing.Size(107, 22)
        Me.uck_ApeCas.TabIndex = 16
        Me.uck_ApeCas.Text = "Apellido Casada"
        '
        'uck_ApeMat
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uck_ApeMat.Appearance = Appearance4
        Me.uck_ApeMat.BackColor = System.Drawing.Color.Transparent
        Me.uck_ApeMat.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_ApeMat.Location = New System.Drawing.Point(9, 39)
        Me.uck_ApeMat.Name = "uck_ApeMat"
        Me.uck_ApeMat.Size = New System.Drawing.Size(116, 22)
        Me.uck_ApeMat.TabIndex = 14
        Me.uck_ApeMat.Text = "Apellido Materno"
        '
        'uck_ApePat
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uck_ApePat.Appearance = Appearance3
        Me.uck_ApePat.BackColor = System.Drawing.Color.Transparent
        Me.uck_ApePat.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_ApePat.Location = New System.Drawing.Point(9, 11)
        Me.uck_ApePat.Name = "uck_ApePat"
        Me.uck_ApePat.Size = New System.Drawing.Size(107, 22)
        Me.uck_ApePat.TabIndex = 12
        Me.uck_ApePat.Text = "Apellido Paterno"
        '
        'txt_ApePat
        '
        Me.txt_ApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ApePat.Location = New System.Drawing.Point(118, 11)
        Me.txt_ApePat.MaxLength = 50
        Me.txt_ApePat.Name = "txt_ApePat"
        Me.txt_ApePat.Size = New System.Drawing.Size(133, 21)
        Me.txt_ApePat.TabIndex = 13
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance15.FontData.SizeInPoints = 8.0!
        Appearance15.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Consultar.Appearance = Appearance15
        Me.ubtn_Consultar.Location = New System.Drawing.Point(756, 21)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(120, 24)
        Me.ubtn_Consultar.TabIndex = 1
        Me.ubtn_Consultar.Text = "Consultar"
        '
        'ug_Lista_Hist_Clin
        '
        Me.ug_Lista_Hist_Clin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista_Hist_Clin.DataSource = Me.uds_ListaHC
        Me.ug_Lista_Hist_Clin.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Nº HISTORIA C."
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Width = 70
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "APELLIDOS Y NOMBRES"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Width = 270
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 161
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 130
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 131
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Nº DOCUMENTO"
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "F. NACIMIENTO"
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 11
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 13
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.Caption = "DIRECCIÓN"
        UltraGridColumn17.Header.VisiblePosition = 14
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 15
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.VisiblePosition = 16
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.VisiblePosition = 17
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.Header.VisiblePosition = 19
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.Header.VisiblePosition = 20
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.VisiblePosition = 21
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.VisiblePosition = 22
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.Header.VisiblePosition = 23
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn27.Header.VisiblePosition = 24
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn28.Header.VisiblePosition = 25
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn29.Header.VisiblePosition = 26
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn30.Header.VisiblePosition = 27
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn31.Header.VisiblePosition = 28
        UltraGridColumn31.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        Me.ug_Lista_Hist_Clin.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Lista_Hist_Clin.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista_Hist_Clin.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista_Hist_Clin.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista_Hist_Clin.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Lista_Hist_Clin.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista_Hist_Clin.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista_Hist_Clin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista_Hist_Clin.Location = New System.Drawing.Point(3, 69)
        Me.ug_Lista_Hist_Clin.Name = "ug_Lista_Hist_Clin"
        Me.ug_Lista_Hist_Clin.Size = New System.Drawing.Size(886, 377)
        Me.ug_Lista_Hist_Clin.TabIndex = 2
        Me.ug_Lista_Hist_Clin.Text = "UltraGrid1"
        '
        'uds_ListaHC
        '
        Me.uds_ListaHC.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Long)
        UltraDataColumn4.DataType = GetType(Long)
        UltraDataColumn11.DataType = GetType(Integer)
        UltraDataColumn12.DataType = GetType(Integer)
        UltraDataColumn21.DataType = GetType(Integer)
        UltraDataColumn22.DataType = GetType(Integer)
        UltraDataColumn23.DataType = GetType(Integer)
        UltraDataColumn27.DataType = GetType(Integer)
        UltraDataColumn29.DataType = GetType(UInteger)
        UltraDataColumn30.DataType = GetType(Integer)
        Me.uds_ListaHC.Band.Columns.AddRange(New Object() {UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(892, 447)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ugb_datos)
        Me.UltraGroupBox1.Controls.Add(Me.ugb_codigos)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(882, 436)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.utxt_Detalle)
        Me.ugb_datos.Controls.Add(Me.ubt_Reniec)
        Me.ugb_datos.Controls.Add(Me.utxtEdad)
        Me.ugb_datos.Controls.Add(Me.UltraLabel28)
        Me.ugb_datos.Controls.Add(Me.utxt_Ubicacion)
        Me.ugb_datos.Controls.Add(Me.UltraLabel27)
        Me.ugb_datos.Controls.Add(Me.utxt_Alergias)
        Me.ugb_datos.Controls.Add(Me.UltraLabel26)
        Me.ugb_datos.Controls.Add(Me.UltraLabel25)
        Me.ugb_datos.Controls.Add(Me.ucb_GrupoS)
        Me.ugb_datos.Controls.Add(Me.UltraLabel24)
        Me.ugb_datos.Controls.Add(Me.ucb_MedicoT)
        Me.ugb_datos.Controls.Add(Me.UltraLabel23)
        Me.ugb_datos.Controls.Add(Me.udte_fec_NacTitular)
        Me.ugb_datos.Controls.Add(Me.utxt_Titular)
        Me.ugb_datos.Controls.Add(Me.UltraLabel21)
        Me.ugb_datos.Controls.Add(Me.UltraLabel22)
        Me.ugb_datos.Controls.Add(Me.ucb_Condicion)
        Me.ugb_datos.Controls.Add(Me.UltraLabel20)
        Me.ugb_datos.Controls.Add(Me.ucb_recomendado)
        Me.ugb_datos.Controls.Add(Me.txt_NombreC)
        Me.ugb_datos.Controls.Add(Me.UltraLabel19)
        Me.ugb_datos.Controls.Add(Me.UltraLabel18)
        Me.ugb_datos.Controls.Add(Me.UltraTabControl1)
        Me.ugb_datos.Controls.Add(Me.uce_Ubigeo)
        Me.ugb_datos.Controls.Add(Me.UltraLabel17)
        Me.ugb_datos.Controls.Add(Me.uce_Provincia)
        Me.ugb_datos.Controls.Add(Me.UltraLabel16)
        Me.ugb_datos.Controls.Add(Me.uce_Departamento)
        Me.ugb_datos.Controls.Add(Me.txt_ocupacion)
        Me.ugb_datos.Controls.Add(Me.txt_dir)
        Me.ugb_datos.Controls.Add(Me.txt_num_doc)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_datos.Controls.Add(Me.UltraLabel10)
        Me.ugb_datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_datos.Controls.Add(Me.udte_fec_reg)
        Me.ugb_datos.Controls.Add(Me.udte_fec_nac)
        Me.ugb_datos.Controls.Add(Me.uos_sexo)
        Me.ugb_datos.Controls.Add(Me.UltraLabel11)
        Me.ugb_datos.Controls.Add(Me.UltraLabel15)
        Me.ugb_datos.Controls.Add(Me.UltraLabel14)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel12)
        Me.ugb_datos.Controls.Add(Me.uce_Nacionalidad)
        Me.ugb_datos.Controls.Add(Me.uce_est_civil)
        Me.ugb_datos.Controls.Add(Me.txt_ape_pat)
        Me.ugb_datos.Controls.Add(Me.txt_ape_cas)
        Me.ugb_datos.Controls.Add(Me.txt_ape_mat)
        Me.ugb_datos.Controls.Add(Me.txt_nom1)
        Me.ugb_datos.Controls.Add(Me.txt_nom2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.UltraLabel65)
        Me.ugb_datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_datos.Location = New System.Drawing.Point(13, 65)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(856, 368)
        Me.ugb_datos.TabIndex = 43
        '
        'utxt_Detalle
        '
        Me.utxt_Detalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Detalle.Location = New System.Drawing.Point(14, 341)
        Me.utxt_Detalle.MaxLength = 100
        Me.utxt_Detalle.Name = "utxt_Detalle"
        Me.utxt_Detalle.Size = New System.Drawing.Size(422, 21)
        Me.utxt_Detalle.TabIndex = 67
        '
        'ubt_Reniec
        '
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubt_Reniec.Appearance = Appearance54
        Me.ubt_Reniec.Location = New System.Drawing.Point(424, 75)
        Me.ubt_Reniec.Name = "ubt_Reniec"
        Me.ubt_Reniec.Size = New System.Drawing.Size(32, 23)
        Me.ubt_Reniec.TabIndex = 66
        '
        'utxtEdad
        '
        Me.utxtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxtEdad.Location = New System.Drawing.Point(653, 46)
        Me.utxtEdad.MaxLength = 50
        Me.utxtEdad.Name = "utxtEdad"
        Me.utxtEdad.ReadOnly = True
        Me.utxtEdad.Size = New System.Drawing.Size(42, 21)
        Me.utxtEdad.TabIndex = 65
        '
        'UltraLabel28
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel28.Appearance = Appearance9
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(621, 50)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel28.TabIndex = 64
        Me.UltraLabel28.Text = "Edad"
        '
        'utxt_Ubicacion
        '
        Me.utxt_Ubicacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.utxt_Ubicacion.Location = New System.Drawing.Point(305, 287)
        Me.utxt_Ubicacion.Name = "utxt_Ubicacion"
        Me.utxt_Ubicacion.Size = New System.Drawing.Size(131, 21)
        Me.utxt_Ubicacion.TabIndex = 63
        '
        'UltraLabel27
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel27.Appearance = Appearance22
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Location = New System.Drawing.Point(226, 291)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel27.TabIndex = 62
        Me.UltraLabel27.Text = "Ubicación H.C."
        '
        'utxt_Alergias
        '
        Me.utxt_Alergias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Alergias.Location = New System.Drawing.Point(91, 287)
        Me.utxt_Alergias.MaxLength = 100
        Me.utxt_Alergias.Name = "utxt_Alergias"
        Me.utxt_Alergias.Size = New System.Drawing.Size(129, 21)
        Me.utxt_Alergias.TabIndex = 24
        '
        'UltraLabel26
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel26.Appearance = Appearance27
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(12, 291)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel26.TabIndex = 60
        Me.UltraLabel26.Text = "Alergias"
        '
        'UltraLabel25
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance23
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(462, 81)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel25.TabIndex = 58
        Me.UltraLabel25.Text = "Grupo Sang."
        '
        'ucb_GrupoS
        '
        Me.ucb_GrupoS.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucb_GrupoS.Location = New System.Drawing.Point(532, 78)
        Me.ucb_GrupoS.Name = "ucb_GrupoS"
        Me.ucb_GrupoS.Size = New System.Drawing.Size(163, 21)
        Me.ucb_GrupoS.TabIndex = 10
        '
        'UltraLabel24
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance16
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(12, 262)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(75, 14)
        Me.UltraLabel24.TabIndex = 56
        Me.UltraLabel24.Text = "Med. Tratante"
        '
        'ucb_MedicoT
        '
        Me.ucb_MedicoT.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucb_MedicoT.Location = New System.Drawing.Point(91, 258)
        Me.ucb_MedicoT.Name = "ucb_MedicoT"
        Me.ucb_MedicoT.Size = New System.Drawing.Size(345, 21)
        Me.ucb_MedicoT.TabIndex = 21
        '
        'UltraLabel23
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance61
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(239, 202)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(95, 14)
        Me.UltraLabel23.TabIndex = 54
        Me.UltraLabel23.Text = "Fecha Nac. Resp."
        '
        'udte_fec_NacTitular
        '
        Me.udte_fec_NacTitular.Location = New System.Drawing.Point(336, 198)
        Me.udte_fec_NacTitular.Name = "udte_fec_NacTitular"
        Me.udte_fec_NacTitular.Size = New System.Drawing.Size(100, 21)
        Me.udte_fec_NacTitular.TabIndex = 19
        '
        'utxt_Titular
        '
        Me.utxt_Titular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Titular.Location = New System.Drawing.Point(91, 228)
        Me.utxt_Titular.MaxLength = 100
        Me.utxt_Titular.Name = "utxt_Titular"
        Me.utxt_Titular.Size = New System.Drawing.Size(345, 21)
        Me.utxt_Titular.TabIndex = 20
        '
        'UltraLabel21
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance24
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(12, 205)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel21.TabIndex = 51
        Me.UltraLabel21.Text = "Condición"
        '
        'UltraLabel22
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance31
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(12, 233)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel22.TabIndex = 52
        Me.UltraLabel22.Text = "Titular o Resp."
        '
        'ucb_Condicion
        '
        Me.ucb_Condicion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucb_Condicion.Location = New System.Drawing.Point(91, 198)
        Me.ucb_Condicion.Name = "ucb_Condicion"
        Me.ucb_Condicion.Size = New System.Drawing.Size(140, 21)
        Me.ucb_Condicion.TabIndex = 18
        '
        'UltraLabel20
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance37
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(12, 321)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel20.TabIndex = 48
        Me.UltraLabel20.Text = "Recomendado"
        '
        'ucb_recomendado
        '
        Me.ucb_recomendado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucb_recomendado.Location = New System.Drawing.Point(91, 317)
        Me.ucb_recomendado.Name = "ucb_recomendado"
        Me.ucb_recomendado.Size = New System.Drawing.Size(140, 21)
        Me.ucb_recomendado.TabIndex = 22
        '
        'txt_NombreC
        '
        Me.txt_NombreC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NombreC.Enabled = False
        Me.txt_NombreC.Location = New System.Drawing.Point(449, 158)
        Me.txt_NombreC.MaxLength = 50
        Me.txt_NombreC.Name = "txt_NombreC"
        Me.txt_NombreC.Size = New System.Drawing.Size(400, 21)
        Me.txt_NombreC.TabIndex = 17
        '
        'UltraLabel19
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance21
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(450, 140)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(108, 14)
        Me.UltraLabel19.TabIndex = 46
        Me.UltraLabel19.Text = "Apellidos y Nombres"
        '
        'UltraLabel18
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance8
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(625, 112)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel18.TabIndex = 44
        Me.UltraLabel18.Text = "Distrito"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Location = New System.Drawing.Point(449, 181)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl1.Size = New System.Drawing.Size(400, 181)
        Me.UltraTabControl1.TabIndex = 44
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Comunicacion"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(396, 155)
        '
        'uce_Ubigeo
        '
        Me.uce_Ubigeo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Ubigeo.Location = New System.Drawing.Point(672, 108)
        Me.uce_Ubigeo.Name = "uce_Ubigeo"
        Me.uce_Ubigeo.Size = New System.Drawing.Size(177, 21)
        Me.uce_Ubigeo.TabIndex = 13
        '
        'UltraLabel17
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance10
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(325, 112)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel17.TabIndex = 42
        Me.UltraLabel17.Text = "Provincia"
        '
        'uce_Provincia
        '
        Me.uce_Provincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Provincia.Location = New System.Drawing.Point(381, 108)
        Me.uce_Provincia.Name = "uce_Provincia"
        Me.uce_Provincia.Size = New System.Drawing.Size(220, 21)
        Me.uce_Provincia.TabIndex = 12
        '
        'UltraLabel16
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance12
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(12, 112)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel16.TabIndex = 40
        Me.UltraLabel16.Text = "Departamento"
        '
        'uce_Departamento
        '
        Me.uce_Departamento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Departamento.Location = New System.Drawing.Point(91, 108)
        Me.uce_Departamento.Name = "uce_Departamento"
        Me.uce_Departamento.Size = New System.Drawing.Size(214, 21)
        Me.uce_Departamento.TabIndex = 11
        '
        'txt_ocupacion
        '
        Me.txt_ocupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ocupacion.Location = New System.Drawing.Point(305, 168)
        Me.txt_ocupacion.MaxLength = 100
        Me.txt_ocupacion.Name = "txt_ocupacion"
        Me.txt_ocupacion.Size = New System.Drawing.Size(131, 21)
        Me.txt_ocupacion.TabIndex = 16
        '
        'txt_dir
        '
        Me.txt_dir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_dir.Location = New System.Drawing.Point(91, 139)
        Me.txt_dir.MaxLength = 150
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(345, 21)
        Me.txt_dir.TabIndex = 14
        '
        'txt_num_doc
        '
        Me.txt_num_doc.Location = New System.Drawing.Point(305, 77)
        Me.txt_num_doc.MaxLength = 50
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(118, 21)
        Me.txt_num_doc.TabIndex = 9
        '
        'UltraLabel8
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance18
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(239, 81)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel8.TabIndex = 38
        Me.UltraLabel8.Text = "Num. Doc"
        '
        'UltraLabel9
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance41
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(12, 78)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel9.TabIndex = 36
        Me.UltraLabel9.Text = "Tipo Doc"
        '
        'UltraLabel13
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance25
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(239, 321)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel13.TabIndex = 35
        Me.UltraLabel13.Text = "Fecha Reg."
        '
        'UltraLabel10
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance32
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(461, 50)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel10.TabIndex = 35
        Me.UltraLabel10.Text = "Fecha Nac."
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(91, 77)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.Size = New System.Drawing.Size(140, 21)
        Me.uce_tip_doc.TabIndex = 8
        '
        'udte_fec_reg
        '
        Me.udte_fec_reg.Location = New System.Drawing.Point(305, 317)
        Me.udte_fec_reg.Name = "udte_fec_reg"
        Me.udte_fec_reg.ReadOnly = True
        Me.udte_fec_reg.Size = New System.Drawing.Size(131, 21)
        Me.udte_fec_reg.TabIndex = 23
        '
        'udte_fec_nac
        '
        Me.udte_fec_nac.Location = New System.Drawing.Point(532, 46)
        Me.udte_fec_nac.Name = "udte_fec_nac"
        Me.udte_fec_nac.Size = New System.Drawing.Size(84, 21)
        Me.udte_fec_nac.TabIndex = 6
        '
        'uos_sexo
        '
        Me.uos_sexo.BackColor = System.Drawing.Color.Transparent
        Me.uos_sexo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_sexo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_sexo.ItemSpacingVertical = 5
        Me.uos_sexo.Location = New System.Drawing.Point(746, 46)
        Me.uos_sexo.Name = "uos_sexo"
        Me.uos_sexo.Size = New System.Drawing.Size(101, 45)
        Me.uos_sexo.TabIndex = 7
        '
        'UltraLabel11
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance28
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(701, 51)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel11.TabIndex = 31
        Me.UltraLabel11.Text = "Sexo"
        '
        'UltraLabel15
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance20
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(12, 172)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel15.TabIndex = 30
        Me.UltraLabel15.Text = "Nacionalidad"
        '
        'UltraLabel14
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance26
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(239, 172)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel14.TabIndex = 30
        Me.UltraLabel14.Text = "Ocupacion"
        '
        'UltraLabel2
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance33
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 143)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel2.TabIndex = 30
        Me.UltraLabel2.Text = "Direccion"
        '
        'UltraLabel12
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance29
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(699, 20)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel12.TabIndex = 30
        Me.UltraLabel12.Text = "Est Civil"
        '
        'uce_Nacionalidad
        '
        Me.uce_Nacionalidad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Nacionalidad.Location = New System.Drawing.Point(91, 168)
        Me.uce_Nacionalidad.Name = "uce_Nacionalidad"
        Me.uce_Nacionalidad.Size = New System.Drawing.Size(140, 21)
        Me.uce_Nacionalidad.TabIndex = 15
        '
        'uce_est_civil
        '
        Me.uce_est_civil.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_est_civil.Location = New System.Drawing.Point(749, 16)
        Me.uce_est_civil.Name = "uce_est_civil"
        Me.uce_est_civil.Size = New System.Drawing.Size(100, 21)
        Me.uce_est_civil.TabIndex = 3
        '
        'txt_ape_pat
        '
        Me.txt_ape_pat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ape_pat.Location = New System.Drawing.Point(91, 16)
        Me.txt_ape_pat.MaxLength = 50
        Me.txt_ape_pat.Name = "txt_ape_pat"
        Me.txt_ape_pat.Size = New System.Drawing.Size(140, 21)
        Me.txt_ape_pat.TabIndex = 0
        '
        'txt_ape_cas
        '
        Me.txt_ape_cas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ape_cas.Location = New System.Drawing.Point(532, 16)
        Me.txt_ape_cas.MaxLength = 50
        Me.txt_ape_cas.Name = "txt_ape_cas"
        Me.txt_ape_cas.Size = New System.Drawing.Size(163, 21)
        Me.txt_ape_cas.TabIndex = 2
        '
        'txt_ape_mat
        '
        Me.txt_ape_mat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ape_mat.Location = New System.Drawing.Point(305, 16)
        Me.txt_ape_mat.MaxLength = 50
        Me.txt_ape_mat.Name = "txt_ape_mat"
        Me.txt_ape_mat.Size = New System.Drawing.Size(151, 21)
        Me.txt_ape_mat.TabIndex = 1
        '
        'txt_nom1
        '
        Me.txt_nom1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nom1.Location = New System.Drawing.Point(91, 46)
        Me.txt_nom1.MaxLength = 50
        Me.txt_nom1.Name = "txt_nom1"
        Me.txt_nom1.Size = New System.Drawing.Size(140, 21)
        Me.txt_nom1.TabIndex = 4
        '
        'txt_nom2
        '
        Me.txt_nom2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nom2.Location = New System.Drawing.Point(305, 46)
        Me.txt_nom2.MaxLength = 50
        Me.txt_nom2.Name = "txt_nom2"
        Me.txt_nom2.Size = New System.Drawing.Size(151, 21)
        Me.txt_nom2.TabIndex = 5
        '
        'UltraLabel7
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance17
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(462, 20)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel7.TabIndex = 22
        Me.UltraLabel7.Text = "Ape Casada"
        '
        'UltraLabel4
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance11
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(12, 20)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel4.TabIndex = 21
        Me.UltraLabel4.Text = "A. Paterno"
        '
        'UltraLabel5
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance34
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(239, 20)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel5.TabIndex = 22
        Me.UltraLabel5.Text = "A. Materno"
        '
        'UltraLabel65
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel65.Appearance = Appearance38
        Me.UltraLabel65.AutoSize = True
        Me.UltraLabel65.Location = New System.Drawing.Point(239, 50)
        Me.UltraLabel65.Name = "UltraLabel65"
        Me.UltraLabel65.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel65.TabIndex = 19
        Me.UltraLabel65.Text = "Nombre 2"
        '
        'UltraLabel6
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance35
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(12, 50)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel6.TabIndex = 20
        Me.UltraLabel6.Text = "Nombre 1"
        '
        'ugb_codigos
        '
        Me.ugb_codigos.Controls.Add(Me.lbl_estado)
        Me.ugb_codigos.Controls.Add(Me.UltraLabel29)
        Me.ugb_codigos.Controls.Add(Me.ucb_TipoHC)
        Me.ugb_codigos.Controls.Add(Me.txt_cod_id)
        Me.ugb_codigos.Controls.Add(Me.txt_num_histo)
        Me.ugb_codigos.Controls.Add(Me.UltraLabel3)
        Me.ugb_codigos.Controls.Add(Me.UltraLabel1)
        Me.ugb_codigos.Location = New System.Drawing.Point(13, 15)
        Me.ugb_codigos.Name = "ugb_codigos"
        Me.ugb_codigos.Size = New System.Drawing.Size(856, 38)
        Me.ugb_codigos.TabIndex = 42
        '
        'lbl_estado
        '
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.FontData.SizeInPoints = 14.0!
        Appearance19.ForeColor = System.Drawing.Color.White
        Appearance19.TextHAlignAsString = "Center"
        Me.lbl_estado.Appearance = Appearance19
        Me.lbl_estado.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_estado.Location = New System.Drawing.Point(712, 6)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(112, 26)
        Me.lbl_estado.TabIndex = 33
        Me.lbl_estado.Text = "Estado"
        '
        'UltraLabel29
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel29.Appearance = Appearance30
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(353, 13)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel29.TabIndex = 32
        Me.UltraLabel29.Text = "Tipo de H.C."
        '
        'ucb_TipoHC
        '
        Me.ucb_TipoHC.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucb_TipoHC.Location = New System.Drawing.Point(425, 9)
        Me.ucb_TipoHC.Name = "ucb_TipoHC"
        Me.ucb_TipoHC.Size = New System.Drawing.Size(176, 21)
        Me.ucb_TipoHC.TabIndex = 31
        '
        'txt_cod_id
        '
        Me.txt_cod_id.Location = New System.Drawing.Point(251, 8)
        Me.txt_cod_id.MaxLength = 5
        Me.txt_cod_id.Name = "txt_cod_id"
        Me.txt_cod_id.ReadOnly = True
        Me.txt_cod_id.Size = New System.Drawing.Size(65, 21)
        Me.txt_cod_id.TabIndex = 14
        '
        'txt_num_histo
        '
        Me.txt_num_histo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_histo.Location = New System.Drawing.Point(76, 8)
        Me.txt_num_histo.MaxLength = 5
        Me.txt_num_histo.Name = "txt_num_histo"
        Me.txt_num_histo.ReadOnly = True
        Me.txt_num_histo.Size = New System.Drawing.Size(91, 21)
        Me.txt_num_histo.TabIndex = 14
        '
        'UltraLabel3
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance13
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(191, 12)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel3.TabIndex = 11
        Me.UltraLabel3.Text = "Codigo ID"
        '
        'UltraLabel1
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance36
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(14, 12)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Nº Historia"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Imprimir, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator6})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(920, 25)
        Me.ToolS_Mantenimiento.TabIndex = 8
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'utc_historia
        '
        Me.utc_historia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_historia.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_historia.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_historia.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_historia.Location = New System.Drawing.Point(12, 32)
        Me.utc_historia.Name = "utc_historia"
        Me.utc_historia.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_historia.Size = New System.Drawing.Size(896, 473)
        Me.utc_historia.TabIndex = 9
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Historias Clinicas Base"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Registro / Edicion de Datos"
        Me.utc_historia.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(892, 447)
        '
        'AD_MA_HistoClini_DatGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(920, 517)
        Me.Controls.Add(Me.utc_historia)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AD_MA_HistoClini_DatGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historia Clinica Datos Generales"
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.ug_Comunicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Comunicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.utxt_Documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Historia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_ApeCas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_ApeMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ApePat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista_Hist_Clin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ListaHC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.utxt_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxtEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Ubicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Alergias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucb_GrupoS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucb_MedicoT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_NacTitular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Titular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucb_Condicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucb_recomendado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NombreC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.uce_Ubigeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Provincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Departamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ocupacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_reg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_nac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_sexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Nacionalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_est_civil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ape_pat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ape_cas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ape_mat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_codigos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_codigos.ResumeLayout(False)
        Me.ugb_codigos.PerformLayout()
        CType(Me.ucb_TipoHC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_histo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_historia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_historia.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents utc_historia As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista_Hist_Clin As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_ListaHC As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_num_histo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_cod_id As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ape_pat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ape_mat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_nom1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_nom2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel65 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ape_cas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uos_sexo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_est_civil As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_num_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents udte_fec_reg As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_fec_nac As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_dir As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ocupacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_Nacionalidad As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_codigos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Ubigeo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Provincia As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Departamento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Comunicacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_NombreC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Comunicaciones As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucb_recomendado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents utxt_Titular As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucb_Condicion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucb_GrupoS As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucb_MedicoT As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fec_NacTitular As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents utxt_Alergias As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents utxt_Ubicacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents utxtEdad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucb_TipoHC As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lbl_estado As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents utxt_Documento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_Historia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_Nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_ApeCas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_ApeMat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uck_Doc As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Historia As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Nombres As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_ApeCas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_ApeMat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_ApePat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_ApePat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubt_Reniec As Infragistics.Win.Misc.UltraButton
    Friend WithEvents utxt_Detalle As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
