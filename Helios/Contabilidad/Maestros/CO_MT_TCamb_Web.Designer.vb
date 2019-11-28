<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_TCamb_Web
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
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim RibbonTab1 As Infragistics.Win.UltraWinToolbars.RibbonTab = New Infragistics.Win.UltraWinToolbars.RibbonTab("gru_Opciones")
        Dim RibbonGroup1 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("rib_inicio")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_tc_Sunat")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_tc_Sbs")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_Con_Ruc")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_salir")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_tc_Sunat")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_tc_Sbs")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_Con_Ruc")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("tool_salir")
        Me.wb_tc = New System.Windows.Forms.WebBrowser()
        Me.usb_Web = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wb_tc
        '
        Me.wb_tc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wb_tc.Location = New System.Drawing.Point(12, 159)
        Me.wb_tc.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_tc.Name = "wb_tc"
        Me.wb_tc.Size = New System.Drawing.Size(738, 367)
        Me.wb_tc.TabIndex = 1
        '
        'usb_Web
        '
        Me.usb_Web.Location = New System.Drawing.Point(0, 532)
        Me.usb_Web.Name = "usb_Web"
        UltraStatusPanel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        UltraStatusPanel1.Key = "Barra"
        UltraStatusPanel1.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Progress
        UltraStatusPanel1.Width = 200
        Me.usb_Web.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1})
        Me.usb_Web.Size = New System.Drawing.Size(762, 23)
        Me.usb_Web.TabIndex = 3
        Me.usb_Web.Text = "UltraStatusBar1"
        Me.usb_Web.ViewStyle = Infragistics.Win.UltraWinStatusBar.ViewStyle.Office2007
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        RibbonTab1.Caption = "Opciones"
        RibbonGroup1.Caption = "Inicio"
        ButtonTool1.InstanceProps.Caption = "Tipo de Cambio Sunat"
        ButtonTool1.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        ButtonTool2.InstanceProps.Caption = "Tipo de Cambio SBS"
        ButtonTool2.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        ButtonTool3.InstanceProps.Caption = "Consulta de RUC Sunat"
        ButtonTool3.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        ButtonTool4.InstanceProps.Caption = "Cerrar Ventana"
        ButtonTool4.InstanceProps.IsFirstInGroup = True
        ButtonTool4.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        RibbonGroup1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4})
        RibbonTab1.Groups.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonGroup() {RibbonGroup1})
        Me.UltraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonTab() {RibbonTab1})
        Me.UltraToolbarsManager1.Ribbon.Visible = True
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        ButtonTool5.SharedProps.Caption = "ButtonTool1"
        ButtonTool6.SharedProps.Caption = "ButtonTool2"
        ButtonTool7.SharedProps.Caption = "ButtonTool3"
        ButtonTool8.SharedProps.Caption = "Cerrar Ventana"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5, ButtonTool6, ButtonTool7, ButtonTool8})
        '
        '_CO_MT_TCamb_Web_Toolbars_Dock_Area_Left
        '
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 4
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 153)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.Name = "_CO_MT_TCamb_Web_Toolbars_Dock_Area_Left"
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(4, 379)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CO_MT_TCamb_Web_Toolbars_Dock_Area_Right
        '
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 4
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(758, 153)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.Name = "_CO_MT_TCamb_Web_Toolbars_Dock_Area_Right"
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(4, 379)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CO_MT_TCamb_Web_Toolbars_Dock_Area_Top
        '
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.Name = "_CO_MT_TCamb_Web_Toolbars_Dock_Area_Top"
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(762, 153)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom
        '
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 532)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.Name = "_CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom"
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(762, 0)
        Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'CO_MT_TCamb_Web
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(762, 555)
        Me.Controls.Add(Me.wb_tc)
        Me.Controls.Add(Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me.usb_Web)
        Me.Name = "CO_MT_TCamb_Web"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagina Web Tipo Cambio Referencial"
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wb_tc As System.Windows.Forms.WebBrowser
    Friend WithEvents usb_Web As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _CO_MT_TCamb_Web_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CO_MT_TCamb_Web_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CO_MT_TCamb_Web_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CO_MT_TCamb_Web_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
End Class
