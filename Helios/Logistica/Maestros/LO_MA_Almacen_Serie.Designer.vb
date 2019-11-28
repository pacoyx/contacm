<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_MA_Almacen_Serie
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
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AS_TDOC")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TD_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AS_SERIE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AS_TDOC")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TD_DESCRIPCION")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AS_SERIE")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_eliminar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Agregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_series = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.uce_Almacen = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Serie = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_series, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Almacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc.DropDownListWidth = 100
        Me.uce_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoDoc.Location = New System.Drawing.Point(78, 59)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(257, 21)
        Me.uce_TipoDoc.TabIndex = 1
        '
        'UltraLabel9
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance6
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(19, 63)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel9.TabIndex = 133
        Me.UltraLabel9.Text = "Tip Doc :"
        '
        'ubtn_eliminar
        '
        Me.ubtn_eliminar.Location = New System.Drawing.Point(337, 86)
        Me.ubtn_eliminar.Name = "ubtn_eliminar"
        Me.ubtn_eliminar.Size = New System.Drawing.Size(69, 23)
        Me.ubtn_eliminar.TabIndex = 4
        Me.ubtn_eliminar.Text = "Eliminar"
        '
        'ubtn_Agregar
        '
        Me.ubtn_Agregar.Location = New System.Drawing.Point(264, 86)
        Me.ubtn_Agregar.Name = "ubtn_Agregar"
        Me.ubtn_Agregar.Size = New System.Drawing.Size(71, 23)
        Me.ubtn_Agregar.TabIndex = 3
        Me.ubtn_Agregar.Text = "&Agregar"
        '
        'UltraLabel1
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance16
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(19, 90)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel1.TabIndex = 129
        Me.UltraLabel1.Text = "Serie"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(423, 25)
        Me.ToolStrip1.TabIndex = 127
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_series
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Tipo Doc."
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 75
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Tipo de documento"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 182
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Serie"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(14, 115)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(394, 217)
        Me.ug_Lista.TabIndex = 5
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_series
        '
        Me.uds_series.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'uce_Almacen
        '
        Me.uce_Almacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Almacen.Location = New System.Drawing.Point(78, 32)
        Me.uce_Almacen.Name = "uce_Almacen"
        Me.uce_Almacen.Size = New System.Drawing.Size(257, 21)
        Me.uce_Almacen.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance3
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(20, 36)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel2.TabIndex = 135
        Me.UltraLabel2.Text = "Almacen"
        '
        'uce_Serie
        '
        Me.uce_Serie.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Serie.DropDownListWidth = 100
        Me.uce_Serie.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Serie.Location = New System.Drawing.Point(78, 88)
        Me.uce_Serie.Name = "uce_Serie"
        Me.uce_Serie.Size = New System.Drawing.Size(142, 21)
        Me.uce_Serie.TabIndex = 2
        '
        'LO_MA_Almacen_Serie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 344)
        Me.Controls.Add(Me.uce_Serie)
        Me.Controls.Add(Me.uce_Almacen)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.uce_TipoDoc)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.ubtn_eliminar)
        Me.Controls.Add(Me.ubtn_Agregar)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_Lista)
        Me.Name = "LO_MA_Almacen_Serie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Doc. y Serie al Almacen"
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_series, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Almacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_eliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uce_Almacen As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_series As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uce_Serie As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
