<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_DetalleCuenta
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cant")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Articulo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_SEG_CUBRE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_DEDUCIBLE")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descuento")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_DSCTO_OTRO")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("idConsulta")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_IDCOMPROBANTE")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_ITEM")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_SINPAGO")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cant")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Articulo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_SEG_CUBRE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_DEDUCIBLE")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descuento")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_DSCTO_OTRO")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("idConsulta")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_IDCOMPROBANTE")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_ITEM")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_SINPAGO")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_Observacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idCita = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_idprogramacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SubTotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IGV = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Total = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.ug_detalle)
        Me.ugb_Datos.Controls.Add(Me.Panel1)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.txt_Observacion)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_Datos.Controls.Add(Me.txt_idCita)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.txt_idprogramacion)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_IdCliente)
        Me.ugb_Datos.Controls.Add(Me.txt_idCuenta)
        Me.ugb_Datos.Location = New System.Drawing.Point(2, 1)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(789, 355)
        Me.ugb_Datos.TabIndex = 33
        '
        'ug_detalle
        '
        Me.ug_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_detalle.DataSource = Me.uds_detalle
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Width = 40
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 50
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 280
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 60
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.Caption = "Cubre"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance4
        UltraGridColumn7.Header.Caption = "Deducible"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 60
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance6
        UltraGridColumn8.Header.Caption = "Dscto Seg."
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 65
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance8
        UltraGridColumn9.Header.Caption = "Dscto Otro"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 65
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance9
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 70
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance10
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 55
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance11
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 65
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_detalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(5, 102)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(776, 247)
        Me.ug_detalle.TabIndex = 156
        Me.ug_detalle.Text = "UltraGrid1"
        '
        'uds_detalle
        '
        Me.uds_detalle.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.[True]
        Me.uds_detalle.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Boolean)
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Integer)
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Integer)
        UltraDataColumn16.DataType = GetType(Integer)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(13, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 2)
        Me.Panel1.TabIndex = 153
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance5.ForeColor = System.Drawing.Color.White
        Appearance5.TextHAlignAsString = "Center"
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(2, 2)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(786, 28)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Registrar Atención"
        '
        'udte_fecha
        '
        Me.udte_fecha.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(65, 37)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(113, 24)
        Me.udte_fecha.TabIndex = 150
        Me.udte_fecha.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'txt_Observacion
        '
        Me.txt_Observacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Observacion.Location = New System.Drawing.Point(88, 65)
        Me.txt_Observacion.MaxLength = 100
        Me.txt_Observacion.Name = "txt_Observacion"
        Me.txt_Observacion.ReadOnly = True
        Me.txt_Observacion.Size = New System.Drawing.Size(672, 21)
        Me.txt_Observacion.TabIndex = 5
        '
        'UltraLabel13
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance7
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(16, 69)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel13.TabIndex = 144
        Me.UltraLabel13.Text = "Observacion"
        '
        'txt_idCita
        '
        Me.txt_idCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idCita.Location = New System.Drawing.Point(13, 19)
        Me.txt_idCita.MaxLength = 50
        Me.txt_idCita.Name = "txt_idCita"
        Me.txt_idCita.ReadOnly = True
        Me.txt_idCita.Size = New System.Drawing.Size(10, 21)
        Me.txt_idCita.TabIndex = 142
        Me.txt_idCita.Visible = False
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(234, 41)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.ReadOnly = True
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 2
        '
        'txt_idprogramacion
        '
        Me.txt_idprogramacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idprogramacion.Location = New System.Drawing.Point(27, 19)
        Me.txt_idprogramacion.MaxLength = 50
        Me.txt_idprogramacion.Name = "txt_idprogramacion"
        Me.txt_idprogramacion.ReadOnly = True
        Me.txt_idprogramacion.Size = New System.Drawing.Size(10, 21)
        Me.txt_idprogramacion.TabIndex = 130
        Me.txt_idprogramacion.Visible = False
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(400, 41)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(360, 21)
        Me.txt_Des_Cliente.TabIndex = 128
        '
        'txt_ruc_cliente
        '
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(297, 41)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.ReadOnly = True
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 3
        '
        'UltraLabel7
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance40
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(184, 45)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel7.TabIndex = 129
        Me.UltraLabel7.Text = "Paciente"
        '
        'UltraLabel1
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance45
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 29
        Me.UltraLabel1.Text = "Fecha"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(279, 34)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.Size = New System.Drawing.Size(37, 21)
        Me.txt_IdCliente.TabIndex = 127
        Me.txt_IdCliente.Visible = False
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance15.TextHAlignAsString = "Right"
        Me.txt_SubTotal.Appearance = Appearance15
        Me.txt_SubTotal.Location = New System.Drawing.Point(306, 362)
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.ReadOnly = True
        Me.txt_SubTotal.Size = New System.Drawing.Size(116, 21)
        Me.txt_SubTotal.TabIndex = 34
        '
        'UltraLabel24
        '
        Me.UltraLabel24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance72
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(250, 364)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(54, 16)
        Me.UltraLabel24.TabIndex = 135
        Me.UltraLabel24.Text = "SubTotal"
        '
        'UltraLabel25
        '
        Me.UltraLabel25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance1
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(449, 364)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(36, 16)
        Me.UltraLabel25.TabIndex = 134
        Me.UltraLabel25.Text = "I.G.V."
        '
        'UltraLabel32
        '
        Me.UltraLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance3
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(619, 364)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(33, 16)
        Me.UltraLabel32.TabIndex = 133
        Me.UltraLabel32.Text = "Total"
        '
        'txt_IGV
        '
        Me.txt_IGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance16.TextHAlignAsString = "Right"
        Me.txt_IGV.Appearance = Appearance16
        Me.txt_IGV.Location = New System.Drawing.Point(485, 362)
        Me.txt_IGV.Name = "txt_IGV"
        Me.txt_IGV.ReadOnly = True
        Me.txt_IGV.Size = New System.Drawing.Size(116, 21)
        Me.txt_IGV.TabIndex = 136
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance17.TextHAlignAsString = "Right"
        Me.txt_Total.Appearance = Appearance17
        Me.txt_Total.Location = New System.Drawing.Point(658, 362)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(116, 21)
        Me.txt_Total.TabIndex = 137
        '
        'txt_idCuenta
        '
        Me.txt_idCuenta.Location = New System.Drawing.Point(347, 26)
        Me.txt_idCuenta.Name = "txt_idCuenta"
        Me.txt_idCuenta.Size = New System.Drawing.Size(37, 21)
        Me.txt_idCuenta.TabIndex = 157
        Me.txt_idCuenta.Visible = False
        '
        'FA_PR_DetalleCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 390)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.txt_IGV)
        Me.Controls.Add(Me.UltraLabel24)
        Me.Controls.Add(Me.UltraLabel25)
        Me.Controls.Add(Me.UltraLabel32)
        Me.Controls.Add(Me.txt_SubTotal)
        Me.Controls.Add(Me.ugb_Datos)
        Me.Name = "FA_PR_DetalleCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Atención"
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_idprogramacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idCita As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Observacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_SubTotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IGV As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Total As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Public WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_idCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
