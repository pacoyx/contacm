<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MA_RE_ConsultaPapeleta
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PA_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EMPLEADO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MO_DESCRIPCION")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PA_DET_OTROS")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("JEFE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PA_FEC_INI")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PA_FEC_FIN")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PA_HOR_INI")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PA_HOR_FIN")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_NUM_DOC_PER")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PA_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMPLEADO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MO_DESCRIPCION")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PA_DET_OTROS")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JEFE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PA_FEC_INI")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PA_FEC_FIN")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PA_HOR_INI")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PA_HOR_FIN")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_NUM_DOC_PER")
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Actualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imp_Resumen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imp_Papeleta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_id_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_nom_emple = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uds_Consulta = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Lis_Pap = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nom_emple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lis_Pap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Actualizar, Me.ToolStripSeparator3, Me.Tool_Imp_Resumen, Me.ToolStripSeparator2, Me.Tool_Imp_Papeleta, Me.ToolStripSeparator4, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(725, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Actualizar
        '
        Me.Tool_Actualizar.Image = Global.Contabilidad.My.Resources.Resources.action_refresh_blue
        Me.Tool_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Actualizar.Name = "Tool_Actualizar"
        Me.Tool_Actualizar.Size = New System.Drawing.Size(79, 22)
        Me.Tool_Actualizar.Text = "Actualizar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imp_Resumen
        '
        Me.Tool_Imp_Resumen.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imp_Resumen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imp_Resumen.Name = "Tool_Imp_Resumen"
        Me.Tool_Imp_Resumen.Size = New System.Drawing.Size(76, 22)
        Me.Tool_Imp_Resumen.Text = "Resumen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imp_Papeleta
        '
        Me.Tool_Imp_Papeleta.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imp_Papeleta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imp_Papeleta.Name = "Tool_Imp_Papeleta"
        Me.Tool_Imp_Papeleta.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Imp_Papeleta.Text = "Papeleta"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt_id_personal)
        Me.UltraGroupBox1.Controls.Add(Me.txt_nom_emple)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(425, 32)
        Me.UltraGroupBox1.TabIndex = 15
        '
        'txt_id_personal
        '
        Me.txt_id_personal.Location = New System.Drawing.Point(423, 6)
        Me.txt_id_personal.Name = "txt_id_personal"
        Me.txt_id_personal.ReadOnly = True
        Me.txt_id_personal.Size = New System.Drawing.Size(33, 21)
        Me.txt_id_personal.TabIndex = 16
        Me.txt_id_personal.Visible = False
        '
        'txt_nom_emple
        '
        Me.txt_nom_emple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_emple.Location = New System.Drawing.Point(79, 5)
        Me.txt_nom_emple.MaxLength = 250
        Me.txt_nom_emple.Name = "txt_nom_emple"
        Me.txt_nom_emple.ReadOnly = True
        Me.txt_nom_emple.Size = New System.Drawing.Size(338, 21)
        Me.txt_nom_emple.TabIndex = 13
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel1.TabIndex = 11
        Me.UltraLabel1.Text = "Empleado : "
        '
        'uds_Consulta
        '
        Me.uds_Consulta.AllowAdd = False
        Me.uds_Consulta.AllowDelete = False
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Date)
        Me.uds_Consulta.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'ug_Lis_Pap
        '
        Me.ug_Lis_Pap.DataSource = Me.uds_Consulta
        Me.ug_Lis_Pap.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Nº Pap."
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 58
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 101
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Motivo"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 153
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Observaciones"
        UltraGridColumn5.Header.VisiblePosition = 9
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Jefe Inmediato"
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 123
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Fec.Ini."
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Width = 85
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.Caption = "Fec.Fin."
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Width = 79
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "Hor.Ini."
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Width = 85
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "Hor.Fin."
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Width = 77
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.ug_Lis_Pap.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lis_Pap.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Lis_Pap.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lis_Pap.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lis_Pap.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Lis_Pap.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_Lis_Pap.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lis_Pap.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lis_Pap.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ug_Lis_Pap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lis_Pap.Location = New System.Drawing.Point(12, 65)
        Me.ug_Lis_Pap.Name = "ug_Lis_Pap"
        Me.ug_Lis_Pap.Size = New System.Drawing.Size(701, 247)
        Me.ug_Lis_Pap.TabIndex = 16
        Me.ug_Lis_Pap.Text = "Lista de Papeletas"
        '
        'MA_RE_ConsultaPapeleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(725, 324)
        Me.Controls.Add(Me.ug_Lis_Pap)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MA_RE_ConsultaPapeleta"
        Me.Text = "Consulta de Papeleta"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nom_emple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lis_Pap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Actualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Imp_Resumen As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_id_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_nom_emple As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Consulta As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Lis_Pap As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tool_Imp_Papeleta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
