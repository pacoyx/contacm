<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_EnvioMail_xCargos
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_FOTO")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CORREO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ARCHIVO")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_FOTO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CORREO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ARCHIVO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Enviar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.lbl_datos_adj = New System.Windows.Forms.LinkLabel()
        Me.uchk_cadauno = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lbl_eti_datosadj = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_para = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.txt_mensaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_correo_de = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txt_para, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_Enviar, Me.ToolStripSeparator5, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Enviar
        '
        Me.Tool_Enviar.Image = Global.Contabilidad.My.Resources.Resources._16__Mail_style_2_
        Me.Tool_Enviar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Enviar.Name = "Tool_Enviar"
        Me.Tool_Enviar.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Enviar.Text = "Enviar..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
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
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox1.Controls.Add(Me.lbl_correo_de)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(560, 380)
        Me.UltraGroupBox1.TabIndex = 32
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.lbl_datos_adj)
        Me.UltraGroupBox2.Controls.Add(Me.uchk_cadauno)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_eti_datosadj)
        Me.UltraGroupBox2.Controls.Add(Me.txt_para)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.ug_lista)
        Me.UltraGroupBox2.Controls.Add(Me.txt_mensaje)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 40)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(537, 333)
        Me.UltraGroupBox2.TabIndex = 30
        Me.UltraGroupBox2.Text = "Para :"
        '
        'lbl_datos_adj
        '
        Me.lbl_datos_adj.BackColor = System.Drawing.Color.Transparent
        Me.lbl_datos_adj.Location = New System.Drawing.Point(133, 250)
        Me.lbl_datos_adj.Name = "lbl_datos_adj"
        Me.lbl_datos_adj.Size = New System.Drawing.Size(209, 16)
        Me.lbl_datos_adj.TabIndex = 37
        Me.lbl_datos_adj.TabStop = True
        Me.lbl_datos_adj.Text = "LinkLabel1"
        '
        'uchk_cadauno
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uchk_cadauno.Appearance = Appearance4
        Me.uchk_cadauno.BackColor = System.Drawing.Color.Transparent
        Me.uchk_cadauno.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_cadauno.Location = New System.Drawing.Point(319, 22)
        Me.uchk_cadauno.Name = "uchk_cadauno"
        Me.uchk_cadauno.Size = New System.Drawing.Size(209, 20)
        Me.uchk_cadauno.TabIndex = 36
        Me.uchk_cadauno.Text = "Enviar a cada trabajador de la lista"
        '
        'lbl_eti_datosadj
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.lbl_eti_datosadj.Appearance = Appearance7
        Me.lbl_eti_datosadj.AutoSize = True
        Me.lbl_eti_datosadj.Location = New System.Drawing.Point(12, 249)
        Me.lbl_eti_datosadj.Name = "lbl_eti_datosadj"
        Me.lbl_eti_datosadj.Size = New System.Drawing.Size(81, 14)
        Me.lbl_eti_datosadj.TabIndex = 33
        Me.lbl_eti_datosadj.Text = "Datos Adjuntos"
        '
        'txt_para
        '
        Me.txt_para.Location = New System.Drawing.Point(52, 21)
        Me.txt_para.Name = "txt_para"
        Me.txt_para.Size = New System.Drawing.Size(218, 21)
        Me.txt_para.TabIndex = 32
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 25)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel1.TabIndex = 31
        Me.UltraLabel1.Text = "Para :"
        '
        'ug_lista
        '
        Me.ug_lista.DataSource = Me.uds_lista
        Me.ug_lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn1.CellAppearance = Appearance1
        UltraGridColumn1.Header.Caption = "FOTO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Image
        UltraGridColumn1.Width = 45
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 63
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 206
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.ug_lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_lista.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance5.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_lista.DisplayLayout.Override.RowAlternateAppearance = Appearance5
        Me.ug_lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_lista.Location = New System.Drawing.Point(12, 48)
        Me.ug_lista.Name = "ug_lista"
        Me.ug_lista.Size = New System.Drawing.Size(516, 188)
        Me.ug_lista.TabIndex = 30
        Me.ug_lista.Text = "UltraGrid1"
        '
        'uds_lista
        '
        Me.uds_lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(System.Drawing.Bitmap)
        UltraDataColumn2.DataType = GetType(Long)
        Me.uds_lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'txt_mensaje
        '
        Me.txt_mensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_mensaje.Location = New System.Drawing.Point(136, 272)
        Me.txt_mensaje.Multiline = True
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(392, 55)
        Me.txt_mensaje.TabIndex = 29
        '
        'UltraLabel4
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance38
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(12, 272)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel4.TabIndex = 28
        Me.UltraLabel4.Text = "Mensaje"
        '
        'lbl_correo_de
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.lbl_correo_de.Appearance = Appearance8
        Me.lbl_correo_de.Location = New System.Drawing.Point(71, 18)
        Me.lbl_correo_de.Name = "lbl_correo_de"
        Me.lbl_correo_de.Size = New System.Drawing.Size(376, 16)
        Me.lbl_correo_de.TabIndex = 28
        Me.lbl_correo_de.Text = "De :"
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(22, 18)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(25, 14)
        Me.UltraLabel3.TabIndex = 28
        Me.UltraLabel3.Text = "De :"
        '
        'PL_RP_EnvioMail_xCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_RP_EnvioMail_xCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnvioMail por Cargos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.txt_para, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Enviar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_mensaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_correo_de As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_para As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_eti_datosadj As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_cadauno As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents lbl_datos_adj As System.Windows.Forms.LinkLabel
End Class
