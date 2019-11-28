<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Folio_Comprobante
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
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ume_igv = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_base = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_Importe = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txt_idtrabajador = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod_per = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_NumDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SerieDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_cod_Doc_Cab = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_trabajador = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Folio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_idtrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_Doc_Cab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Folio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt_Folio)
        Me.UltraGroupBox1.Controls.Add(Me.ume_igv)
        Me.UltraGroupBox1.Controls.Add(Me.ume_base)
        Me.UltraGroupBox1.Controls.Add(Me.ume_Importe)
        Me.UltraGroupBox1.Controls.Add(Me.txt_idtrabajador)
        Me.UltraGroupBox1.Controls.Add(Me.txt_cod_per)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txt_NumDoc)
        Me.UltraGroupBox1.Controls.Add(Me.txt_SerieDoc)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox1.Controls.Add(Me.txt_cod_Doc_Cab)
        Me.UltraGroupBox1.Controls.Add(Me.uce_TipoDoc)
        Me.UltraGroupBox1.Controls.Add(Me.txt_trabajador)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(406, 185)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'ume_igv
        '
        Me.ume_igv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance93.TextHAlignAsString = "Right"
        Me.ume_igv.Appearance = Appearance93
        Me.ume_igv.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_igv.InputMask = "{double:-9.3}"
        Me.ume_igv.Location = New System.Drawing.Point(282, 146)
        Me.ume_igv.Name = "ume_igv"
        Me.ume_igv.Size = New System.Drawing.Size(109, 20)
        Me.ume_igv.TabIndex = 8
        '
        'ume_base
        '
        Me.ume_base.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.TextHAlignAsString = "Right"
        Me.ume_base.Appearance = Appearance5
        Me.ume_base.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_base.InputMask = "{double:-9.3}"
        Me.ume_base.Location = New System.Drawing.Point(282, 120)
        Me.ume_base.Name = "ume_base"
        Me.ume_base.Size = New System.Drawing.Size(109, 20)
        Me.ume_base.TabIndex = 7
        '
        'ume_Importe
        '
        Me.ume_Importe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance7.TextHAlignAsString = "Right"
        Me.ume_Importe.Appearance = Appearance7
        Me.ume_Importe.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Importe.InputMask = "{double:-9.3}"
        Me.ume_Importe.Location = New System.Drawing.Point(84, 123)
        Me.ume_Importe.Name = "ume_Importe"
        Me.ume_Importe.Size = New System.Drawing.Size(109, 20)
        Me.ume_Importe.TabIndex = 6
        '
        'txt_idtrabajador
        '
        Me.txt_idtrabajador.Location = New System.Drawing.Point(341, 62)
        Me.txt_idtrabajador.Name = "txt_idtrabajador"
        Me.txt_idtrabajador.ReadOnly = True
        Me.txt_idtrabajador.Size = New System.Drawing.Size(50, 21)
        Me.txt_idtrabajador.TabIndex = 9
        Me.txt_idtrabajador.Visible = False
        '
        'txt_cod_per
        '
        Me.txt_cod_per.Location = New System.Drawing.Point(84, 35)
        Me.txt_cod_per.Name = "txt_cod_per"
        Me.txt_cod_per.ReadOnly = True
        Me.txt_cod_per.Size = New System.Drawing.Size(50, 21)
        Me.txt_cod_per.TabIndex = 0
        '
        'UltraLabel3
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance81
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(140, 93)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(12, 14)
        Me.UltraLabel3.TabIndex = 57
        Me.UltraLabel3.Text = "--"
        '
        'txt_NumDoc
        '
        Me.txt_NumDoc.Location = New System.Drawing.Point(155, 89)
        Me.txt_NumDoc.Name = "txt_NumDoc"
        Me.txt_NumDoc.Size = New System.Drawing.Size(102, 21)
        Me.txt_NumDoc.TabIndex = 5
        '
        'txt_SerieDoc
        '
        Appearance77.TextHAlignAsString = "Left"
        Me.txt_SerieDoc.Appearance = Appearance77
        Me.txt_SerieDoc.Location = New System.Drawing.Point(84, 89)
        Me.txt_SerieDoc.Name = "txt_SerieDoc"
        Me.txt_SerieDoc.Size = New System.Drawing.Size(53, 21)
        Me.txt_SerieDoc.TabIndex = 4
        '
        'UltraLabel6
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance2
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(257, 149)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(19, 14)
        Me.UltraLabel6.TabIndex = 54
        Me.UltraLabel6.Text = "Igv"
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(246, 123)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel5.TabIndex = 54
        Me.UltraLabel5.Text = "Base"
        '
        'UltraLabel4
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance9
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(14, 126)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 54
        Me.UltraLabel4.Text = "Importe"
        '
        'UltraLabel2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(14, 93)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel2.TabIndex = 54
        Me.UltraLabel2.Text = "Ser. / Num."
        '
        'UltraLabel9
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance1
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(14, 66)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel9.TabIndex = 54
        Me.UltraLabel9.Text = "Documento"
        '
        'txt_cod_Doc_Cab
        '
        Me.txt_cod_Doc_Cab.Location = New System.Drawing.Point(84, 62)
        Me.txt_cod_Doc_Cab.Name = "txt_cod_Doc_Cab"
        Me.txt_cod_Doc_Cab.Size = New System.Drawing.Size(26, 21)
        Me.txt_cod_Doc_Cab.TabIndex = 2
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc.DropDownListWidth = 200
        Me.uce_TipoDoc.Location = New System.Drawing.Point(110, 62)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(171, 21)
        Me.uce_TipoDoc.TabIndex = 3
        '
        'txt_trabajador
        '
        Me.txt_trabajador.Location = New System.Drawing.Point(133, 35)
        Me.txt_trabajador.Name = "txt_trabajador"
        Me.txt_trabajador.ReadOnly = True
        Me.txt_trabajador.Size = New System.Drawing.Size(258, 21)
        Me.txt_trabajador.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(14, 39)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Trabajador :"
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(254, 203)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 28)
        Me.ubtn_Aceptar.TabIndex = 0
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(335, 203)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(83, 28)
        Me.ubtn_Cancelar.TabIndex = 1
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'UltraLabel7
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance3
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(14, 12)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(35, 14)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "Folio :"
        '
        'txt_Folio
        '
        Me.txt_Folio.Location = New System.Drawing.Point(84, 8)
        Me.txt_Folio.Name = "txt_Folio"
        Me.txt_Folio.ReadOnly = True
        Me.txt_Folio.Size = New System.Drawing.Size(307, 21)
        Me.txt_Folio.TabIndex = 58
        '
        'PL_PR_Folio_Comprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(429, 237)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_PR_Folio_Comprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_idtrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_Doc_Cab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Folio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_trabajador As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_cod_Doc_Cab As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_NumDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SerieDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_cod_per As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idtrabajador As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_igv As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_base As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Importe As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Folio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
End Class
