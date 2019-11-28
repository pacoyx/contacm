<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_LT_DocRef
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
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_TipoDocRef = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_NumDocRef = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SerieDocRef = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_aceptar = New Infragistics.Win.Misc.UltraButton()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_TipoDocRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDocRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerieDocRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_TipoDocRef)
        Me.UltraGroupBox1.Controls.Add(Me.txt_NumDocRef)
        Me.UltraGroupBox1.Controls.Add(Me.txt_SerieDocRef)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(386, 122)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Doc. Referencia"
        '
        'uce_TipoDocRef
        '
        Me.uce_TipoDocRef.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDocRef.DropDownListWidth = 80
        Me.uce_TipoDocRef.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoDocRef.Location = New System.Drawing.Point(88, 29)
        Me.uce_TipoDocRef.Name = "uce_TipoDocRef"
        Me.uce_TipoDocRef.Size = New System.Drawing.Size(68, 21)
        Me.uce_TipoDocRef.TabIndex = 0
        '
        'txt_NumDocRef
        '
        Me.txt_NumDocRef.Location = New System.Drawing.Point(88, 83)
        Me.txt_NumDocRef.Name = "txt_NumDocRef"
        Me.txt_NumDocRef.Size = New System.Drawing.Size(102, 21)
        Me.txt_NumDocRef.TabIndex = 2
        '
        'txt_SerieDocRef
        '
        Appearance77.TextHAlignAsString = "Left"
        Me.txt_SerieDocRef.Appearance = Appearance77
        Me.txt_SerieDocRef.Location = New System.Drawing.Point(88, 56)
        Me.txt_SerieDocRef.Name = "txt_SerieDocRef"
        Me.txt_SerieDocRef.Size = New System.Drawing.Size(53, 21)
        Me.txt_SerieDocRef.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(24, 87)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel2.TabIndex = 92
        Me.UltraLabel2.Text = "Num. Doc."
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(24, 60)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel1.TabIndex = 92
        Me.UltraLabel1.Text = "Ser. Doc."
        '
        'UltraLabel9
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance2
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(24, 33)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel9.TabIndex = 92
        Me.UltraLabel9.Text = "Tip. Doc."
        '
        'ubtn_aceptar
        '
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.ubtn_aceptar.Appearance = Appearance3
        Me.ubtn_aceptar.Location = New System.Drawing.Point(306, 140)
        Me.ubtn_aceptar.Name = "ubtn_aceptar"
        Me.ubtn_aceptar.Size = New System.Drawing.Size(92, 33)
        Me.ubtn_aceptar.TabIndex = 0
        Me.ubtn_aceptar.Text = "&Aceptar"
        '
        'LO_LT_DocRef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(410, 178)
        Me.Controls.Add(Me.ubtn_aceptar)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LO_LT_DocRef"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento de Referencia"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_TipoDocRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDocRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerieDocRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_TipoDocRef As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumDocRef As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SerieDocRef As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_aceptar As Infragistics.Win.Misc.UltraButton
End Class
