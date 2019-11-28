<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_Area
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
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ID")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ID_EMPRESA")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_IDJEFE")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_Listado = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Jefe_Area = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_des = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.uds_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.uce_Jefe_Area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_des, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_Listado
        '
        UltraDataColumn5.DataType = GetType(Short)
        UltraDataColumn7.DataType = GetType(Short)
        UltraDataColumn8.DataType = GetType(Integer)
        Me.uds_Listado.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator2, Me.ToolStripSeparator1, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(502, 25)
        Me.ToolS_Mantenimiento.TabIndex = 6
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'UltraLabel2
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(51, 55)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel2.TabIndex = 19
        Me.UltraLabel2.Text = "Descripcion"
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(51, 82)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel1.TabIndex = 20
        Me.UltraLabel1.Text = "Jefe de Area"
        '
        'uce_Jefe_Area
        '
        Me.uce_Jefe_Area.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.uce_Jefe_Area.DropDownListWidth = 300
        Me.uce_Jefe_Area.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Jefe_Area.Location = New System.Drawing.Point(144, 78)
        Me.uce_Jefe_Area.Name = "uce_Jefe_Area"
        Me.uce_Jefe_Area.Size = New System.Drawing.Size(253, 21)
        Me.uce_Jefe_Area.TabIndex = 18
        '
        'txt_des
        '
        Me.txt_des.Location = New System.Drawing.Point(144, 51)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(301, 21)
        Me.txt_des.TabIndex = 17
        '
        'PL_MA_Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(502, 121)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.uce_Jefe_Area)
        Me.Controls.Add(Me.txt_des)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_MA_Area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Areas"
        CType(Me.uds_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.uce_Jefe_Area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_des, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents uds_Listado As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Jefe_Area As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_des As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
