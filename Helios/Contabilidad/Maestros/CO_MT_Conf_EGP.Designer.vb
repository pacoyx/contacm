﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Conf_EGP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_IDCUENTA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUM_CUENTA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Me.ut_formatoegp12 = New Infragistics.Win.UltraWinTree.UltraTree
        Me.ubtn_Recargar_BG2010 = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Guardar_BG_2010 = New Infragistics.Win.Misc.UltraButton
        Me.ug_Cuentas10 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        CType(Me.ut_formatoegp12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Cuentas10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ut_formatoegp12
        '
        Me.ut_formatoegp12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ut_formatoegp12.DisplayStyle = Infragistics.Win.UltraWinTree.UltraTreeDisplayStyle.WindowsVista
        Me.ut_formatoegp12.HideSelection = False
        Me.ut_formatoegp12.Location = New System.Drawing.Point(12, 45)
        Me.ut_formatoegp12.Name = "ut_formatoegp12"
        Me.ut_formatoegp12.NodeConnectorStyle = Infragistics.Win.UltraWinTree.NodeConnectorStyle.Solid
        Me.ut_formatoegp12.Size = New System.Drawing.Size(360, 426)
        Me.ut_formatoegp12.TabIndex = 2
        '
        'ubtn_Recargar_BG2010
        '
        Appearance7.Image = Global.Contabilidad.My.Resources.Resources.arrow_refresh
        Me.ubtn_Recargar_BG2010.Appearance = Appearance7
        Me.ubtn_Recargar_BG2010.Location = New System.Drawing.Point(378, 45)
        Me.ubtn_Recargar_BG2010.Name = "ubtn_Recargar_BG2010"
        Me.ubtn_Recargar_BG2010.Size = New System.Drawing.Size(26, 23)
        Me.ubtn_Recargar_BG2010.TabIndex = 10
        '
        'ubtn_Guardar_BG_2010
        '
        Me.ubtn_Guardar_BG_2010.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance21.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.ubtn_Guardar_BG_2010.Appearance = Appearance21
        Me.ubtn_Guardar_BG_2010.Location = New System.Drawing.Point(644, 42)
        Me.ubtn_Guardar_BG_2010.Name = "ubtn_Guardar_BG_2010"
        Me.ubtn_Guardar_BG_2010.Size = New System.Drawing.Size(75, 26)
        Me.ubtn_Guardar_BG_2010.TabIndex = 9
        Me.ubtn_Guardar_BG_2010.Text = "&Guardar"
        '
        'ug_Cuentas10
        '
        Me.ug_Cuentas10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Cuentas10.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Cuenta"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 57
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Descripcion"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Cuentas10.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Cuentas10.Location = New System.Drawing.Point(378, 74)
        Me.ug_Cuentas10.Name = "ug_Cuentas10"
        Me.ug_Cuentas10.Size = New System.Drawing.Size(341, 397)
        Me.ug_Cuentas10.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(731, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'CO_MT_Conf_EGP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(731, 483)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ubtn_Recargar_BG2010)
        Me.Controls.Add(Me.ubtn_Guardar_BG_2010)
        Me.Controls.Add(Me.ug_Cuentas10)
        Me.Controls.Add(Me.ut_formatoegp12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_Conf_EGP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Estado Ganancias y Perdidas"
        CType(Me.ut_formatoegp12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Cuentas10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ut_formatoegp12 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents ubtn_Recargar_BG2010 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Guardar_BG_2010 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ug_Cuentas10 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
End Class
