<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_BuscaPaciente
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
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NUM_HIST")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_NOMBRE")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_APE_PAT")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_APE_MAT")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_APE_CASADA")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NOMBRE1")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NOMBRE2")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_TDOC")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NDOC")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_FNAC")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_FING")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_SEXO")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_EST_CIVIL")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_DIR")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_OCUPACION")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDNACIONALIDAD")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_UBIGEO")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDGRUPO_S")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDCONDICION")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDRECOMENDACION")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_IDMEDICO")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_FNAC_TITU")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_TITULAR")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_UBICACION")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_ALERGIAS")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_TIPO_H_C")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_EDAD_REG")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_DetRecom")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NUM_HIST")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_NOMBRE")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_APE_PAT")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_APE_MAT")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_APE_CASADA")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NOMBRE1")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NOMBRE2")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_TDOC")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NDOC")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_FNAC")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_FING")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_SEXO")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_EST_CIVIL")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_DIR")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_OCUPACION")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDNACIONALIDAD")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_UBIGEO")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDGRUPO_S")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDCONDICION")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDRECOMENDACION")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_IDMEDICO")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_FNAC_TITU")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_TITULAR")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_UBICACION")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_ALERGIAS")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_TIPO_H_C")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_EDAD_REG")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_DetRecom")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.txt_ApePat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Historia = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ug_Lista_Hist_Clin = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_ListaHC = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.uck_ApePat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_ApeMat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_ApeCas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Nombres = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Historia = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Doc = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.utxt_ApeMat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_Nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_ApeCas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_Documento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_Historia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.txt_ApePat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ug_Lista_Hist_Clin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ListaHC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_ApeMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_ApeCas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_Historia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(799, 64)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Aceptar.TabIndex = 13
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.ubtn_Consultar.Appearance = Appearance54
        Me.ubtn_Consultar.Location = New System.Drawing.Point(778, 35)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(120, 26)
        Me.ubtn_Consultar.TabIndex = 12
        Me.ubtn_Consultar.Text = "Consultar"
        '
        'txt_ApePat
        '
        Me.txt_ApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ApePat.Location = New System.Drawing.Point(125, 36)
        Me.txt_ApePat.MaxLength = 50
        Me.txt_ApePat.Name = "txt_ApePat"
        Me.txt_ApePat.Size = New System.Drawing.Size(133, 21)
        Me.txt_ApePat.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Agregar, Me.ToolStripSeparator1, Me.Tool_Historia, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(910, 25)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Agregar
        '
        Me.Tool_Agregar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tool_Agregar.Image = Global.Contabilidad.My.Resources.Resources.user_add
        Me.Tool_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Agregar.Name = "Tool_Agregar"
        Me.Tool_Agregar.Size = New System.Drawing.Size(110, 22)
        Me.Tool_Agregar.Text = "Agregar nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Historia
        '
        Me.Tool_Historia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tool_Historia.Image = Global.Contabilidad.My.Resources.Resources._1030
        Me.Tool_Historia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Historia.Name = "Tool_Historia"
        Me.Tool_Historia.Size = New System.Drawing.Size(156, 22)
        Me.Tool_Historia.Text = "Agregar Historia Clinica"
        Me.Tool_Historia.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ug_Lista_Hist_Clin
        '
        Me.ug_Lista_Hist_Clin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista_Hist_Clin.DataSource = Me.uds_ListaHC
        Me.ug_Lista_Hist_Clin.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Nº HISTORIA C."
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 70
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "APELLIDOS Y NOMBRES"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 270
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 161
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 130
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 131
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "Nº DOCUMENTO"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "F. NACIMIENTO"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.Header.Caption = "DIRECCIÓN"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        Me.ug_Lista_Hist_Clin.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista_Hist_Clin.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista_Hist_Clin.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista_Hist_Clin.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista_Hist_Clin.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Lista_Hist_Clin.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista_Hist_Clin.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista_Hist_Clin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista_Hist_Clin.Location = New System.Drawing.Point(12, 98)
        Me.ug_Lista_Hist_Clin.Name = "ug_Lista_Hist_Clin"
        Me.ug_Lista_Hist_Clin.Size = New System.Drawing.Size(886, 437)
        Me.ug_Lista_Hist_Clin.TabIndex = 2
        Me.ug_Lista_Hist_Clin.Text = "UltraGrid1"
        '
        'uds_ListaHC
        '
        Me.uds_ListaHC.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn2.DataType = GetType(Long)
        UltraDataColumn9.DataType = GetType(Integer)
        UltraDataColumn10.DataType = GetType(Integer)
        UltraDataColumn19.DataType = GetType(Integer)
        UltraDataColumn20.DataType = GetType(Integer)
        UltraDataColumn21.DataType = GetType(Integer)
        UltraDataColumn25.DataType = GetType(Integer)
        UltraDataColumn27.DataType = GetType(Integer)
        UltraDataColumn28.DataType = GetType(Integer)
        Me.uds_ListaHC.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29})
        '
        'uck_ApePat
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uck_ApePat.Appearance = Appearance3
        Me.uck_ApePat.BackColor = System.Drawing.Color.Transparent
        Me.uck_ApePat.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_ApePat.Location = New System.Drawing.Point(15, 36)
        Me.uck_ApePat.Name = "uck_ApePat"
        Me.uck_ApePat.Size = New System.Drawing.Size(107, 22)
        Me.uck_ApePat.TabIndex = 0
        Me.uck_ApePat.Text = "Apellido Paterno"
        '
        'uck_ApeMat
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uck_ApeMat.Appearance = Appearance4
        Me.uck_ApeMat.BackColor = System.Drawing.Color.Transparent
        Me.uck_ApeMat.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_ApeMat.Location = New System.Drawing.Point(15, 64)
        Me.uck_ApeMat.Name = "uck_ApeMat"
        Me.uck_ApeMat.Size = New System.Drawing.Size(119, 22)
        Me.uck_ApeMat.TabIndex = 2
        Me.uck_ApeMat.Text = "Apellido Materno"
        '
        'uck_ApeCas
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.uck_ApeCas.Appearance = Appearance6
        Me.uck_ApeCas.BackColor = System.Drawing.Color.Transparent
        Me.uck_ApeCas.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_ApeCas.Location = New System.Drawing.Point(278, 36)
        Me.uck_ApeCas.Name = "uck_ApeCas"
        Me.uck_ApeCas.Size = New System.Drawing.Size(107, 22)
        Me.uck_ApeCas.TabIndex = 4
        Me.uck_ApeCas.Text = "Apellido Casada"
        '
        'uck_Nombres
        '
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.uck_Nombres.Appearance = Appearance7
        Me.uck_Nombres.BackColor = System.Drawing.Color.Transparent
        Me.uck_Nombres.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Nombres.Location = New System.Drawing.Point(278, 64)
        Me.uck_Nombres.Name = "uck_Nombres"
        Me.uck_Nombres.Size = New System.Drawing.Size(107, 22)
        Me.uck_Nombres.TabIndex = 6
        Me.uck_Nombres.Text = "Nombres"
        '
        'uck_Historia
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.uck_Historia.Appearance = Appearance2
        Me.uck_Historia.BackColor = System.Drawing.Color.Transparent
        Me.uck_Historia.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Historia.Location = New System.Drawing.Point(541, 36)
        Me.uck_Historia.Name = "uck_Historia"
        Me.uck_Historia.Size = New System.Drawing.Size(86, 22)
        Me.uck_Historia.TabIndex = 8
        Me.uck_Historia.Text = "Nº Historia"
        '
        'uck_Doc
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uck_Doc.Appearance = Appearance5
        Me.uck_Doc.BackColor = System.Drawing.Color.Transparent
        Me.uck_Doc.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Doc.Location = New System.Drawing.Point(541, 64)
        Me.uck_Doc.Name = "uck_Doc"
        Me.uck_Doc.Size = New System.Drawing.Size(86, 22)
        Me.uck_Doc.TabIndex = 10
        Me.uck_Doc.Text = "Nº Doc"
        '
        'utxt_ApeMat
        '
        Me.utxt_ApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_ApeMat.Location = New System.Drawing.Point(125, 63)
        Me.utxt_ApeMat.MaxLength = 50
        Me.utxt_ApeMat.Name = "utxt_ApeMat"
        Me.utxt_ApeMat.Size = New System.Drawing.Size(133, 21)
        Me.utxt_ApeMat.TabIndex = 3
        '
        'utxt_Nombres
        '
        Me.utxt_Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Nombres.Location = New System.Drawing.Point(353, 63)
        Me.utxt_Nombres.MaxLength = 50
        Me.utxt_Nombres.Name = "utxt_Nombres"
        Me.utxt_Nombres.Size = New System.Drawing.Size(164, 21)
        Me.utxt_Nombres.TabIndex = 7
        '
        'utxt_ApeCas
        '
        Me.utxt_ApeCas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_ApeCas.Location = New System.Drawing.Point(384, 36)
        Me.utxt_ApeCas.MaxLength = 50
        Me.utxt_ApeCas.Name = "utxt_ApeCas"
        Me.utxt_ApeCas.Size = New System.Drawing.Size(133, 21)
        Me.utxt_ApeCas.TabIndex = 5
        '
        'utxt_Documento
        '
        Me.utxt_Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Documento.Location = New System.Drawing.Point(624, 63)
        Me.utxt_Documento.MaxLength = 50
        Me.utxt_Documento.Name = "utxt_Documento"
        Me.utxt_Documento.Size = New System.Drawing.Size(124, 21)
        Me.utxt_Documento.TabIndex = 11
        '
        'utxt_Historia
        '
        Me.utxt_Historia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_Historia.Location = New System.Drawing.Point(624, 36)
        Me.utxt_Historia.MaxLength = 50
        Me.utxt_Historia.Name = "utxt_Historia"
        Me.utxt_Historia.Size = New System.Drawing.Size(124, 21)
        Me.utxt_Historia.TabIndex = 9
        '
        'AD_PR_BuscaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(910, 540)
        Me.Controls.Add(Me.utxt_Documento)
        Me.Controls.Add(Me.utxt_Historia)
        Me.Controls.Add(Me.utxt_Nombres)
        Me.Controls.Add(Me.utxt_ApeCas)
        Me.Controls.Add(Me.utxt_ApeMat)
        Me.Controls.Add(Me.uck_Doc)
        Me.Controls.Add(Me.uck_Historia)
        Me.Controls.Add(Me.uck_Nombres)
        Me.Controls.Add(Me.uck_ApeCas)
        Me.Controls.Add(Me.uck_ApeMat)
        Me.Controls.Add(Me.uck_ApePat)
        Me.Controls.Add(Me.ug_Lista_Hist_Clin)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ubtn_Consultar)
        Me.Controls.Add(Me.txt_ApePat)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AD_PR_BuscaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca Paciente ..."
        CType(Me.txt_ApePat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ug_Lista_Hist_Clin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ListaHC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_ApeMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_ApeCas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_Historia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_ApePat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ug_Lista_Hist_Clin As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tool_Historia As System.Windows.Forms.ToolStripButton
    Friend WithEvents uds_ListaHC As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uck_ApePat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_ApeMat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_ApeCas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Nombres As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Historia As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Doc As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents utxt_ApeMat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_Nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_ApeCas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_Documento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_Historia As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
