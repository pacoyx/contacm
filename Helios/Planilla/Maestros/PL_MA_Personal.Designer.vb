<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_Personal
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_PAT")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_MAT")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TIPO")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CARGO")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_PAT")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_MAT")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CARGO")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ID")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TC_DESCRIPCION")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUMERO")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ISTATUS")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ID")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TC_DESCRIPCION")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_NUMERO")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DESCRIPCION")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ISTATUS")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_ayuda")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PL_MA_Personal))
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_ayuda")
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_sueldo")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_ayuda")
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_ayuda")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim GradientEffect1 As Infragistics.UltraChart.Resources.Appearance.GradientEffect = New Infragistics.UltraChart.Resources.Appearance.GradientEffect()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_CODIGO")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_DESCRIPCION")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PORCENTAJE")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_CODIGO")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_DESCRIPCION")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PORCENTAJE")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DO_ID")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DO_NOMBRE_ARCHIVO")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DO_DESCRIPCION")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DO_ID")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DO_NOMBRE_ARCHIVO")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DO_DESCRIPCION")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ID")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ID_TIPO_CONTRATO")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FECHA_INI")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FECHA_FIN")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_COMENTARIO")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ID")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ID_TIPO_CONTRATO")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FECHA_INI")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FECHA_FIN")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_COMENTARIO")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ID_PERSONAL")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ID_CONCEPTO")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_VALOR")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TIPO")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ID_EMPRESA")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ID_PERSONAL")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ID_CONCEPTO")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_VALOR")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ID_EMPRESA")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Listado = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Listado = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gb_DatosPersonales = New System.Windows.Forms.GroupBox()
        Me.ugb_telefonos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ug_comunicacion_persona = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Comunicacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ugb_direccion = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel33 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PE_INTERIOR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_NOMBRE_ZONA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_REFERENCIA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_PE_ID_TIPO_ZONA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_PE_NUMERO_VIA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_NOMBRE_VIA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_PE_ID_TIPO_VIA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_PE_UBIGEO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_datos_personales = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_PE_ID_SEXO = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.txt_PE_APE_PAT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_APE_MAT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_NOM_PRI = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_NOM_SEG = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_NUM_DOC_PER = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel65 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_NACIONALIDAD = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_TIPO_DOC_PER = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_PE_FEC_NAC = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_EST_CIVIL = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.upb_img = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.ubtn_editar_img = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_eliminar_img = New Infragistics.Win.Misc.UltraButton()
        Me.ugb_codigo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PE_CODIGO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_CODIGO_ALT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_ID_ANEXO_CONTA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_id_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gb_DatosLaborales = New System.Windows.Forms.GroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ume_quinta_ant = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel68 = New Infragistics.Win.Misc.UltraLabel()
        Me.gb_cese = New System.Windows.Forms.GroupBox()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_PE_FEC_ING = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel40 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_PE_FEC_CESE = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_PE_FEC_INSCRIP_REG_PEN = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_TIPO_CESE = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_EST_TRABAJADOR = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.gb_otros = New System.Windows.Forms.GroupBox()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_TIPO_PER = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel52 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_PERSONAL = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel37 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel64 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_REGIMEN_LABORAL = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_OCUPACION = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_NIVEL_EDU = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_TIPO_PERSO_TARIFA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_TIPO_TRABAJADOR = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_CARGO = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.gb_afp = New System.Windows.Forms.GroupBox()
        Me.uos_tipo_comi = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel69 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PE_NUM_AFP = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PE_NUM_IPSS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_PE_ID_AFP = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.gb_cts = New System.Windows.Forms.GroupBox()
        Me.UltraLabel54 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel57 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel55 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel56 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_BANCO_CTS = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_MONEDA_CTS = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_PE_NUM_CUENTA_CTS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_PE_ID_TIPO_CUENTA_CTS = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.gb_remuneracion = New System.Windows.Forms.GroupBox()
        Me.txt_cod_interbancario = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_IMP_REMU = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel58 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PE_NUM_CUENTA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_PE_ID_MONEDA_CUENTA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_TIPO_CUENTA_REMU = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_TIPO_REMU = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_MONEDA_REMU = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PE_HORAS_TRABAJO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gb_DatosAdicioanles = New System.Windows.Forms.GroupBox()
        Me.gb_otros2 = New System.Windows.Forms.GroupBox()
        Me.uchk_EsRia = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_Calcular_cts = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.une_PE_NUM_HIJOS = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uchk_PE_ASIGNACION_FAM = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_PE_AFECTO_QUINTA = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_PE_ES_SINDICALIZADO = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_PE_OTRO_ING_5TA = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_PE_DOMICILIADO = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel59 = New Infragistics.Win.Misc.UltraLabel()
        Me.uchk_PE_SUJETO_HORA_NOC = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_PE_SUJETO_REG_ALT = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_PE_SUJETO_JOR_MAX = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_PE_DISCAPACIDAD = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.gb_otro1 = New System.Windows.Forms.GroupBox()
        Me.UltraLabel47 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel46 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel48 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel51 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel50 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel49 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel45 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel53 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel43 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel44 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_ID_AREA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_COD_EPS_SER_PRO = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_AFILIADO_EPS_SER_PRO = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_SITUACION_EPS = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_CLASIFI_PER = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PE_ID_SITUACION_ESPECIAL = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_GRUPO_SANGUINEO = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_TIPO_PAGO = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_PERIODO_REMUNERA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_SCTR_PENSION = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_PE_ID_SCTR_SALUD = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.uchk_PE_CONSIDERA_FT = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.uchart_cc = New Infragistics.Win.UltraWinChart.UltraChart()
        Me.UltraLabel60 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_total_porce_cc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ug_ccosto = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Ccosto = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel61 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ficha = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_ver_doc = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_agregar_archivo = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Documentos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Documentos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel70 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Generar_Contrato = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel63 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Contratos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Contratos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraLabel67 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel66 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Conceptos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Conceptos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.utc_Mante = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
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
        Me.Tool_Reporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.gb_DatosPersonales.SuspendLayout()
        CType(Me.ugb_telefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_telefonos.SuspendLayout()
        CType(Me.ug_comunicacion_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Comunicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_direccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_direccion.SuspendLayout()
        CType(Me.txt_PE_INTERIOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NOMBRE_ZONA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_REFERENCIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_ZONA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NUMERO_VIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NOMBRE_VIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_VIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_UBIGEO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_datos_personales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos_personales.SuspendLayout()
        CType(Me.uos_PE_ID_SEXO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_APE_PAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_APE_MAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NOM_PRI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NOM_SEG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NUM_DOC_PER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_NACIONALIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_DOC_PER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_PE_FEC_NAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_EST_CIVIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.ugb_codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_codigo.SuspendLayout()
        CType(Me.txt_PE_CODIGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_CODIGO_ALT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_ID_ANEXO_CONTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.gb_DatosLaborales.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        Me.gb_cese.SuspendLayout()
        CType(Me.udte_PE_FEC_ING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_CESE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_EST_TRABAJADOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_otros.SuspendLayout()
        CType(Me.uce_PE_ID_TIPO_PER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_PERSONAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_REGIMEN_LABORAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_OCUPACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_NIVEL_EDU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_PERSO_TARIFA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_TRABAJADOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_CARGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_afp.SuspendLayout()
        CType(Me.uos_tipo_comi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NUM_AFP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NUM_IPSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_AFP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_cts.SuspendLayout()
        CType(Me.uce_PE_ID_BANCO_CTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_MONEDA_CTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NUM_CUENTA_CTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_CUENTA_CTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_remuneracion.SuspendLayout()
        CType(Me.txt_cod_interbancario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_IMP_REMU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_NUM_CUENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_MONEDA_CUENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_CUENTA_REMU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_REMU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_MONEDA_REMU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PE_HORAS_TRABAJO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.gb_DatosAdicioanles.SuspendLayout()
        Me.gb_otros2.SuspendLayout()
        CType(Me.une_PE_NUM_HIJOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_otro1.SuspendLayout()
        CType(Me.uce_ID_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_COD_EPS_SER_PRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_AFILIADO_EPS_SER_PRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_SITUACION_EPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_CLASIFI_PER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_SITUACION_ESPECIAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_GRUPO_SANGUINEO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_TIPO_PAGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_PERIODO_REMUNERA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_SCTR_PENSION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PE_ID_SCTR_SALUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.uchart_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_porce_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ccosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Ccosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txt_ficha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ug_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.ug_Contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Conceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Conceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Mante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Mante.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Listado)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(856, 361)
        '
        'ug_Listado
        '
        Me.ug_Listado.DataSource = Me.uds_Listado
        Me.ug_Listado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance46.TextHAlignAsString = "Center"
        UltraGridColumn2.CellAppearance = Appearance46
        UltraGridColumn2.Header.Caption = "CODIGO"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 60
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "APE. PATERNO"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 114
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "APE. MATERNO"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 124
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance47.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance47
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 43
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance48.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance48
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 48
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.ug_Listado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Listado.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Listado.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Listado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Listado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance52.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance52.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Listado.DisplayLayout.Override.RowAlternateAppearance = Appearance52
        Me.ug_Listado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Listado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Listado.Location = New System.Drawing.Point(0, 0)
        Me.ug_Listado.Name = "ug_Listado"
        Me.ug_Listado.Size = New System.Drawing.Size(856, 361)
        Me.ug_Listado.TabIndex = 0
        '
        'uds_Listado
        '
        Me.uds_Listado.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        Me.uds_Listado.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.gb_DatosPersonales)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(856, 361)
        '
        'gb_DatosPersonales
        '
        Me.gb_DatosPersonales.BackColor = System.Drawing.Color.White
        Me.gb_DatosPersonales.Controls.Add(Me.ugb_telefonos)
        Me.gb_DatosPersonales.Controls.Add(Me.ugb_direccion)
        Me.gb_DatosPersonales.Controls.Add(Me.ugb_datos_personales)
        Me.gb_DatosPersonales.Controls.Add(Me.UltraGroupBox4)
        Me.gb_DatosPersonales.Controls.Add(Me.ugb_codigo)
        Me.gb_DatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_DatosPersonales.Location = New System.Drawing.Point(0, 0)
        Me.gb_DatosPersonales.Name = "gb_DatosPersonales"
        Me.gb_DatosPersonales.Size = New System.Drawing.Size(856, 361)
        Me.gb_DatosPersonales.TabIndex = 13
        Me.gb_DatosPersonales.TabStop = False
        '
        'ugb_telefonos
        '
        Me.ugb_telefonos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_telefonos.Controls.Add(Me.ug_comunicacion_persona)
        Me.ugb_telefonos.Location = New System.Drawing.Point(445, 185)
        Me.ugb_telefonos.Name = "ugb_telefonos"
        Me.ugb_telefonos.Size = New System.Drawing.Size(399, 171)
        Me.ugb_telefonos.TabIndex = 31
        Me.ugb_telefonos.Text = "Telefonos-Email-Otros"
        '
        'ug_comunicacion_persona
        '
        Me.ug_comunicacion_persona.DataSource = Me.uds_Comunicacion
        Me.ug_comunicacion_persona.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.Caption = "Tipo"
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Width = 79
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "Detalle"
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Width = 122
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.Caption = "Descripcion"
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.Width = 124
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.Caption = "Activo"
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.ug_comunicacion_persona.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_comunicacion_persona.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_comunicacion_persona.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_comunicacion_persona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_comunicacion_persona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_comunicacion_persona.Location = New System.Drawing.Point(3, 16)
        Me.ug_comunicacion_persona.Name = "ug_comunicacion_persona"
        Me.ug_comunicacion_persona.Size = New System.Drawing.Size(393, 152)
        Me.ug_comunicacion_persona.TabIndex = 24
        '
        'uds_Comunicacion
        '
        UltraDataColumn9.DataType = GetType(Short)
        UltraDataColumn12.DefaultValue = "..."
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn13.DefaultValue = True
        Me.uds_Comunicacion.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'ugb_direccion
        '
        Me.ugb_direccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel30)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel29)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel33)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel28)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel32)
        Me.ugb_direccion.Controls.Add(Me.txt_PE_INTERIOR)
        Me.ugb_direccion.Controls.Add(Me.txt_PE_NOMBRE_ZONA)
        Me.ugb_direccion.Controls.Add(Me.txt_PE_REFERENCIA)
        Me.ugb_direccion.Controls.Add(Me.uce_PE_ID_TIPO_ZONA)
        Me.ugb_direccion.Controls.Add(Me.txt_PE_NUMERO_VIA)
        Me.ugb_direccion.Controls.Add(Me.txt_PE_NOMBRE_VIA)
        Me.ugb_direccion.Controls.Add(Me.uce_PE_ID_TIPO_VIA)
        Me.ugb_direccion.Controls.Add(Me.txt_PE_UBIGEO)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel27)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel31)
        Me.ugb_direccion.Controls.Add(Me.UltraLabel34)
        Me.ugb_direccion.Location = New System.Drawing.Point(6, 185)
        Me.ugb_direccion.Name = "ugb_direccion"
        Me.ugb_direccion.Size = New System.Drawing.Size(433, 170)
        Me.ugb_direccion.TabIndex = 30
        Me.ugb_direccion.Text = "Direccion"
        '
        'UltraLabel30
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel30.Appearance = Appearance7
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Location = New System.Drawing.Point(43, 56)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel30.TabIndex = 11
        Me.UltraLabel30.Text = "Interior"
        '
        'UltraLabel29
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel29.Appearance = Appearance34
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(360, 29)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(16, 14)
        Me.UltraLabel29.TabIndex = 11
        Me.UltraLabel29.Text = "Nº"
        '
        'UltraLabel33
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel33.Appearance = Appearance33
        Me.UltraLabel33.AutoSize = True
        Me.UltraLabel33.Location = New System.Drawing.Point(23, 81)
        Me.UltraLabel33.Name = "UltraLabel33"
        Me.UltraLabel33.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel33.TabIndex = 11
        Me.UltraLabel33.Text = "Referencia"
        '
        'UltraLabel28
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel28.Appearance = Appearance35
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(192, 29)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel28.TabIndex = 11
        Me.UltraLabel28.Text = "Nom Via"
        '
        'UltraLabel32
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance39
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Location = New System.Drawing.Point(16, 130)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel32.TabIndex = 11
        Me.UltraLabel32.Text = "Nomb. Zona"
        '
        'txt_PE_INTERIOR
        '
        Me.txt_PE_INTERIOR.Location = New System.Drawing.Point(87, 52)
        Me.txt_PE_INTERIOR.MaxLength = 50
        Me.txt_PE_INTERIOR.Name = "txt_PE_INTERIOR"
        Me.txt_PE_INTERIOR.Size = New System.Drawing.Size(96, 21)
        Me.txt_PE_INTERIOR.TabIndex = 14
        '
        'txt_PE_NOMBRE_ZONA
        '
        Me.txt_PE_NOMBRE_ZONA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PE_NOMBRE_ZONA.Location = New System.Drawing.Point(87, 128)
        Me.txt_PE_NOMBRE_ZONA.MaxLength = 50
        Me.txt_PE_NOMBRE_ZONA.Name = "txt_PE_NOMBRE_ZONA"
        Me.txt_PE_NOMBRE_ZONA.Size = New System.Drawing.Size(336, 21)
        Me.txt_PE_NOMBRE_ZONA.TabIndex = 18
        '
        'txt_PE_REFERENCIA
        '
        Me.txt_PE_REFERENCIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PE_REFERENCIA.Location = New System.Drawing.Point(87, 77)
        Me.txt_PE_REFERENCIA.MaxLength = 50
        Me.txt_PE_REFERENCIA.Name = "txt_PE_REFERENCIA"
        Me.txt_PE_REFERENCIA.Size = New System.Drawing.Size(336, 21)
        Me.txt_PE_REFERENCIA.TabIndex = 16
        '
        'uce_PE_ID_TIPO_ZONA
        '
        Me.uce_PE_ID_TIPO_ZONA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_ZONA.Location = New System.Drawing.Point(87, 102)
        Me.uce_PE_ID_TIPO_ZONA.Name = "uce_PE_ID_TIPO_ZONA"
        Me.uce_PE_ID_TIPO_ZONA.Size = New System.Drawing.Size(336, 21)
        Me.uce_PE_ID_TIPO_ZONA.TabIndex = 17
        '
        'txt_PE_NUMERO_VIA
        '
        Me.txt_PE_NUMERO_VIA.Location = New System.Drawing.Point(382, 25)
        Me.txt_PE_NUMERO_VIA.MaxLength = 50
        Me.txt_PE_NUMERO_VIA.Name = "txt_PE_NUMERO_VIA"
        Me.txt_PE_NUMERO_VIA.Size = New System.Drawing.Size(41, 21)
        Me.txt_PE_NUMERO_VIA.TabIndex = 13
        '
        'txt_PE_NOMBRE_VIA
        '
        Me.txt_PE_NOMBRE_VIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PE_NOMBRE_VIA.Location = New System.Drawing.Point(246, 25)
        Me.txt_PE_NOMBRE_VIA.MaxLength = 50
        Me.txt_PE_NOMBRE_VIA.Name = "txt_PE_NOMBRE_VIA"
        Me.txt_PE_NOMBRE_VIA.Size = New System.Drawing.Size(108, 21)
        Me.txt_PE_NOMBRE_VIA.TabIndex = 12
        '
        'uce_PE_ID_TIPO_VIA
        '
        Me.uce_PE_ID_TIPO_VIA.DropDownListWidth = 300
        Me.uce_PE_ID_TIPO_VIA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_VIA.Location = New System.Drawing.Point(87, 25)
        Me.uce_PE_ID_TIPO_VIA.Name = "uce_PE_ID_TIPO_VIA"
        Me.uce_PE_ID_TIPO_VIA.Size = New System.Drawing.Size(96, 21)
        Me.uce_PE_ID_TIPO_VIA.TabIndex = 11
        '
        'txt_PE_UBIGEO
        '
        EditorButton1.Key = "btn_ayuda"
        Me.txt_PE_UBIGEO.ButtonsRight.Add(EditorButton1)
        Me.txt_PE_UBIGEO.Location = New System.Drawing.Point(246, 52)
        Me.txt_PE_UBIGEO.MaxLength = 50
        Me.txt_PE_UBIGEO.Name = "txt_PE_UBIGEO"
        Me.txt_PE_UBIGEO.ReadOnly = True
        Me.txt_PE_UBIGEO.Size = New System.Drawing.Size(177, 21)
        Me.txt_PE_UBIGEO.TabIndex = 15
        '
        'UltraLabel27
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel27.Appearance = Appearance36
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Location = New System.Drawing.Point(36, 31)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel27.TabIndex = 5
        Me.UltraLabel27.Text = "Tipo Via"
        '
        'UltraLabel31
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel31.Appearance = Appearance40
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Location = New System.Drawing.Point(27, 106)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel31.TabIndex = 5
        Me.UltraLabel31.Text = "Tipo Zona"
        '
        'UltraLabel34
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel34.Appearance = Appearance87
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Location = New System.Drawing.Point(200, 56)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel34.TabIndex = 5
        Me.UltraLabel34.Text = "Ubigeo"
        '
        'ugb_datos_personales
        '
        Me.ugb_datos_personales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_datos_personales.Controls.Add(Me.uos_PE_ID_SEXO)
        Me.ugb_datos_personales.Controls.Add(Me.txt_PE_APE_PAT)
        Me.ugb_datos_personales.Controls.Add(Me.txt_PE_APE_MAT)
        Me.ugb_datos_personales.Controls.Add(Me.txt_PE_NOM_PRI)
        Me.ugb_datos_personales.Controls.Add(Me.txt_PE_NOM_SEG)
        Me.ugb_datos_personales.Controls.Add(Me.txt_PE_NUM_DOC_PER)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel7)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel65)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel6)
        Me.ugb_datos_personales.Controls.Add(Me.uce_PE_ID_NACIONALIDAD)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel10)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel24)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel11)
        Me.ugb_datos_personales.Controls.Add(Me.uce_PE_ID_TIPO_DOC_PER)
        Me.ugb_datos_personales.Controls.Add(Me.udte_PE_FEC_NAC)
        Me.ugb_datos_personales.Controls.Add(Me.UltraLabel12)
        Me.ugb_datos_personales.Controls.Add(Me.uce_PE_ID_EST_CIVIL)
        Me.ugb_datos_personales.Location = New System.Drawing.Point(170, 51)
        Me.ugb_datos_personales.Name = "ugb_datos_personales"
        Me.ugb_datos_personales.Size = New System.Drawing.Size(674, 128)
        Me.ugb_datos_personales.TabIndex = 29
        Me.ugb_datos_personales.Text = "Datos Personales"
        Me.ugb_datos_personales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'uos_PE_ID_SEXO
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.uos_PE_ID_SEXO.Appearance = Appearance11
        Me.uos_PE_ID_SEXO.BackColor = System.Drawing.Color.Transparent
        Me.uos_PE_ID_SEXO.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_PE_ID_SEXO.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_PE_ID_SEXO.CheckedIndex = 0
        ValueListItem4.DataValue = CType(1, Short)
        ValueListItem4.DisplayText = "MASCULINO"
        ValueListItem5.DataValue = CType(2, Short)
        ValueListItem5.DisplayText = "FEMENINO"
        Me.uos_PE_ID_SEXO.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5})
        Me.uos_PE_ID_SEXO.ItemSpacingVertical = 5
        Me.uos_PE_ID_SEXO.Location = New System.Drawing.Point(543, 76)
        Me.uos_PE_ID_SEXO.Name = "uos_PE_ID_SEXO"
        Me.uos_PE_ID_SEXO.Size = New System.Drawing.Size(114, 43)
        Me.uos_PE_ID_SEXO.TabIndex = 11
        Me.uos_PE_ID_SEXO.Text = "MASCULINO"
        '
        'txt_PE_APE_PAT
        '
        Me.txt_PE_APE_PAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PE_APE_PAT.Location = New System.Drawing.Point(96, 24)
        Me.txt_PE_APE_PAT.MaxLength = 50
        Me.txt_PE_APE_PAT.Name = "txt_PE_APE_PAT"
        Me.txt_PE_APE_PAT.Size = New System.Drawing.Size(132, 21)
        Me.txt_PE_APE_PAT.TabIndex = 0
        '
        'txt_PE_APE_MAT
        '
        Me.txt_PE_APE_MAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PE_APE_MAT.Location = New System.Drawing.Point(311, 24)
        Me.txt_PE_APE_MAT.MaxLength = 50
        Me.txt_PE_APE_MAT.Name = "txt_PE_APE_MAT"
        Me.txt_PE_APE_MAT.Size = New System.Drawing.Size(138, 21)
        Me.txt_PE_APE_MAT.TabIndex = 1
        '
        'txt_PE_NOM_PRI
        '
        Me.txt_PE_NOM_PRI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PE_NOM_PRI.Location = New System.Drawing.Point(96, 47)
        Me.txt_PE_NOM_PRI.MaxLength = 50
        Me.txt_PE_NOM_PRI.Name = "txt_PE_NOM_PRI"
        Me.txt_PE_NOM_PRI.Size = New System.Drawing.Size(132, 21)
        Me.txt_PE_NOM_PRI.TabIndex = 2
        '
        'txt_PE_NOM_SEG
        '
        Me.txt_PE_NOM_SEG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PE_NOM_SEG.Location = New System.Drawing.Point(311, 47)
        Me.txt_PE_NOM_SEG.MaxLength = 50
        Me.txt_PE_NOM_SEG.Name = "txt_PE_NOM_SEG"
        Me.txt_PE_NOM_SEG.Size = New System.Drawing.Size(138, 21)
        Me.txt_PE_NOM_SEG.TabIndex = 3
        '
        'txt_PE_NUM_DOC_PER
        '
        Me.txt_PE_NUM_DOC_PER.Location = New System.Drawing.Point(96, 95)
        Me.txt_PE_NUM_DOC_PER.MaxLength = 50
        Me.txt_PE_NUM_DOC_PER.Name = "txt_PE_NUM_DOC_PER"
        Me.txt_PE_NUM_DOC_PER.Size = New System.Drawing.Size(132, 21)
        Me.txt_PE_NUM_DOC_PER.TabIndex = 5
        '
        'UltraLabel3
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance21
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(25, 28)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel3.TabIndex = 5
        Me.UltraLabel3.Text = "Ape Paterno"
        '
        'UltraLabel8
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance18
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(38, 99)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel8.TabIndex = 5
        Me.UltraLabel8.Text = "Num. Doc"
        '
        'UltraLabel7
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance41
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(43, 76)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel7.TabIndex = 5
        Me.UltraLabel7.Text = "Tipo Doc"
        '
        'UltraLabel5
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance17
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(245, 28)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel5.TabIndex = 5
        Me.UltraLabel5.Text = "Ape Mater."
        '
        'UltraLabel65
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel65.Appearance = Appearance38
        Me.UltraLabel65.AutoSize = True
        Me.UltraLabel65.Location = New System.Drawing.Point(250, 52)
        Me.UltraLabel65.Name = "UltraLabel65"
        Me.UltraLabel65.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel65.TabIndex = 5
        Me.UltraLabel65.Text = "Seg. Nom"
        '
        'UltraLabel6
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance2
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(18, 52)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel6.TabIndex = 5
        Me.UltraLabel6.Text = "Prim. Nombre"
        '
        'uce_PE_ID_NACIONALIDAD
        '
        Me.uce_PE_ID_NACIONALIDAD.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_NACIONALIDAD.Location = New System.Drawing.Point(311, 71)
        Me.uce_PE_ID_NACIONALIDAD.Name = "uce_PE_ID_NACIONALIDAD"
        Me.uce_PE_ID_NACIONALIDAD.Size = New System.Drawing.Size(138, 21)
        Me.uce_PE_ID_NACIONALIDAD.TabIndex = 10
        '
        'UltraLabel10
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance61
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(475, 28)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel10.TabIndex = 5
        Me.UltraLabel10.Text = "Fecha Nac."
        '
        'UltraLabel24
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance37
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(234, 74)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel24.TabIndex = 5
        Me.UltraLabel24.Text = "Nacionalidad"
        '
        'UltraLabel11
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance9
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(507, 78)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel11.TabIndex = 5
        Me.UltraLabel11.Text = "Sexo"
        '
        'uce_PE_ID_TIPO_DOC_PER
        '
        Me.uce_PE_ID_TIPO_DOC_PER.DropDownListWidth = 300
        Me.uce_PE_ID_TIPO_DOC_PER.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_DOC_PER.Location = New System.Drawing.Point(96, 71)
        Me.uce_PE_ID_TIPO_DOC_PER.Name = "uce_PE_ID_TIPO_DOC_PER"
        Me.uce_PE_ID_TIPO_DOC_PER.Size = New System.Drawing.Size(132, 21)
        Me.uce_PE_ID_TIPO_DOC_PER.TabIndex = 4
        '
        'udte_PE_FEC_NAC
        '
        Me.udte_PE_FEC_NAC.Location = New System.Drawing.Point(543, 24)
        Me.udte_PE_FEC_NAC.Name = "udte_PE_FEC_NAC"
        Me.udte_PE_FEC_NAC.Size = New System.Drawing.Size(114, 21)
        Me.udte_PE_FEC_NAC.TabIndex = 6
        '
        'UltraLabel12
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance16
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(473, 52)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel12.TabIndex = 5
        Me.UltraLabel12.Text = "Estado Civil"
        '
        'uce_PE_ID_EST_CIVIL
        '
        Me.uce_PE_ID_EST_CIVIL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_EST_CIVIL.Location = New System.Drawing.Point(543, 49)
        Me.uce_PE_ID_EST_CIVIL.Name = "uce_PE_ID_EST_CIVIL"
        Me.uce_PE_ID_EST_CIVIL.Size = New System.Drawing.Size(114, 21)
        Me.uce_PE_ID_EST_CIVIL.TabIndex = 8
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.upb_img)
        Me.UltraGroupBox4.Controls.Add(Me.ubtn_editar_img)
        Me.UltraGroupBox4.Controls.Add(Me.ubtn_eliminar_img)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(5, 11)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(155, 168)
        Me.UltraGroupBox4.TabIndex = 28
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'upb_img
        '
        Me.upb_img.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.upb_img.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_img.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.upb_img.Image = CType(resources.GetObject("upb_img.Image"), Object)
        Me.upb_img.Location = New System.Drawing.Point(10, 8)
        Me.upb_img.Name = "upb_img"
        Me.upb_img.Size = New System.Drawing.Size(137, 131)
        Me.upb_img.TabIndex = 23
        '
        'ubtn_editar_img
        '
        Me.ubtn_editar_img.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance55.FontData.SizeInPoints = 8.0!
        Appearance55.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_editar_img.Appearance = Appearance55
        Me.ubtn_editar_img.Location = New System.Drawing.Point(94, 142)
        Me.ubtn_editar_img.Name = "ubtn_editar_img"
        Me.ubtn_editar_img.Size = New System.Drawing.Size(53, 20)
        Me.ubtn_editar_img.TabIndex = 26
        Me.ubtn_editar_img.Text = "Agregar"
        '
        'ubtn_eliminar_img
        '
        Me.ubtn_eliminar_img.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_eliminar_img.Appearance = Appearance54
        Me.ubtn_eliminar_img.Location = New System.Drawing.Point(45, 142)
        Me.ubtn_eliminar_img.Name = "ubtn_eliminar_img"
        Me.ubtn_eliminar_img.Size = New System.Drawing.Size(45, 20)
        Me.ubtn_eliminar_img.TabIndex = 25
        Me.ubtn_eliminar_img.Text = "Quitar"
        '
        'ugb_codigo
        '
        Me.ugb_codigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_codigo.Controls.Add(Me.UltraLabel4)
        Me.ugb_codigo.Controls.Add(Me.txt_PE_CODIGO)
        Me.ugb_codigo.Controls.Add(Me.txt_PE_CODIGO_ALT)
        Me.ugb_codigo.Controls.Add(Me.txt_PE_ID_ANEXO_CONTA)
        Me.ugb_codigo.Controls.Add(Me.UltraLabel2)
        Me.ugb_codigo.Controls.Add(Me.UltraLabel1)
        Me.ugb_codigo.Controls.Add(Me.txt_id_personal)
        Me.ugb_codigo.Location = New System.Drawing.Point(169, 11)
        Me.ugb_codigo.Name = "ugb_codigo"
        Me.ugb_codigo.Size = New System.Drawing.Size(675, 38)
        Me.ugb_codigo.TabIndex = 27
        '
        'UltraLabel4
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance108
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(24, 12)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel4.TabIndex = 5
        Me.UltraLabel4.Text = "Codigo"
        '
        'txt_PE_CODIGO
        '
        Me.txt_PE_CODIGO.Location = New System.Drawing.Point(69, 8)
        Me.txt_PE_CODIGO.MaxLength = 50
        Me.txt_PE_CODIGO.Name = "txt_PE_CODIGO"
        Me.txt_PE_CODIGO.ReadOnly = True
        Me.txt_PE_CODIGO.Size = New System.Drawing.Size(73, 21)
        Me.txt_PE_CODIGO.TabIndex = 19
        '
        'txt_PE_CODIGO_ALT
        '
        Me.txt_PE_CODIGO_ALT.Location = New System.Drawing.Point(234, 8)
        Me.txt_PE_CODIGO_ALT.MaxLength = 50
        Me.txt_PE_CODIGO_ALT.Name = "txt_PE_CODIGO_ALT"
        Me.txt_PE_CODIGO_ALT.Size = New System.Drawing.Size(73, 21)
        Me.txt_PE_CODIGO_ALT.TabIndex = 20
        '
        'txt_PE_ID_ANEXO_CONTA
        '
        Me.txt_PE_ID_ANEXO_CONTA.Location = New System.Drawing.Point(414, 8)
        Me.txt_PE_ID_ANEXO_CONTA.MaxLength = 50
        Me.txt_PE_ID_ANEXO_CONTA.Name = "txt_PE_ID_ANEXO_CONTA"
        Me.txt_PE_ID_ANEXO_CONTA.ReadOnly = True
        Me.txt_PE_ID_ANEXO_CONTA.Size = New System.Drawing.Size(73, 21)
        Me.txt_PE_ID_ANEXO_CONTA.TabIndex = 21
        '
        'UltraLabel2
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance14
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(321, 12)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(89, 14)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Codigo Contable"
        '
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(151, 12)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel1.TabIndex = 5
        Me.UltraLabel1.Text = "Codigo Alterno"
        '
        'txt_id_personal
        '
        Me.txt_id_personal.Location = New System.Drawing.Point(493, 8)
        Me.txt_id_personal.MaxLength = 50
        Me.txt_id_personal.Name = "txt_id_personal"
        Me.txt_id_personal.Size = New System.Drawing.Size(33, 21)
        Me.txt_id_personal.TabIndex = 22
        Me.txt_id_personal.Visible = False
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.gb_DatosLaborales)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(856, 361)
        '
        'gb_DatosLaborales
        '
        Me.gb_DatosLaborales.BackColor = System.Drawing.Color.White
        Me.gb_DatosLaborales.Controls.Add(Me.UltraGroupBox3)
        Me.gb_DatosLaborales.Controls.Add(Me.gb_cese)
        Me.gb_DatosLaborales.Controls.Add(Me.gb_otros)
        Me.gb_DatosLaborales.Controls.Add(Me.gb_afp)
        Me.gb_DatosLaborales.Controls.Add(Me.gb_cts)
        Me.gb_DatosLaborales.Controls.Add(Me.gb_remuneracion)
        Me.gb_DatosLaborales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_DatosLaborales.Location = New System.Drawing.Point(0, 0)
        Me.gb_DatosLaborales.Name = "gb_DatosLaborales"
        Me.gb_DatosLaborales.Size = New System.Drawing.Size(856, 361)
        Me.gb_DatosLaborales.TabIndex = 19
        Me.gb_DatosLaborales.TabStop = False
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox3.Controls.Add(Me.ume_quinta_ant)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel68)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(616, 236)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(231, 110)
        Me.UltraGroupBox3.TabIndex = 33
        Me.UltraGroupBox3.Text = "Otros"
        '
        'ume_quinta_ant
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.ume_quinta_ant.Appearance = Appearance6
        Me.ume_quinta_ant.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_quinta_ant.InputMask = "{LOC}nnnnnnn.nn"
        Me.ume_quinta_ant.Location = New System.Drawing.Point(97, 19)
        Me.ume_quinta_ant.Name = "ume_quinta_ant"
        Me.ume_quinta_ant.Size = New System.Drawing.Size(99, 20)
        Me.ume_quinta_ant.TabIndex = 12
        Me.ume_quinta_ant.Text = "UltraMaskedEdit1"
        '
        'UltraLabel68
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel68.Appearance = Appearance27
        Me.UltraLabel68.AutoSize = True
        Me.UltraLabel68.Location = New System.Drawing.Point(11, 25)
        Me.UltraLabel68.Name = "UltraLabel68"
        Me.UltraLabel68.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel68.TabIndex = 11
        Me.UltraLabel68.Text = "Quinta Anterior"
        '
        'gb_cese
        '
        Me.gb_cese.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_cese.Controls.Add(Me.UltraLabel41)
        Me.gb_cese.Controls.Add(Me.udte_PE_FEC_ING)
        Me.gb_cese.Controls.Add(Me.UltraLabel40)
        Me.gb_cese.Controls.Add(Me.ume_PE_FEC_CESE)
        Me.gb_cese.Controls.Add(Me.ume_PE_FEC_INSCRIP_REG_PEN)
        Me.gb_cese.Controls.Add(Me.UltraLabel38)
        Me.gb_cese.Controls.Add(Me.UltraLabel42)
        Me.gb_cese.Controls.Add(Me.uce_PE_ID_TIPO_CESE)
        Me.gb_cese.Controls.Add(Me.uce_PE_ID_EST_TRABAJADOR)
        Me.gb_cese.Controls.Add(Me.UltraLabel17)
        Me.gb_cese.Location = New System.Drawing.Point(616, 19)
        Me.gb_cese.Name = "gb_cese"
        Me.gb_cese.Size = New System.Drawing.Size(231, 211)
        Me.gb_cese.TabIndex = 32
        Me.gb_cese.TabStop = False
        Me.gb_cese.Text = "Datos del Cese"
        '
        'UltraLabel41
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel41.Appearance = Appearance10
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Location = New System.Drawing.Point(22, 82)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel41.TabIndex = 17
        Me.UltraLabel41.Text = "Fecha Cese"
        '
        'udte_PE_FEC_ING
        '
        Me.udte_PE_FEC_ING.Location = New System.Drawing.Point(93, 24)
        Me.udte_PE_FEC_ING.Name = "udte_PE_FEC_ING"
        Me.udte_PE_FEC_ING.Size = New System.Drawing.Size(103, 21)
        Me.udte_PE_FEC_ING.TabIndex = 23
        '
        'UltraLabel40
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel40.Appearance = Appearance62
        Me.UltraLabel40.AutoSize = True
        Me.UltraLabel40.Location = New System.Drawing.Point(11, 28)
        Me.UltraLabel40.Name = "UltraLabel40"
        Me.UltraLabel40.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel40.TabIndex = 17
        Me.UltraLabel40.Text = "Fecha Ingreso"
        '
        'ume_PE_FEC_CESE
        '
        Me.ume_PE_FEC_CESE.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_PE_FEC_CESE.InputMask = "{date}"
        Me.ume_PE_FEC_CESE.Location = New System.Drawing.Point(93, 79)
        Me.ume_PE_FEC_CESE.Name = "ume_PE_FEC_CESE"
        Me.ume_PE_FEC_CESE.Size = New System.Drawing.Size(103, 20)
        Me.ume_PE_FEC_CESE.TabIndex = 25
        Me.ume_PE_FEC_CESE.Text = "UltraMaskedEdit1"
        '
        'ume_PE_FEC_INSCRIP_REG_PEN
        '
        Me.ume_PE_FEC_INSCRIP_REG_PEN.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_PE_FEC_INSCRIP_REG_PEN.InputMask = "{date}"
        Me.ume_PE_FEC_INSCRIP_REG_PEN.Location = New System.Drawing.Point(93, 105)
        Me.ume_PE_FEC_INSCRIP_REG_PEN.Name = "ume_PE_FEC_INSCRIP_REG_PEN"
        Me.ume_PE_FEC_INSCRIP_REG_PEN.Size = New System.Drawing.Size(103, 20)
        Me.ume_PE_FEC_INSCRIP_REG_PEN.TabIndex = 26
        Me.ume_PE_FEC_INSCRIP_REG_PEN.Text = "UltraMaskedEdit1"
        '
        'UltraLabel38
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel38.Appearance = Appearance12
        Me.UltraLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel38.Location = New System.Drawing.Point(15, 108)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(72, 42)
        Me.UltraLabel38.TabIndex = 27
        Me.UltraLabel38.Text = "Fec Insc. Regimen Pensionario"
        '
        'UltraLabel42
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel42.Appearance = Appearance59
        Me.UltraLabel42.AutoSize = True
        Me.UltraLabel42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel42.Location = New System.Drawing.Point(16, 56)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel42.TabIndex = 14
        Me.UltraLabel42.Text = "Tipo de Cese"
        '
        'uce_PE_ID_TIPO_CESE
        '
        Me.uce_PE_ID_TIPO_CESE.DropDownListWidth = 250
        Me.uce_PE_ID_TIPO_CESE.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_CESE.Location = New System.Drawing.Point(93, 52)
        Me.uce_PE_ID_TIPO_CESE.Name = "uce_PE_ID_TIPO_CESE"
        Me.uce_PE_ID_TIPO_CESE.Size = New System.Drawing.Size(103, 21)
        Me.uce_PE_ID_TIPO_CESE.TabIndex = 24
        '
        'uce_PE_ID_EST_TRABAJADOR
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.uce_PE_ID_EST_TRABAJADOR.Appearance = Appearance3
        Me.uce_PE_ID_EST_TRABAJADOR.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_EST_TRABAJADOR.Location = New System.Drawing.Point(93, 181)
        Me.uce_PE_ID_EST_TRABAJADOR.Name = "uce_PE_ID_EST_TRABAJADOR"
        Me.uce_PE_ID_EST_TRABAJADOR.Size = New System.Drawing.Size(103, 21)
        Me.uce_PE_ID_EST_TRABAJADOR.TabIndex = 3
        '
        'UltraLabel17
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance24
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(24, 183)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel17.TabIndex = 10
        Me.UltraLabel17.Text = "Estado Per."
        '
        'gb_otros
        '
        Me.gb_otros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_otros.Controls.Add(Me.UltraLabel9)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_TIPO_PER)
        Me.gb_otros.Controls.Add(Me.UltraLabel52)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_PERSONAL)
        Me.gb_otros.Controls.Add(Me.UltraLabel39)
        Me.gb_otros.Controls.Add(Me.UltraLabel37)
        Me.gb_otros.Controls.Add(Me.UltraLabel36)
        Me.gb_otros.Controls.Add(Me.UltraLabel64)
        Me.gb_otros.Controls.Add(Me.UltraLabel35)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_REGIMEN_LABORAL)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_OCUPACION)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_NIVEL_EDU)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_TIPO_PERSO_TARIFA)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_TIPO_TRABAJADOR)
        Me.gb_otros.Controls.Add(Me.UltraLabel13)
        Me.gb_otros.Controls.Add(Me.uce_PE_ID_CARGO)
        Me.gb_otros.Location = New System.Drawing.Point(11, 137)
        Me.gb_otros.Name = "gb_otros"
        Me.gb_otros.Size = New System.Drawing.Size(289, 208)
        Me.gb_otros.TabIndex = 31
        Me.gb_otros.TabStop = False
        '
        'UltraLabel9
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance29
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(4, 65)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel9.TabIndex = 26
        Me.UltraLabel9.Text = "Tipo Personal"
        '
        'uce_PE_ID_TIPO_PER
        '
        Me.uce_PE_ID_TIPO_PER.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_PER.Location = New System.Drawing.Point(87, 61)
        Me.uce_PE_ID_TIPO_PER.Name = "uce_PE_ID_TIPO_PER"
        Me.uce_PE_ID_TIPO_PER.Size = New System.Drawing.Size(190, 21)
        Me.uce_PE_ID_TIPO_PER.TabIndex = 6
        '
        'UltraLabel52
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel52.Appearance = Appearance95
        Me.UltraLabel52.AutoSize = True
        Me.UltraLabel52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel52.Location = New System.Drawing.Point(29, 40)
        Me.UltraLabel52.Name = "UltraLabel52"
        Me.UltraLabel52.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel52.TabIndex = 25
        Me.UltraLabel52.Text = "Personal"
        '
        'uce_PE_ID_PERSONAL
        '
        Me.uce_PE_ID_PERSONAL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_PERSONAL.Location = New System.Drawing.Point(87, 36)
        Me.uce_PE_ID_PERSONAL.Name = "uce_PE_ID_PERSONAL"
        Me.uce_PE_ID_PERSONAL.Size = New System.Drawing.Size(190, 21)
        Me.uce_PE_ID_PERSONAL.TabIndex = 5
        '
        'UltraLabel39
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel39.Appearance = Appearance63
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel39.Location = New System.Drawing.Point(4, 184)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel39.TabIndex = 14
        Me.UltraLabel39.Text = "Regimen Laboral"
        '
        'UltraLabel37
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel37.Appearance = Appearance60
        Me.UltraLabel37.AutoSize = True
        Me.UltraLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel37.Location = New System.Drawing.Point(36, 161)
        Me.UltraLabel37.Name = "UltraLabel37"
        Me.UltraLabel37.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel37.TabIndex = 14
        Me.UltraLabel37.Text = "Ocupacion"
        '
        'UltraLabel36
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel36.Appearance = Appearance56
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel36.Location = New System.Drawing.Point(12, 138)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(82, 14)
        Me.UltraLabel36.TabIndex = 14
        Me.UltraLabel36.Text = "Nivel Educativo"
        '
        'UltraLabel64
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel64.Appearance = Appearance57
        Me.UltraLabel64.AutoSize = True
        Me.UltraLabel64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel64.Location = New System.Drawing.Point(17, 90)
        Me.UltraLabel64.Name = "UltraLabel64"
        Me.UltraLabel64.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel64.TabIndex = 14
        Me.UltraLabel64.Text = "Tipo  Tarifa"
        '
        'UltraLabel35
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel35.Appearance = Appearance1
        Me.UltraLabel35.AutoSize = True
        Me.UltraLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel35.Location = New System.Drawing.Point(7, 115)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel35.TabIndex = 14
        Me.UltraLabel35.Text = "Tipo  Trabajador"
        '
        'uce_PE_ID_REGIMEN_LABORAL
        '
        Me.uce_PE_ID_REGIMEN_LABORAL.DropDownListWidth = 350
        Me.uce_PE_ID_REGIMEN_LABORAL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_REGIMEN_LABORAL.Location = New System.Drawing.Point(113, 180)
        Me.uce_PE_ID_REGIMEN_LABORAL.Name = "uce_PE_ID_REGIMEN_LABORAL"
        Me.uce_PE_ID_REGIMEN_LABORAL.Size = New System.Drawing.Size(164, 21)
        Me.uce_PE_ID_REGIMEN_LABORAL.TabIndex = 11
        '
        'uce_PE_ID_OCUPACION
        '
        Me.uce_PE_ID_OCUPACION.DropDownListWidth = 350
        Me.uce_PE_ID_OCUPACION.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_OCUPACION.Location = New System.Drawing.Point(113, 157)
        Me.uce_PE_ID_OCUPACION.Name = "uce_PE_ID_OCUPACION"
        Me.uce_PE_ID_OCUPACION.Size = New System.Drawing.Size(164, 21)
        Me.uce_PE_ID_OCUPACION.TabIndex = 10
        '
        'uce_PE_ID_NIVEL_EDU
        '
        Me.uce_PE_ID_NIVEL_EDU.DropDownListWidth = 350
        Me.uce_PE_ID_NIVEL_EDU.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_NIVEL_EDU.Location = New System.Drawing.Point(113, 134)
        Me.uce_PE_ID_NIVEL_EDU.Name = "uce_PE_ID_NIVEL_EDU"
        Me.uce_PE_ID_NIVEL_EDU.Size = New System.Drawing.Size(164, 21)
        Me.uce_PE_ID_NIVEL_EDU.TabIndex = 9
        '
        'uce_PE_ID_TIPO_PERSO_TARIFA
        '
        Me.uce_PE_ID_TIPO_PERSO_TARIFA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_PERSO_TARIFA.Location = New System.Drawing.Point(87, 86)
        Me.uce_PE_ID_TIPO_PERSO_TARIFA.Name = "uce_PE_ID_TIPO_PERSO_TARIFA"
        Me.uce_PE_ID_TIPO_PERSO_TARIFA.Size = New System.Drawing.Size(190, 21)
        Me.uce_PE_ID_TIPO_PERSO_TARIFA.TabIndex = 7
        '
        'uce_PE_ID_TIPO_TRABAJADOR
        '
        Me.uce_PE_ID_TIPO_TRABAJADOR.DropDownListWidth = 350
        Me.uce_PE_ID_TIPO_TRABAJADOR.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_TRABAJADOR.Location = New System.Drawing.Point(113, 111)
        Me.uce_PE_ID_TIPO_TRABAJADOR.Name = "uce_PE_ID_TIPO_TRABAJADOR"
        Me.uce_PE_ID_TIPO_TRABAJADOR.Size = New System.Drawing.Size(164, 21)
        Me.uce_PE_ID_TIPO_TRABAJADOR.TabIndex = 8
        '
        'UltraLabel13
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance8
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(43, 16)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(35, 14)
        Me.UltraLabel13.TabIndex = 8
        Me.UltraLabel13.Text = "Cargo"
        '
        'uce_PE_ID_CARGO
        '
        Me.uce_PE_ID_CARGO.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        EditorButton2.Key = "btn_ayuda"
        Me.uce_PE_ID_CARGO.ButtonsRight.Add(EditorButton2)
        Me.uce_PE_ID_CARGO.DropDownListWidth = 300
        Me.uce_PE_ID_CARGO.Location = New System.Drawing.Point(87, 12)
        Me.uce_PE_ID_CARGO.Name = "uce_PE_ID_CARGO"
        Me.uce_PE_ID_CARGO.Size = New System.Drawing.Size(190, 21)
        Me.uce_PE_ID_CARGO.TabIndex = 4
        '
        'gb_afp
        '
        Me.gb_afp.Controls.Add(Me.uos_tipo_comi)
        Me.gb_afp.Controls.Add(Me.UltraLabel15)
        Me.gb_afp.Controls.Add(Me.UltraLabel16)
        Me.gb_afp.Controls.Add(Me.UltraLabel69)
        Me.gb_afp.Controls.Add(Me.UltraLabel14)
        Me.gb_afp.Controls.Add(Me.txt_PE_NUM_AFP)
        Me.gb_afp.Controls.Add(Me.txt_PE_NUM_IPSS)
        Me.gb_afp.Controls.Add(Me.uce_PE_ID_AFP)
        Me.gb_afp.Location = New System.Drawing.Point(11, 16)
        Me.gb_afp.Name = "gb_afp"
        Me.gb_afp.Size = New System.Drawing.Size(289, 118)
        Me.gb_afp.TabIndex = 30
        Me.gb_afp.TabStop = False
        Me.gb_afp.Text = "Datos AFP"
        '
        'uos_tipo_comi
        '
        Me.uos_tipo_comi.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_tipo_comi.CheckedIndex = 0
        ValueListItem6.DataValue = CType(1, Short)
        ValueListItem6.DisplayText = "Flujo"
        ValueListItem7.DataValue = CType(2, Short)
        ValueListItem7.DisplayText = "Mixta"
        Me.uos_tipo_comi.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem6, ValueListItem7})
        Me.uos_tipo_comi.Location = New System.Drawing.Point(88, 94)
        Me.uos_tipo_comi.Name = "uos_tipo_comi"
        Me.uos_tipo_comi.Size = New System.Drawing.Size(186, 18)
        Me.uos_tipo_comi.TabIndex = 11
        Me.uos_tipo_comi.Text = "Flujo"
        '
        'UltraLabel15
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance53
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(14, 21)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel15.TabIndex = 10
        Me.UltraLabel15.Text = "AFP Afiliado"
        '
        'UltraLabel16
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance32
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(25, 44)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel16.TabIndex = 10
        Me.UltraLabel16.Text = "Num. AFP"
        '
        'UltraLabel69
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel69.Appearance = Appearance22
        Me.UltraLabel69.AutoSize = True
        Me.UltraLabel69.Location = New System.Drawing.Point(4, 94)
        Me.UltraLabel69.Name = "UltraLabel69"
        Me.UltraLabel69.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel69.TabIndex = 10
        Me.UltraLabel69.Text = "Tipo Comision"
        '
        'UltraLabel14
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance49
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(21, 68)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel14.TabIndex = 10
        Me.UltraLabel14.Text = "Num. IPSS"
        '
        'txt_PE_NUM_AFP
        '
        Me.txt_PE_NUM_AFP.Location = New System.Drawing.Point(87, 41)
        Me.txt_PE_NUM_AFP.MaxLength = 50
        Me.txt_PE_NUM_AFP.Name = "txt_PE_NUM_AFP"
        Me.txt_PE_NUM_AFP.Size = New System.Drawing.Size(190, 21)
        Me.txt_PE_NUM_AFP.TabIndex = 1
        '
        'txt_PE_NUM_IPSS
        '
        Me.txt_PE_NUM_IPSS.Location = New System.Drawing.Point(87, 64)
        Me.txt_PE_NUM_IPSS.MaxLength = 50
        Me.txt_PE_NUM_IPSS.Name = "txt_PE_NUM_IPSS"
        Me.txt_PE_NUM_IPSS.Size = New System.Drawing.Size(190, 21)
        Me.txt_PE_NUM_IPSS.TabIndex = 2
        '
        'uce_PE_ID_AFP
        '
        Me.uce_PE_ID_AFP.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_AFP.Location = New System.Drawing.Point(87, 17)
        Me.uce_PE_ID_AFP.Name = "uce_PE_ID_AFP"
        Me.uce_PE_ID_AFP.Size = New System.Drawing.Size(190, 21)
        Me.uce_PE_ID_AFP.TabIndex = 0
        '
        'gb_cts
        '
        Me.gb_cts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_cts.Controls.Add(Me.UltraLabel54)
        Me.gb_cts.Controls.Add(Me.UltraLabel57)
        Me.gb_cts.Controls.Add(Me.UltraLabel55)
        Me.gb_cts.Controls.Add(Me.UltraLabel56)
        Me.gb_cts.Controls.Add(Me.uce_PE_ID_BANCO_CTS)
        Me.gb_cts.Controls.Add(Me.uce_PE_ID_MONEDA_CTS)
        Me.gb_cts.Controls.Add(Me.txt_PE_NUM_CUENTA_CTS)
        Me.gb_cts.Controls.Add(Me.uce_PE_ID_TIPO_CUENTA_CTS)
        Me.gb_cts.Location = New System.Drawing.Point(311, 234)
        Me.gb_cts.Name = "gb_cts"
        Me.gb_cts.Size = New System.Drawing.Size(299, 112)
        Me.gb_cts.TabIndex = 29
        Me.gb_cts.TabStop = False
        Me.gb_cts.Text = "CTS"
        '
        'UltraLabel54
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel54.Appearance = Appearance64
        Me.UltraLabel54.AutoSize = True
        Me.UltraLabel54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel54.Location = New System.Drawing.Point(58, 18)
        Me.UltraLabel54.Name = "UltraLabel54"
        Me.UltraLabel54.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel54.TabIndex = 10
        Me.UltraLabel54.Text = "Banco CTS"
        '
        'UltraLabel57
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel57.Appearance = Appearance83
        Me.UltraLabel57.AutoSize = True
        Me.UltraLabel57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel57.Location = New System.Drawing.Point(49, 64)
        Me.UltraLabel57.Name = "UltraLabel57"
        Me.UltraLabel57.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel57.TabIndex = 10
        Me.UltraLabel57.Text = "Moneda CTS"
        '
        'UltraLabel55
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel55.Appearance = Appearance65
        Me.UltraLabel55.AutoSize = True
        Me.UltraLabel55.Location = New System.Drawing.Point(29, 41)
        Me.UltraLabel55.Name = "UltraLabel55"
        Me.UltraLabel55.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel55.TabIndex = 10
        Me.UltraLabel55.Text = "Tipo Cuenta CTS"
        '
        'UltraLabel56
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel56.Appearance = Appearance23
        Me.UltraLabel56.AutoSize = True
        Me.UltraLabel56.Location = New System.Drawing.Point(10, 87)
        Me.UltraLabel56.Name = "UltraLabel56"
        Me.UltraLabel56.Size = New System.Drawing.Size(110, 14)
        Me.UltraLabel56.TabIndex = 10
        Me.UltraLabel56.Text = "Numero Cuenta CTS"
        '
        'uce_PE_ID_BANCO_CTS
        '
        Me.uce_PE_ID_BANCO_CTS.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_BANCO_CTS.Location = New System.Drawing.Point(124, 14)
        Me.uce_PE_ID_BANCO_CTS.Name = "uce_PE_ID_BANCO_CTS"
        Me.uce_PE_ID_BANCO_CTS.Size = New System.Drawing.Size(164, 21)
        Me.uce_PE_ID_BANCO_CTS.TabIndex = 19
        '
        'uce_PE_ID_MONEDA_CTS
        '
        Me.uce_PE_ID_MONEDA_CTS.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_MONEDA_CTS.Location = New System.Drawing.Point(124, 60)
        Me.uce_PE_ID_MONEDA_CTS.Name = "uce_PE_ID_MONEDA_CTS"
        Me.uce_PE_ID_MONEDA_CTS.Size = New System.Drawing.Size(164, 21)
        Me.uce_PE_ID_MONEDA_CTS.TabIndex = 21
        '
        'txt_PE_NUM_CUENTA_CTS
        '
        Me.txt_PE_NUM_CUENTA_CTS.Location = New System.Drawing.Point(124, 83)
        Me.txt_PE_NUM_CUENTA_CTS.MaxLength = 50
        Me.txt_PE_NUM_CUENTA_CTS.Name = "txt_PE_NUM_CUENTA_CTS"
        Me.txt_PE_NUM_CUENTA_CTS.Size = New System.Drawing.Size(164, 21)
        Me.txt_PE_NUM_CUENTA_CTS.TabIndex = 22
        '
        'uce_PE_ID_TIPO_CUENTA_CTS
        '
        Me.uce_PE_ID_TIPO_CUENTA_CTS.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_CUENTA_CTS.Location = New System.Drawing.Point(124, 37)
        Me.uce_PE_ID_TIPO_CUENTA_CTS.Name = "uce_PE_ID_TIPO_CUENTA_CTS"
        Me.uce_PE_ID_TIPO_CUENTA_CTS.Size = New System.Drawing.Size(164, 21)
        Me.uce_PE_ID_TIPO_CUENTA_CTS.TabIndex = 20
        '
        'gb_remuneracion
        '
        Me.gb_remuneracion.Controls.Add(Me.txt_cod_interbancario)
        Me.gb_remuneracion.Controls.Add(Me.uce_IMP_REMU)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel22)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel21)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel20)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel19)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel18)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel58)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel23)
        Me.gb_remuneracion.Controls.Add(Me.txt_PE_NUM_CUENTA)
        Me.gb_remuneracion.Controls.Add(Me.uce_PE_ID_MONEDA_CUENTA)
        Me.gb_remuneracion.Controls.Add(Me.uce_PE_ID_TIPO_CUENTA_REMU)
        Me.gb_remuneracion.Controls.Add(Me.uce_PE_ID_TIPO_REMU)
        Me.gb_remuneracion.Controls.Add(Me.uce_PE_ID_MONEDA_REMU)
        Me.gb_remuneracion.Controls.Add(Me.UltraLabel26)
        Me.gb_remuneracion.Controls.Add(Me.txt_PE_HORAS_TRABAJO)
        Me.gb_remuneracion.Location = New System.Drawing.Point(310, 16)
        Me.gb_remuneracion.Name = "gb_remuneracion"
        Me.gb_remuneracion.Size = New System.Drawing.Size(300, 212)
        Me.gb_remuneracion.TabIndex = 28
        Me.gb_remuneracion.TabStop = False
        Me.gb_remuneracion.Text = "Datos de Remuneracion"
        '
        'txt_cod_interbancario
        '
        Me.txt_cod_interbancario.Location = New System.Drawing.Point(124, 161)
        Me.txt_cod_interbancario.MaxLength = 50
        Me.txt_cod_interbancario.Name = "txt_cod_interbancario"
        Me.txt_cod_interbancario.Size = New System.Drawing.Size(165, 21)
        Me.txt_cod_interbancario.TabIndex = 6
        '
        'uce_IMP_REMU
        '
        EditorButton3.Key = "btn_sueldo"
        Me.uce_IMP_REMU.ButtonsLeft.Add(EditorButton3)
        Me.uce_IMP_REMU.Location = New System.Drawing.Point(124, 19)
        Me.uce_IMP_REMU.Name = "uce_IMP_REMU"
        Me.uce_IMP_REMU.Size = New System.Drawing.Size(165, 21)
        Me.uce_IMP_REMU.TabIndex = 0
        '
        'UltraLabel22
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance84
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel22.Location = New System.Drawing.Point(15, 118)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(102, 14)
        Me.UltraLabel22.TabIndex = 10
        Me.UltraLabel22.Text = "Moneda Cta Remu."
        '
        'UltraLabel21
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance85
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(15, 94)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(102, 14)
        Me.UltraLabel21.TabIndex = 10
        Me.UltraLabel21.Text = "Tipo Cuenta Remu."
        '
        'UltraLabel20
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance25
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(14, 70)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(103, 14)
        Me.UltraLabel20.TabIndex = 10
        Me.UltraLabel20.Text = "Tipo Remuneracion"
        '
        'UltraLabel19
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance26
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(72, 47)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel19.TabIndex = 10
        Me.UltraLabel19.Text = "Moneda"
        '
        'UltraLabel18
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance43
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(39, 23)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel18.TabIndex = 10
        Me.UltraLabel18.Text = "Remuneracion"
        '
        'UltraLabel58
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel58.Appearance = Appearance86
        Me.UltraLabel58.AutoSize = True
        Me.UltraLabel58.Location = New System.Drawing.Point(23, 165)
        Me.UltraLabel58.Name = "UltraLabel58"
        Me.UltraLabel58.Size = New System.Drawing.Size(94, 14)
        Me.UltraLabel58.TabIndex = 10
        Me.UltraLabel58.Text = "Cod Interbancario"
        '
        'UltraLabel23
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance13
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(33, 142)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(84, 14)
        Me.UltraLabel23.TabIndex = 10
        Me.UltraLabel23.Text = "Numero Cuenta"
        '
        'txt_PE_NUM_CUENTA
        '
        Me.txt_PE_NUM_CUENTA.Location = New System.Drawing.Point(124, 138)
        Me.txt_PE_NUM_CUENTA.MaxLength = 50
        Me.txt_PE_NUM_CUENTA.Name = "txt_PE_NUM_CUENTA"
        Me.txt_PE_NUM_CUENTA.Size = New System.Drawing.Size(165, 21)
        Me.txt_PE_NUM_CUENTA.TabIndex = 5
        '
        'uce_PE_ID_MONEDA_CUENTA
        '
        Me.uce_PE_ID_MONEDA_CUENTA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_MONEDA_CUENTA.Location = New System.Drawing.Point(124, 114)
        Me.uce_PE_ID_MONEDA_CUENTA.Name = "uce_PE_ID_MONEDA_CUENTA"
        Me.uce_PE_ID_MONEDA_CUENTA.Size = New System.Drawing.Size(165, 21)
        Me.uce_PE_ID_MONEDA_CUENTA.TabIndex = 4
        '
        'uce_PE_ID_TIPO_CUENTA_REMU
        '
        Me.uce_PE_ID_TIPO_CUENTA_REMU.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_CUENTA_REMU.Location = New System.Drawing.Point(124, 90)
        Me.uce_PE_ID_TIPO_CUENTA_REMU.Name = "uce_PE_ID_TIPO_CUENTA_REMU"
        Me.uce_PE_ID_TIPO_CUENTA_REMU.Size = New System.Drawing.Size(165, 21)
        Me.uce_PE_ID_TIPO_CUENTA_REMU.TabIndex = 3
        '
        'uce_PE_ID_TIPO_REMU
        '
        Me.uce_PE_ID_TIPO_REMU.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_REMU.Location = New System.Drawing.Point(124, 66)
        Me.uce_PE_ID_TIPO_REMU.Name = "uce_PE_ID_TIPO_REMU"
        Me.uce_PE_ID_TIPO_REMU.Size = New System.Drawing.Size(165, 21)
        Me.uce_PE_ID_TIPO_REMU.TabIndex = 2
        '
        'uce_PE_ID_MONEDA_REMU
        '
        Me.uce_PE_ID_MONEDA_REMU.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_MONEDA_REMU.Location = New System.Drawing.Point(124, 43)
        Me.uce_PE_ID_MONEDA_REMU.Name = "uce_PE_ID_MONEDA_REMU"
        Me.uce_PE_ID_MONEDA_REMU.Size = New System.Drawing.Size(165, 21)
        Me.uce_PE_ID_MONEDA_REMU.TabIndex = 1
        '
        'UltraLabel26
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel26.Appearance = Appearance30
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(41, 188)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel26.TabIndex = 10
        Me.UltraLabel26.Text = "Horas Trabajo"
        '
        'txt_PE_HORAS_TRABAJO
        '
        Me.txt_PE_HORAS_TRABAJO.Location = New System.Drawing.Point(124, 184)
        Me.txt_PE_HORAS_TRABAJO.MaxLength = 50
        Me.txt_PE_HORAS_TRABAJO.Name = "txt_PE_HORAS_TRABAJO"
        Me.txt_PE_HORAS_TRABAJO.Size = New System.Drawing.Size(59, 21)
        Me.txt_PE_HORAS_TRABAJO.TabIndex = 7
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.gb_DatosAdicioanles)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(856, 361)
        '
        'gb_DatosAdicioanles
        '
        Me.gb_DatosAdicioanles.BackColor = System.Drawing.Color.White
        Me.gb_DatosAdicioanles.Controls.Add(Me.gb_otros2)
        Me.gb_DatosAdicioanles.Controls.Add(Me.gb_otro1)
        Me.gb_DatosAdicioanles.Controls.Add(Me.GroupBox1)
        Me.gb_DatosAdicioanles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_DatosAdicioanles.Location = New System.Drawing.Point(0, 0)
        Me.gb_DatosAdicioanles.Name = "gb_DatosAdicioanles"
        Me.gb_DatosAdicioanles.Size = New System.Drawing.Size(856, 361)
        Me.gb_DatosAdicioanles.TabIndex = 25
        Me.gb_DatosAdicioanles.TabStop = False
        '
        'gb_otros2
        '
        Me.gb_otros2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_otros2.Controls.Add(Me.uchk_EsRia)
        Me.gb_otros2.Controls.Add(Me.uchk_Calcular_cts)
        Me.gb_otros2.Controls.Add(Me.une_PE_NUM_HIJOS)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_ASIGNACION_FAM)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_AFECTO_QUINTA)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_ES_SINDICALIZADO)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_OTRO_ING_5TA)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_DOMICILIADO)
        Me.gb_otros2.Controls.Add(Me.UltraLabel59)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_SUJETO_HORA_NOC)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_SUJETO_REG_ALT)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_SUJETO_JOR_MAX)
        Me.gb_otros2.Controls.Add(Me.uchk_PE_DISCAPACIDAD)
        Me.gb_otros2.Location = New System.Drawing.Point(13, 172)
        Me.gb_otros2.Name = "gb_otros2"
        Me.gb_otros2.Size = New System.Drawing.Size(837, 118)
        Me.gb_otros2.TabIndex = 25
        Me.gb_otros2.TabStop = False
        '
        'uchk_EsRia
        '
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.uchk_EsRia.Appearance = Appearance44
        Me.uchk_EsRia.BackColor = System.Drawing.Color.Transparent
        Me.uchk_EsRia.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_EsRia.Location = New System.Drawing.Point(355, 38)
        Me.uchk_EsRia.Name = "uchk_EsRia"
        Me.uchk_EsRia.Size = New System.Drawing.Size(120, 20)
        Me.uchk_EsRia.TabIndex = 23
        Me.uchk_EsRia.Text = "R.I.A."
        '
        'uchk_Calcular_cts
        '
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Calcular_cts.Appearance = Appearance45
        Me.uchk_Calcular_cts.Checked = True
        Me.uchk_Calcular_cts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_Calcular_cts.Location = New System.Drawing.Point(355, 16)
        Me.uchk_Calcular_cts.Name = "uchk_Calcular_cts"
        Me.uchk_Calcular_cts.Size = New System.Drawing.Size(120, 20)
        Me.uchk_Calcular_cts.TabIndex = 22
        Me.uchk_Calcular_cts.Text = "Calcular CTS"
        '
        'une_PE_NUM_HIJOS
        '
        Me.une_PE_NUM_HIJOS.Enabled = False
        Me.une_PE_NUM_HIJOS.Location = New System.Drawing.Point(482, 88)
        Me.une_PE_NUM_HIJOS.MaskInput = "nn"
        Me.une_PE_NUM_HIJOS.Name = "une_PE_NUM_HIJOS"
        Me.une_PE_NUM_HIJOS.Size = New System.Drawing.Size(49, 21)
        Me.une_PE_NUM_HIJOS.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.une_PE_NUM_HIJOS.TabIndex = 21
        '
        'uchk_PE_ASIGNACION_FAM
        '
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_ASIGNACION_FAM.Appearance = Appearance42
        Me.uchk_PE_ASIGNACION_FAM.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_ASIGNACION_FAM.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_ASIGNACION_FAM.Location = New System.Drawing.Point(355, 88)
        Me.uchk_PE_ASIGNACION_FAM.Name = "uchk_PE_ASIGNACION_FAM"
        Me.uchk_PE_ASIGNACION_FAM.Size = New System.Drawing.Size(121, 20)
        Me.uchk_PE_ASIGNACION_FAM.TabIndex = 20
        Me.uchk_PE_ASIGNACION_FAM.Text = "Asignacion Familiar"
        '
        'uchk_PE_AFECTO_QUINTA
        '
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_AFECTO_QUINTA.Appearance = Appearance82
        Me.uchk_PE_AFECTO_QUINTA.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_AFECTO_QUINTA.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_AFECTO_QUINTA.Checked = True
        Me.uchk_PE_AFECTO_QUINTA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_PE_AFECTO_QUINTA.Location = New System.Drawing.Point(200, 88)
        Me.uchk_PE_AFECTO_QUINTA.Name = "uchk_PE_AFECTO_QUINTA"
        Me.uchk_PE_AFECTO_QUINTA.Size = New System.Drawing.Size(142, 20)
        Me.uchk_PE_AFECTO_QUINTA.TabIndex = 19
        Me.uchk_PE_AFECTO_QUINTA.Text = "Calcular 5ta Categoria"
        '
        'uchk_PE_ES_SINDICALIZADO
        '
        Appearance94.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_ES_SINDICALIZADO.Appearance = Appearance94
        Me.uchk_PE_ES_SINDICALIZADO.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_ES_SINDICALIZADO.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_ES_SINDICALIZADO.Location = New System.Drawing.Point(200, 62)
        Me.uchk_PE_ES_SINDICALIZADO.Name = "uchk_PE_ES_SINDICALIZADO"
        Me.uchk_PE_ES_SINDICALIZADO.Size = New System.Drawing.Size(133, 20)
        Me.uchk_PE_ES_SINDICALIZADO.TabIndex = 18
        Me.uchk_PE_ES_SINDICALIZADO.Text = "Sindicalizado"
        '
        'uchk_PE_OTRO_ING_5TA
        '
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_OTRO_ING_5TA.Appearance = Appearance70
        Me.uchk_PE_OTRO_ING_5TA.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_OTRO_ING_5TA.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_OTRO_ING_5TA.Location = New System.Drawing.Point(200, 38)
        Me.uchk_PE_OTRO_ING_5TA.Name = "uchk_PE_OTRO_ING_5TA"
        Me.uchk_PE_OTRO_ING_5TA.Size = New System.Drawing.Size(133, 20)
        Me.uchk_PE_OTRO_ING_5TA.TabIndex = 17
        Me.uchk_PE_OTRO_ING_5TA.Text = "Otros Ingresos de 5ta"
        '
        'uchk_PE_DOMICILIADO
        '
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_DOMICILIADO.Appearance = Appearance71
        Me.uchk_PE_DOMICILIADO.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_DOMICILIADO.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_DOMICILIADO.Location = New System.Drawing.Point(200, 16)
        Me.uchk_PE_DOMICILIADO.Name = "uchk_PE_DOMICILIADO"
        Me.uchk_PE_DOMICILIADO.Size = New System.Drawing.Size(120, 20)
        Me.uchk_PE_DOMICILIADO.TabIndex = 16
        Me.uchk_PE_DOMICILIADO.Text = "Domiciliado"
        '
        'UltraLabel59
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel59.Appearance = Appearance81
        Me.UltraLabel59.AutoSize = True
        Me.UltraLabel59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel59.Location = New System.Drawing.Point(537, 91)
        Me.UltraLabel59.Name = "UltraLabel59"
        Me.UltraLabel59.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel59.TabIndex = 21
        Me.UltraLabel59.Text = "Nº de Hijos"
        '
        'uchk_PE_SUJETO_HORA_NOC
        '
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_SUJETO_HORA_NOC.Appearance = Appearance72
        Me.uchk_PE_SUJETO_HORA_NOC.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_SUJETO_HORA_NOC.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_SUJETO_HORA_NOC.Location = New System.Drawing.Point(7, 88)
        Me.uchk_PE_SUJETO_HORA_NOC.Name = "uchk_PE_SUJETO_HORA_NOC"
        Me.uchk_PE_SUJETO_HORA_NOC.Size = New System.Drawing.Size(176, 20)
        Me.uchk_PE_SUJETO_HORA_NOC.TabIndex = 15
        Me.uchk_PE_SUJETO_HORA_NOC.Text = "Sujeto a Horario Nocturno"
        '
        'uchk_PE_SUJETO_REG_ALT
        '
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_SUJETO_REG_ALT.Appearance = Appearance73
        Me.uchk_PE_SUJETO_REG_ALT.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_SUJETO_REG_ALT.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_SUJETO_REG_ALT.Location = New System.Drawing.Point(7, 62)
        Me.uchk_PE_SUJETO_REG_ALT.Name = "uchk_PE_SUJETO_REG_ALT"
        Me.uchk_PE_SUJETO_REG_ALT.Size = New System.Drawing.Size(176, 20)
        Me.uchk_PE_SUJETO_REG_ALT.TabIndex = 14
        Me.uchk_PE_SUJETO_REG_ALT.Text = "Sujeto a Regimen Alternativo"
        '
        'uchk_PE_SUJETO_JOR_MAX
        '
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_SUJETO_JOR_MAX.Appearance = Appearance74
        Me.uchk_PE_SUJETO_JOR_MAX.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_SUJETO_JOR_MAX.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_SUJETO_JOR_MAX.Location = New System.Drawing.Point(7, 38)
        Me.uchk_PE_SUJETO_JOR_MAX.Name = "uchk_PE_SUJETO_JOR_MAX"
        Me.uchk_PE_SUJETO_JOR_MAX.Size = New System.Drawing.Size(154, 20)
        Me.uchk_PE_SUJETO_JOR_MAX.TabIndex = 13
        Me.uchk_PE_SUJETO_JOR_MAX.Text = "Sujeto a Jornada Maxima"
        '
        'uchk_PE_DISCAPACIDAD
        '
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_DISCAPACIDAD.Appearance = Appearance75
        Me.uchk_PE_DISCAPACIDAD.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_DISCAPACIDAD.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_DISCAPACIDAD.Location = New System.Drawing.Point(7, 16)
        Me.uchk_PE_DISCAPACIDAD.Name = "uchk_PE_DISCAPACIDAD"
        Me.uchk_PE_DISCAPACIDAD.Size = New System.Drawing.Size(120, 20)
        Me.uchk_PE_DISCAPACIDAD.TabIndex = 12
        Me.uchk_PE_DISCAPACIDAD.Text = "Discapacidad"
        '
        'gb_otro1
        '
        Me.gb_otro1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_otro1.Controls.Add(Me.UltraLabel47)
        Me.gb_otro1.Controls.Add(Me.UltraLabel46)
        Me.gb_otro1.Controls.Add(Me.UltraLabel48)
        Me.gb_otro1.Controls.Add(Me.UltraLabel51)
        Me.gb_otro1.Controls.Add(Me.UltraLabel50)
        Me.gb_otro1.Controls.Add(Me.UltraLabel49)
        Me.gb_otro1.Controls.Add(Me.UltraLabel45)
        Me.gb_otro1.Controls.Add(Me.UltraLabel53)
        Me.gb_otro1.Controls.Add(Me.UltraLabel43)
        Me.gb_otro1.Controls.Add(Me.UltraLabel44)
        Me.gb_otro1.Controls.Add(Me.uce_ID_AREA)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_COD_EPS_SER_PRO)
        Me.gb_otro1.Controls.Add(Me.uce_PE_AFILIADO_EPS_SER_PRO)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_SITUACION_EPS)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_CLASIFI_PER)
        Me.gb_otro1.Controls.Add(Me.UltraLabel25)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_SITUACION_ESPECIAL)
        Me.gb_otro1.Controls.Add(Me.uce_GRUPO_SANGUINEO)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_TIPO_PAGO)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_PERIODO_REMUNERA)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_SCTR_PENSION)
        Me.gb_otro1.Controls.Add(Me.uce_PE_ID_SCTR_SALUD)
        Me.gb_otro1.Location = New System.Drawing.Point(13, 11)
        Me.gb_otro1.Name = "gb_otro1"
        Me.gb_otro1.Size = New System.Drawing.Size(837, 154)
        Me.gb_otro1.TabIndex = 24
        Me.gb_otro1.TabStop = False
        '
        'UltraLabel47
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel47.Appearance = Appearance31
        Me.UltraLabel47.AutoSize = True
        Me.UltraLabel47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel47.Location = New System.Drawing.Point(8, 102)
        Me.UltraLabel47.Name = "UltraLabel47"
        Me.UltraLabel47.Size = New System.Drawing.Size(166, 14)
        Me.UltraLabel47.TabIndex = 21
        Me.UltraLabel47.Text = "Codigo  EPS / Servicios Propios"
        '
        'UltraLabel46
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel46.Appearance = Appearance66
        Me.UltraLabel46.AutoSize = True
        Me.UltraLabel46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel46.Location = New System.Drawing.Point(8, 75)
        Me.UltraLabel46.Name = "UltraLabel46"
        Me.UltraLabel46.Size = New System.Drawing.Size(173, 14)
        Me.UltraLabel46.TabIndex = 21
        Me.UltraLabel46.Text = "Afiliado a EPS / Servicios Propios"
        '
        'UltraLabel48
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel48.Appearance = Appearance67
        Me.UltraLabel48.AutoSize = True
        Me.UltraLabel48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel48.Location = New System.Drawing.Point(11, 129)
        Me.UltraLabel48.Name = "UltraLabel48"
        Me.UltraLabel48.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel48.TabIndex = 21
        Me.UltraLabel48.Text = "Situacion EPS"
        '
        'UltraLabel51
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel51.Appearance = Appearance79
        Me.UltraLabel51.AutoSize = True
        Me.UltraLabel51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel51.Location = New System.Drawing.Point(316, 102)
        Me.UltraLabel51.Name = "UltraLabel51"
        Me.UltraLabel51.Size = New System.Drawing.Size(116, 14)
        Me.UltraLabel51.TabIndex = 21
        Me.UltraLabel51.Text = "Clasificacion Personal"
        '
        'UltraLabel50
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel50.Appearance = Appearance80
        Me.UltraLabel50.AutoSize = True
        Me.UltraLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel50.Location = New System.Drawing.Point(335, 75)
        Me.UltraLabel50.Name = "UltraLabel50"
        Me.UltraLabel50.Size = New System.Drawing.Size(97, 14)
        Me.UltraLabel50.TabIndex = 21
        Me.UltraLabel50.Text = "Situacion Especial"
        '
        'UltraLabel49
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel49.Appearance = Appearance78
        Me.UltraLabel49.AutoSize = True
        Me.UltraLabel49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel49.Location = New System.Drawing.Point(361, 48)
        Me.UltraLabel49.Name = "UltraLabel49"
        Me.UltraLabel49.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel49.TabIndex = 21
        Me.UltraLabel49.Text = "Tipo de Pago"
        '
        'UltraLabel45
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel45.Appearance = Appearance77
        Me.UltraLabel45.AutoSize = True
        Me.UltraLabel45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel45.Location = New System.Drawing.Point(315, 19)
        Me.UltraLabel45.Name = "UltraLabel45"
        Me.UltraLabel45.Size = New System.Drawing.Size(117, 14)
        Me.UltraLabel45.TabIndex = 21
        Me.UltraLabel45.Text = "Periodo Remunerativo"
        '
        'UltraLabel53
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel53.Appearance = Appearance76
        Me.UltraLabel53.AutoSize = True
        Me.UltraLabel53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel53.Location = New System.Drawing.Point(649, 19)
        Me.UltraLabel53.Name = "UltraLabel53"
        Me.UltraLabel53.Size = New System.Drawing.Size(28, 14)
        Me.UltraLabel53.TabIndex = 21
        Me.UltraLabel53.Text = "Area"
        '
        'UltraLabel43
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel43.Appearance = Appearance68
        Me.UltraLabel43.AutoSize = True
        Me.UltraLabel43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel43.Location = New System.Drawing.Point(8, 48)
        Me.UltraLabel43.Name = "UltraLabel43"
        Me.UltraLabel43.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel43.TabIndex = 21
        Me.UltraLabel43.Text = "SCTR Pension"
        '
        'UltraLabel44
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel44.Appearance = Appearance28
        Me.UltraLabel44.AutoSize = True
        Me.UltraLabel44.Location = New System.Drawing.Point(8, 19)
        Me.UltraLabel44.Name = "UltraLabel44"
        Me.UltraLabel44.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel44.TabIndex = 22
        Me.UltraLabel44.Text = "SCTR Salud"
        '
        'uce_ID_AREA
        '
        EditorButton4.Key = "btn_ayuda"
        Me.uce_ID_AREA.ButtonsRight.Add(EditorButton4)
        Me.uce_ID_AREA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_ID_AREA.Location = New System.Drawing.Point(683, 15)
        Me.uce_ID_AREA.Name = "uce_ID_AREA"
        Me.uce_ID_AREA.Size = New System.Drawing.Size(145, 21)
        Me.uce_ID_AREA.TabIndex = 10
        '
        'uce_PE_ID_COD_EPS_SER_PRO
        '
        Me.uce_PE_ID_COD_EPS_SER_PRO.DropDownListWidth = 250
        Me.uce_PE_ID_COD_EPS_SER_PRO.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_COD_EPS_SER_PRO.Location = New System.Drawing.Point(191, 98)
        Me.uce_PE_ID_COD_EPS_SER_PRO.Name = "uce_PE_ID_COD_EPS_SER_PRO"
        Me.uce_PE_ID_COD_EPS_SER_PRO.Size = New System.Drawing.Size(105, 21)
        Me.uce_PE_ID_COD_EPS_SER_PRO.TabIndex = 3
        '
        'uce_PE_AFILIADO_EPS_SER_PRO
        '
        Me.uce_PE_AFILIADO_EPS_SER_PRO.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "Si"
        ValueListItem2.DataValue = CType(2, Short)
        ValueListItem2.DisplayText = "No"
        Me.uce_PE_AFILIADO_EPS_SER_PRO.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uce_PE_AFILIADO_EPS_SER_PRO.Location = New System.Drawing.Point(191, 71)
        Me.uce_PE_AFILIADO_EPS_SER_PRO.Name = "uce_PE_AFILIADO_EPS_SER_PRO"
        Me.uce_PE_AFILIADO_EPS_SER_PRO.Size = New System.Drawing.Size(105, 21)
        Me.uce_PE_AFILIADO_EPS_SER_PRO.TabIndex = 2
        '
        'uce_PE_ID_SITUACION_EPS
        '
        Me.uce_PE_ID_SITUACION_EPS.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_SITUACION_EPS.Location = New System.Drawing.Point(108, 125)
        Me.uce_PE_ID_SITUACION_EPS.Name = "uce_PE_ID_SITUACION_EPS"
        Me.uce_PE_ID_SITUACION_EPS.Size = New System.Drawing.Size(188, 21)
        Me.uce_PE_ID_SITUACION_EPS.TabIndex = 4
        '
        'uce_PE_ID_CLASIFI_PER
        '
        Me.uce_PE_ID_CLASIFI_PER.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_CLASIFI_PER.Location = New System.Drawing.Point(438, 98)
        Me.uce_PE_ID_CLASIFI_PER.Name = "uce_PE_ID_CLASIFI_PER"
        Me.uce_PE_ID_CLASIFI_PER.Size = New System.Drawing.Size(166, 21)
        Me.uce_PE_ID_CLASIFI_PER.TabIndex = 8
        '
        'UltraLabel25
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance58
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel25.Location = New System.Drawing.Point(339, 129)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(93, 14)
        Me.UltraLabel25.TabIndex = 12
        Me.UltraLabel25.Text = "Grupo Sanguineo"
        '
        'uce_PE_ID_SITUACION_ESPECIAL
        '
        Me.uce_PE_ID_SITUACION_ESPECIAL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_SITUACION_ESPECIAL.Location = New System.Drawing.Point(438, 71)
        Me.uce_PE_ID_SITUACION_ESPECIAL.Name = "uce_PE_ID_SITUACION_ESPECIAL"
        Me.uce_PE_ID_SITUACION_ESPECIAL.Size = New System.Drawing.Size(166, 21)
        Me.uce_PE_ID_SITUACION_ESPECIAL.TabIndex = 7
        '
        'uce_GRUPO_SANGUINEO
        '
        EditorButton5.Key = "btn_ayuda"
        Me.uce_GRUPO_SANGUINEO.ButtonsRight.Add(EditorButton5)
        Me.uce_GRUPO_SANGUINEO.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_GRUPO_SANGUINEO.Location = New System.Drawing.Point(438, 125)
        Me.uce_GRUPO_SANGUINEO.Name = "uce_GRUPO_SANGUINEO"
        Me.uce_GRUPO_SANGUINEO.Size = New System.Drawing.Size(166, 21)
        Me.uce_GRUPO_SANGUINEO.TabIndex = 11
        '
        'uce_PE_ID_TIPO_PAGO
        '
        Me.uce_PE_ID_TIPO_PAGO.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_TIPO_PAGO.Location = New System.Drawing.Point(438, 44)
        Me.uce_PE_ID_TIPO_PAGO.Name = "uce_PE_ID_TIPO_PAGO"
        Me.uce_PE_ID_TIPO_PAGO.Size = New System.Drawing.Size(166, 21)
        Me.uce_PE_ID_TIPO_PAGO.TabIndex = 6
        '
        'uce_PE_ID_PERIODO_REMUNERA
        '
        Me.uce_PE_ID_PERIODO_REMUNERA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_PERIODO_REMUNERA.Location = New System.Drawing.Point(438, 15)
        Me.uce_PE_ID_PERIODO_REMUNERA.Name = "uce_PE_ID_PERIODO_REMUNERA"
        Me.uce_PE_ID_PERIODO_REMUNERA.Size = New System.Drawing.Size(166, 21)
        Me.uce_PE_ID_PERIODO_REMUNERA.TabIndex = 5
        '
        'uce_PE_ID_SCTR_PENSION
        '
        Me.uce_PE_ID_SCTR_PENSION.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_SCTR_PENSION.Location = New System.Drawing.Point(90, 44)
        Me.uce_PE_ID_SCTR_PENSION.Name = "uce_PE_ID_SCTR_PENSION"
        Me.uce_PE_ID_SCTR_PENSION.Size = New System.Drawing.Size(206, 21)
        Me.uce_PE_ID_SCTR_PENSION.TabIndex = 1
        '
        'uce_PE_ID_SCTR_SALUD
        '
        Me.uce_PE_ID_SCTR_SALUD.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PE_ID_SCTR_SALUD.Location = New System.Drawing.Point(90, 15)
        Me.uce_PE_ID_SCTR_SALUD.Name = "uce_PE_ID_SCTR_SALUD"
        Me.uce_PE_ID_SCTR_SALUD.Size = New System.Drawing.Size(206, 21)
        Me.uce_PE_ID_SCTR_SALUD.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.uchk_PE_CONSIDERA_FT)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 57)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marcaciones"
        '
        'uchk_PE_CONSIDERA_FT
        '
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.uchk_PE_CONSIDERA_FT.Appearance = Appearance69
        Me.uchk_PE_CONSIDERA_FT.BackColor = System.Drawing.Color.Transparent
        Me.uchk_PE_CONSIDERA_FT.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_PE_CONSIDERA_FT.Location = New System.Drawing.Point(24, 19)
        Me.uchk_PE_CONSIDERA_FT.Name = "uchk_PE_CONSIDERA_FT"
        Me.uchk_PE_CONSIDERA_FT.Size = New System.Drawing.Size(215, 20)
        Me.uchk_PE_CONSIDERA_FT.TabIndex = 20
        Me.uchk_PE_CONSIDERA_FT.Text = "No considerar ""Falta Tardanza"""
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.uchart_cc)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraLabel60)
        Me.UltraTabPageControl6.Controls.Add(Me.txt_total_porce_cc)
        Me.UltraTabPageControl6.Controls.Add(Me.ug_ccosto)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(856, 361)
        '
        'uchart_cc
        '
        Me.uchart_cc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uchart_cc.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.uchart_cc.Axis.PE = PaintElement1
        Me.uchart_cc.Axis.X.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uchart_cc.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uchart_cc.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.uchart_cc.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uchart_cc.Axis.X.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uchart_cc.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.X.LineThickness = 1
        Me.uchart_cc.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uchart_cc.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.X.MajorGridLines.Visible = True
        Me.uchart_cc.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uchart_cc.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.X.MinorGridLines.Visible = False
        Me.uchart_cc.Axis.X.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uchart_cc.Axis.X.Visible = True
        Me.uchart_cc.Axis.X2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uchart_cc.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.uchart_cc.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.uchart_cc.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uchart_cc.Axis.X2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uchart_cc.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.X2.LineThickness = 1
        Me.uchart_cc.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uchart_cc.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.X2.MajorGridLines.Visible = True
        Me.uchart_cc.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uchart_cc.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.X2.MinorGridLines.Visible = False
        Me.uchart_cc.Axis.X2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uchart_cc.Axis.X2.Visible = False
        Me.uchart_cc.Axis.Y.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uchart_cc.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.uchart_cc.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.uchart_cc.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.Y.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uchart_cc.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.uchart_cc.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.uchart_cc.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uchart_cc.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Y.LineThickness = 1
        Me.uchart_cc.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uchart_cc.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Y.MajorGridLines.Visible = True
        Me.uchart_cc.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uchart_cc.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Y.MinorGridLines.Visible = False
        Me.uchart_cc.Axis.Y.RangeMax = 100.0R
        Me.uchart_cc.Axis.Y.RangeType = Infragistics.UltraChart.[Shared].Styles.AxisRangeType.Custom
        Me.uchart_cc.Axis.Y.TickmarkInterval = 10.0R
        Me.uchart_cc.Axis.Y.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uchart_cc.Axis.Y.Visible = True
        Me.uchart_cc.Axis.Y2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uchart_cc.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uchart_cc.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.uchart_cc.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.Y2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uchart_cc.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.uchart_cc.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uchart_cc.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uchart_cc.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Y2.LineThickness = 1
        Me.uchart_cc.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uchart_cc.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Y2.MajorGridLines.Visible = True
        Me.uchart_cc.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uchart_cc.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Y2.MinorGridLines.Visible = False
        Me.uchart_cc.Axis.Y2.TickmarkInterval = 40.0R
        Me.uchart_cc.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uchart_cc.Axis.Y2.Visible = False
        Me.uchart_cc.Axis.Z.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uchart_cc.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uchart_cc.Axis.Z.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.uchart_cc.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.Z.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uchart_cc.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uchart_cc.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Z.LineThickness = 1
        Me.uchart_cc.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uchart_cc.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Z.MajorGridLines.Visible = True
        Me.uchart_cc.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uchart_cc.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Z.MinorGridLines.Visible = False
        Me.uchart_cc.Axis.Z.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uchart_cc.Axis.Z.Visible = False
        Me.uchart_cc.Axis.Z2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uchart_cc.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uchart_cc.Axis.Z2.Labels.ItemFormatString = ""
        Me.uchart_cc.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.Z2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uchart_cc.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uchart_cc.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uchart_cc.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uchart_cc.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uchart_cc.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uchart_cc.Axis.Z2.LineThickness = 1
        Me.uchart_cc.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uchart_cc.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Z2.MajorGridLines.Visible = True
        Me.uchart_cc.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uchart_cc.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uchart_cc.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uchart_cc.Axis.Z2.MinorGridLines.Visible = False
        Me.uchart_cc.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uchart_cc.Axis.Z2.Visible = False
        Me.uchart_cc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.uchart_cc.ColorModel.AlphaLevel = CType(150, Byte)
        Me.uchart_cc.ColorModel.ColorBegin = System.Drawing.Color.Pink
        Me.uchart_cc.ColorModel.ColorEnd = System.Drawing.Color.DarkRed
        Me.uchart_cc.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.CustomLinear
        Me.uchart_cc.Effects.Effects.Add(GradientEffect1)
        Me.uchart_cc.Location = New System.Drawing.Point(407, 21)
        Me.uchart_cc.Name = "uchart_cc"
        Me.uchart_cc.Size = New System.Drawing.Size(442, 324)
        Me.uchart_cc.TabIndex = 12
        Me.uchart_cc.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray
        Me.uchart_cc.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray
        '
        'UltraLabel60
        '
        Me.UltraLabel60.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel60.Appearance = Appearance19
        Me.UltraLabel60.AutoSize = True
        Me.UltraLabel60.Location = New System.Drawing.Point(136, 327)
        Me.UltraLabel60.Name = "UltraLabel60"
        Me.UltraLabel60.Size = New System.Drawing.Size(126, 14)
        Me.UltraLabel60.TabIndex = 11
        Me.UltraLabel60.Text = "TOTAL PORCENTAJE :"
        '
        'txt_total_porce_cc
        '
        Me.txt_total_porce_cc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance51.TextHAlignAsString = "Right"
        Me.txt_total_porce_cc.Appearance = Appearance51
        Me.txt_total_porce_cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_porce_cc.Location = New System.Drawing.Point(268, 321)
        Me.txt_total_porce_cc.Name = "txt_total_porce_cc"
        Me.txt_total_porce_cc.ReadOnly = True
        Me.txt_total_porce_cc.Size = New System.Drawing.Size(133, 24)
        Me.txt_total_porce_cc.TabIndex = 1
        '
        'ug_ccosto
        '
        Me.ug_ccosto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ug_ccosto.DataSource = Me.uds_Ccosto
        Me.ug_ccosto.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Header.Caption = "CODIGO"
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Width = 52
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.Header.Caption = "CENTRO COSTO"
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Width = 204
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance50.TextHAlignAsString = "Center"
        UltraGridColumn16.CellAppearance = Appearance50
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.ug_ccosto.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ug_ccosto.Location = New System.Drawing.Point(18, 21)
        Me.ug_ccosto.Name = "ug_ccosto"
        Me.ug_ccosto.Size = New System.Drawing.Size(383, 294)
        Me.ug_ccosto.TabIndex = 0
        '
        'uds_Ccosto
        '
        Me.uds_Ccosto.AllowDelete = False
        UltraDataColumn16.DataType = GetType(Double)
        Me.uds_Ccosto.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(856, 361)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel61)
        Me.UltraGroupBox2.Controls.Add(Me.txt_ficha)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(6, 25)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(377, 326)
        Me.UltraGroupBox2.TabIndex = 18
        Me.UltraGroupBox2.Text = "Ficha de Datos"
        '
        'UltraLabel61
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel61.Appearance = Appearance4
        Me.UltraLabel61.Location = New System.Drawing.Point(6, 31)
        Me.UltraLabel61.Name = "UltraLabel61"
        Me.UltraLabel61.Size = New System.Drawing.Size(363, 38)
        Me.UltraLabel61.TabIndex = 6
        Me.UltraLabel61.Text = "Escriba una ficha de datos como texto plano acerca del trabajador, puede ingresar" & _
    " la cantidad de texto equivalente a una hoja A4."
        '
        'txt_ficha
        '
        Me.txt_ficha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha.Location = New System.Drawing.Point(6, 77)
        Me.txt_ficha.Multiline = True
        Me.txt_ficha.Name = "txt_ficha"
        Me.txt_ficha.Size = New System.Drawing.Size(363, 243)
        Me.txt_ficha.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_ver_doc)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_agregar_archivo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel62)
        Me.UltraGroupBox1.Controls.Add(Me.ug_Documentos)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(389, 25)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(459, 326)
        Me.UltraGroupBox1.TabIndex = 17
        Me.UltraGroupBox1.Text = "Almacen de Documentos"
        '
        'ubtn_ver_doc
        '
        Appearance116.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.ubtn_ver_doc.Appearance = Appearance116
        Me.ubtn_ver_doc.Location = New System.Drawing.Point(331, 90)
        Me.ubtn_ver_doc.Name = "ubtn_ver_doc"
        Me.ubtn_ver_doc.Size = New System.Drawing.Size(108, 29)
        Me.ubtn_ver_doc.TabIndex = 16
        Me.ubtn_ver_doc.Text = "Visualizar Doc."
        '
        'ubtn_agregar_archivo
        '
        Appearance117.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.ubtn_agregar_archivo.Appearance = Appearance117
        Me.ubtn_agregar_archivo.Location = New System.Drawing.Point(10, 90)
        Me.ubtn_agregar_archivo.Name = "ubtn_agregar_archivo"
        Me.ubtn_agregar_archivo.Size = New System.Drawing.Size(105, 29)
        Me.ubtn_agregar_archivo.TabIndex = 14
        Me.ubtn_agregar_archivo.Text = "Agregar doc."
        '
        'UltraLabel62
        '
        Appearance115.BackColor = System.Drawing.Color.Transparent
        Appearance115.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel62.Appearance = Appearance115
        Me.UltraLabel62.Location = New System.Drawing.Point(10, 23)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(429, 50)
        Me.UltraLabel62.TabIndex = 6
        Me.UltraLabel62.Text = resources.GetString("UltraLabel62.Text")
        '
        'ug_Documentos
        '
        Me.ug_Documentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Documentos.DataSource = Me.uds_Documentos
        Me.ug_Documentos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.Header.Caption = "Archivo"
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.Caption = "Descripcion"
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        Me.ug_Documentos.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ug_Documentos.Location = New System.Drawing.Point(10, 125)
        Me.ug_Documentos.Name = "ug_Documentos"
        Me.ug_Documentos.Size = New System.Drawing.Size(429, 195)
        Me.ug_Documentos.TabIndex = 1
        '
        'uds_Documentos
        '
        UltraDataColumn17.DataType = GetType(UInteger)
        Me.uds_Documentos.Band.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19})
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraLabel70)
        Me.UltraTabPageControl8.Controls.Add(Me.ubtn_Generar_Contrato)
        Me.UltraTabPageControl8.Controls.Add(Me.UltraLabel63)
        Me.UltraTabPageControl8.Controls.Add(Me.ug_Contratos)
        Me.UltraTabPageControl8.Controls.Add(Me.UltraLabel67)
        Me.UltraTabPageControl8.Controls.Add(Me.UltraLabel66)
        Me.UltraTabPageControl8.Controls.Add(Me.ug_Conceptos)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(856, 361)
        '
        'UltraLabel70
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel70.Appearance = Appearance20
        Me.UltraLabel70.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel70.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel70.Location = New System.Drawing.Point(500, 185)
        Me.UltraLabel70.Name = "UltraLabel70"
        Me.UltraLabel70.Size = New System.Drawing.Size(206, 63)
        Me.UltraLabel70.TabIndex = 12
        Me.UltraLabel70.Text = "Pimero GRABE la Ficha del personal y luego puede generar el contrato"
        '
        'ubtn_Generar_Contrato
        '
        Me.ubtn_Generar_Contrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Generar_Contrato.Location = New System.Drawing.Point(712, 220)
        Me.ubtn_Generar_Contrato.Name = "ubtn_Generar_Contrato"
        Me.ubtn_Generar_Contrato.Size = New System.Drawing.Size(134, 28)
        Me.ubtn_Generar_Contrato.TabIndex = 11
        Me.ubtn_Generar_Contrato.Text = "&Generar Contrato"
        '
        'UltraLabel63
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel63.Appearance = Appearance5
        Me.UltraLabel63.AutoSize = True
        Me.UltraLabel63.Location = New System.Drawing.Point(13, 234)
        Me.UltraLabel63.Name = "UltraLabel63"
        Me.UltraLabel63.Size = New System.Drawing.Size(135, 14)
        Me.UltraLabel63.TabIndex = 10
        Me.UltraLabel63.Text = "Contratos del Trabajador : "
        '
        'ug_Contratos
        '
        Me.ug_Contratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Contratos.DataSource = Me.uds_Contratos
        Me.ug_Contratos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.VisiblePosition = 0
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.Header.Caption = "Tipo Contrato"
        UltraGridColumn21.Header.VisiblePosition = 1
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.Header.Caption = "Inicio Contrato"
        UltraGridColumn22.Header.VisiblePosition = 2
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.Header.Caption = "Fin Contrato"
        UltraGridColumn23.Header.VisiblePosition = 3
        UltraGridColumn23.Width = 110
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.Caption = "Comentario"
        UltraGridColumn24.Header.VisiblePosition = 4
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        Me.ug_Contratos.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ug_Contratos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Contratos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Contratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_Contratos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Contratos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Contratos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Contratos.Location = New System.Drawing.Point(13, 254)
        Me.ug_Contratos.Name = "ug_Contratos"
        Me.ug_Contratos.Size = New System.Drawing.Size(833, 104)
        Me.ug_Contratos.TabIndex = 9
        '
        'uds_Contratos
        '
        UltraDataColumn20.DataType = GetType(Short)
        UltraDataColumn22.DataType = GetType(Date)
        UltraDataColumn23.DataType = GetType(Date)
        Me.uds_Contratos.Band.Columns.AddRange(New Object() {UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'UltraLabel67
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel67.Appearance = Appearance88
        Me.UltraLabel67.Location = New System.Drawing.Point(13, 185)
        Me.UltraLabel67.Name = "UltraLabel67"
        Me.UltraLabel67.Size = New System.Drawing.Size(266, 43)
        Me.UltraLabel67.TabIndex = 8
        Me.UltraLabel67.Text = "Registre los contratos o periodos en que laborara el trabajador, puede agregar va" & _
    "rios periodos seguidos y GENERAR su contrato automaticamente."
        '
        'UltraLabel66
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel66.Appearance = Appearance109
        Me.UltraLabel66.Location = New System.Drawing.Point(13, 12)
        Me.UltraLabel66.Name = "UltraLabel66"
        Me.UltraLabel66.Size = New System.Drawing.Size(846, 27)
        Me.UltraLabel66.TabIndex = 7
        Me.UltraLabel66.Text = "Agregue conceptos al trabajador, estos conceptos se consideraran en el calculo de" & _
    " la planilla mensual."
        '
        'ug_Conceptos
        '
        Me.ug_Conceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Conceptos.DataSource = Me.uds_Conceptos
        Me.ug_Conceptos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.Header.Caption = "CONCEPTO"
        UltraGridColumn26.Header.VisiblePosition = 1
        UltraGridColumn26.Width = 397
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance89.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn27.CellAppearance = Appearance89
        UltraGridColumn27.Header.Caption = "VALOR"
        UltraGridColumn27.Header.VisiblePosition = 3
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn28.Header.VisiblePosition = 2
        UltraGridColumn28.Width = 174
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn29.Header.VisiblePosition = 4
        UltraGridColumn29.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        Me.ug_Conceptos.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.ug_Conceptos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Conceptos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Conceptos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Conceptos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_Conceptos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Conceptos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Conceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Conceptos.Location = New System.Drawing.Point(13, 45)
        Me.ug_Conceptos.Name = "ug_Conceptos"
        Me.ug_Conceptos.Size = New System.Drawing.Size(833, 97)
        Me.ug_Conceptos.TabIndex = 0
        Me.ug_Conceptos.Text = "UltraGrid1"
        '
        'uds_Conceptos
        '
        UltraDataColumn25.DataType = GetType(Short)
        UltraDataColumn26.DataType = GetType(Short)
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn29.DataType = GetType(Short)
        Me.uds_Conceptos.Band.Columns.AddRange(New Object() {UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29})
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(877, 346)
        '
        'utc_Mante
        '
        Me.utc_Mante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Mante.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Mante.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Mante.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Mante.Controls.Add(Me.UltraTabPageControl3)
        Me.utc_Mante.Controls.Add(Me.UltraTabPageControl4)
        Me.utc_Mante.Controls.Add(Me.UltraTabPageControl5)
        Me.utc_Mante.Controls.Add(Me.UltraTabPageControl6)
        Me.utc_Mante.Controls.Add(Me.UltraTabPageControl8)
        Me.utc_Mante.Location = New System.Drawing.Point(12, 28)
        Me.utc_Mante.Name = "utc_Mante"
        Me.utc_Mante.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Mante.Size = New System.Drawing.Size(860, 387)
        Me.utc_Mante.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado de Personal"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Datos Personales"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Datos Laborales"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Datos Adicionales"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Centro Costos"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Ficha / Documentos"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Conceptos/Contratos"
        Me.utc_Mante.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab6, UltraTab5, UltraTab8})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(856, 361)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Reporte, Me.ToolStripSeparator6, Me.Tool_Salir, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(884, 25)
        Me.ToolS_Mantenimiento.TabIndex = 5
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
        Me.Tool_Grabar.ToolTipText = "Grabar (F4)"
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
        'Tool_Reporte
        '
        Me.Tool_Reporte.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Reporte.Name = "Tool_Reporte"
        Me.Tool_Reporte.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Reporte.Text = "Reporte"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'PL_MA_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(884, 421)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.utc_Mante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PL_MA_Personal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.gb_DatosPersonales.ResumeLayout(False)
        CType(Me.ugb_telefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_telefonos.ResumeLayout(False)
        CType(Me.ug_comunicacion_persona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Comunicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_direccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_direccion.ResumeLayout(False)
        Me.ugb_direccion.PerformLayout()
        CType(Me.txt_PE_INTERIOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NOMBRE_ZONA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_REFERENCIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_ZONA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NUMERO_VIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NOMBRE_VIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_VIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_UBIGEO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_datos_personales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos_personales.ResumeLayout(False)
        Me.ugb_datos_personales.PerformLayout()
        CType(Me.uos_PE_ID_SEXO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_APE_PAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_APE_MAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NOM_PRI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NOM_SEG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NUM_DOC_PER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_NACIONALIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_DOC_PER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_PE_FEC_NAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_EST_CIVIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.ugb_codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_codigo.ResumeLayout(False)
        Me.ugb_codigo.PerformLayout()
        CType(Me.txt_PE_CODIGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_CODIGO_ALT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_ID_ANEXO_CONTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.gb_DatosLaborales.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        Me.gb_cese.ResumeLayout(False)
        Me.gb_cese.PerformLayout()
        CType(Me.udte_PE_FEC_ING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_CESE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_EST_TRABAJADOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_otros.ResumeLayout(False)
        Me.gb_otros.PerformLayout()
        CType(Me.uce_PE_ID_TIPO_PER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_PERSONAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_REGIMEN_LABORAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_OCUPACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_NIVEL_EDU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_PERSO_TARIFA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_TRABAJADOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_CARGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_afp.ResumeLayout(False)
        Me.gb_afp.PerformLayout()
        CType(Me.uos_tipo_comi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NUM_AFP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NUM_IPSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_AFP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_cts.ResumeLayout(False)
        Me.gb_cts.PerformLayout()
        CType(Me.uce_PE_ID_BANCO_CTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_MONEDA_CTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NUM_CUENTA_CTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_CUENTA_CTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_remuneracion.ResumeLayout(False)
        Me.gb_remuneracion.PerformLayout()
        CType(Me.txt_cod_interbancario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_IMP_REMU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_NUM_CUENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_MONEDA_CUENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_CUENTA_REMU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_REMU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_MONEDA_REMU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PE_HORAS_TRABAJO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.gb_DatosAdicioanles.ResumeLayout(False)
        Me.gb_otros2.ResumeLayout(False)
        Me.gb_otros2.PerformLayout()
        CType(Me.une_PE_NUM_HIJOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_otro1.ResumeLayout(False)
        Me.gb_otro1.PerformLayout()
        CType(Me.uce_ID_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_COD_EPS_SER_PRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_AFILIADO_EPS_SER_PRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_SITUACION_EPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_CLASIFI_PER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_SITUACION_ESPECIAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_GRUPO_SANGUINEO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_TIPO_PAGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_PERIODO_REMUNERA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_SCTR_PENSION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PE_ID_SCTR_SALUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.UltraTabPageControl6.PerformLayout()
        CType(Me.uchart_cc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_porce_cc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ccosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Ccosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.txt_ficha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ug_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl8.PerformLayout()
        CType(Me.ug_Contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Conceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Conceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Mante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Mante.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_Mante As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Listado As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Listado As Infragistics.Win.UltraWinDataSource.UltraDataSource
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
    Friend WithEvents txt_PE_CODIGO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_CODIGO_ALT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_ID_ANEXO_CONTA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_NOM_SEG As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PE_NOM_PRI As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PE_APE_MAT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PE_APE_PAT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_PE_ID_TIPO_DOC_PER As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_PE_NUM_DOC_PER As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents upb_img As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents udte_PE_FEC_NAC As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_EST_CIVIL As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_CARGO As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_NUM_AFP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PE_NUM_IPSS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_PE_ID_AFP As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_EST_TRABAJADOR As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_IMP_REMU As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_TIPO_CUENTA_REMU As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_TIPO_REMU As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_MONEDA_REMU As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_MONEDA_CUENTA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_NACIONALIDAD As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_NUM_CUENTA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_HORAS_TRABAJO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_GRUPO_SANGUINEO As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_INTERIOR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PE_NUMERO_VIA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PE_NOMBRE_ZONA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PE_NOMBRE_VIA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_PE_ID_TIPO_ZONA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_TIPO_VIA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel33 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_REFERENCIA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_UBIGEO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_comunicacion_persona As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Comunicacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_ficha As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ug_Documentos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_ccosto As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_OCUPACION As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_NIVEL_EDU As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_TIPO_TRABAJADOR As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ume_PE_FEC_INSCRIP_REG_PEN As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_REGIMEN_LABORAL As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_PE_FEC_ING As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel40 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_PE_FEC_CESE As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_TIPO_CESE As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_PE_SUJETO_REG_ALT As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_PE_SUJETO_JOR_MAX As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_PE_DISCAPACIDAD As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel43 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel44 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_SCTR_PENSION As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_SCTR_SALUD As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_PE_SUJETO_HORA_NOC As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_PE_ES_SINDICALIZADO As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_PE_OTRO_ING_5TA As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_PE_DOMICILIADO As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel47 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel46 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel45 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_COD_EPS_SER_PRO As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_AFILIADO_EPS_SER_PRO As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_PERIODO_REMUNERA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel48 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_SITUACION_EPS As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel49 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_TIPO_PAGO As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel50 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_SITUACION_ESPECIAL As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel51 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_CLASIFI_PER As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel53 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_ID_AREA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_PE_ASIGNACION_FAM As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents une_PE_NUM_HIJOS As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel54 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel57 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel55 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel56 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PE_NUM_CUENTA_CTS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_PE_ID_BANCO_CTS As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_MONEDA_CTS As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_PE_ID_TIPO_CUENTA_CTS As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents gb_DatosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents ubtn_eliminar_img As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_editar_img As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uchk_PE_AFECTO_QUINTA As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel59 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_id_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents gb_DatosLaborales As System.Windows.Forms.GroupBox
    Friend WithEvents gb_DatosAdicioanles As System.Windows.Forms.GroupBox
    Friend WithEvents uds_Ccosto As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel60 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_total_porce_cc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents uchart_cc As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents ubtn_agregar_archivo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel61 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Documentos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_ver_doc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_Contratos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel64 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_TIPO_PERSO_TARIFA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_TIPO_PER As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel52 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PE_ID_PERSONAL As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_Conceptos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Conceptos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel65 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel66 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_codigo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Tool_Reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_direccion As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_datos_personales As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugb_telefonos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_PE_ID_SEXO As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_PE_CONSIDERA_FT As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_cts As System.Windows.Forms.GroupBox
    Friend WithEvents gb_remuneracion As System.Windows.Forms.GroupBox
    Friend WithEvents gb_afp As System.Windows.Forms.GroupBox
    Friend WithEvents gb_cese As System.Windows.Forms.GroupBox
    Friend WithEvents gb_otros As System.Windows.Forms.GroupBox
    Friend WithEvents gb_otros2 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_otro1 As System.Windows.Forms.GroupBox
    Friend WithEvents uchk_Calcular_cts As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_cod_interbancario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel58 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ume_quinta_ant As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel68 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_EsRia As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ubtn_Generar_Contrato As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel63 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_Contratos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel67 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uos_tipo_comi As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel69 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel70 As Infragistics.Win.Misc.UltraLabel
End Class
